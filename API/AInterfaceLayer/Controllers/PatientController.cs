using BBussinesLogicLayer.Dtos.Patients;
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Plugins;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AInterfaceLayer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly DataContext _Context;
    private readonly IPatientService _patientService;

    public PatientController(IConfiguration configuration,
        UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
        SignInManager<IdentityUser> signInManager, DataContext Context, IPatientService patientService)
    {
        _configuration = configuration;
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _Context = Context;
        _patientService = patientService;
    }

    [HttpPost]
    [Route("Register")]
    public async Task<ActionResult> Register(PatientRegisterDto patientRegisterDto)
    {
        IdentityResult result = await _patientService.CreateAccountAsync(patientRegisterDto);
        if (!result.Succeeded)
            return BadRequest(result.Errors);
        return NoContent();
    }

    [HttpPost]
    [Route("Login")]
    public async Task<ActionResult<TokenDto>> Login(PatientLoginDto patientLoginDto)
    {
        var user = await _userManager.FindByNameAsync(patientLoginDto.UserNationalId);
        if (user == null)
        {
            return NotFound();
        }

        var isAuthenitcated = await _userManager.CheckPasswordAsync(user, patientLoginDto.Password);
        if (!isAuthenitcated)
        {
            return Unauthorized();
        }

        var claimsList = await _userManager.GetClaimsAsync(user);

        var secretKeyString = _configuration.GetValue<string>("SecretKey") ?? string.Empty;
        var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
        var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

        //Combination SecretKey, HashingAlgorithm
        var siginingCreedentials = new SigningCredentials(secretKey,
            SecurityAlgorithms.HmacSha256Signature);

        var expiry = DateTime.Now.AddDays(4);

        var token = new JwtSecurityToken(
            claims: claimsList,
            expires: expiry,
            signingCredentials: siginingCreedentials);

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenString = tokenHandler.WriteToken(token);

        var roleClaim = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
        var role = roleClaim?.Value;
        var username = user.UserName;

        return new TokenDto(tokenString, expiry, role , username);
    }


    [HttpGet]
    [Authorize(Policy = "Patient")]
    [Route("GetPatientDetails")]
    public ActionResult<PatientDTO> GetPatientData()
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        var user = _userManager.GetUserAsync(HttpContext.User).Result;
        PatientDTO? patientDTO = _patientService.GetPatientDetails(patientId);

        if (patientDTO != null && user != null)
        {
            patientDTO.Email = user.Email;
            patientDTO.PhoneNumber = user.PhoneNumber;

            return patientDTO;
        }


        return Unauthorized(new { message = "Patient Not Found" });
    }



    [HttpPut]
    [Authorize(Policy = "Patient")]
    [Route("EditPatienProfile")]
    public async Task<ActionResult> EditPatienProfile(EditProfileDTO editProfileDTO)
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);


        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        var user = await _userManager.FindByIdAsync(patientId);

        if (user == null)
        {
            return NotFound();
        }
        //user.UserName = editProfileDTO.Name;
        user.Email = editProfileDTO.Email;
        user.PhoneNumber = editProfileDTO.PhoneNumber;

        var result = await _userManager.UpdateAsync(user);


        PatientDTO? editProfileDto = _patientService.EditProrfile(patientId, editProfileDTO);
        if (editProfileDto != null && result.Succeeded)
            return Ok(new { message = "Patient Edited Successfully" });

        return Unauthorized(new { message = "Patient Not Found" });
    }


    [HttpPost]
    [Route("changePassword")]
    [Authorize(Policy = "Patient")]

    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto request)
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);


        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        // Return response to client
        int? result = await _patientService.ChangePassword(patientId, request); 

        if (result==1)
        {
            return Ok();
        }
        else
        {
            return BadRequest("Can't Change Password");
        }
    }

    [HttpGet]
    [Authorize(Policy = "Patient")]
    [Route("GetPatientDrugs")]
    public ActionResult<HashSet<PatientDrugsDTO>> GetPatientDrugs()
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        HashSet<PatientDrugsDTO>? patientDrugs = _patientService.GetPatientDrugs(patientId);
        if (patientDrugs != null)
            return patientDrugs;

        return BadRequest(new { message = "Patient doesn't have Drugs yet.. " });
    }


    [HttpGet]
    [Authorize(Policy = "Patient")]
    [Route("GetDataOFVisitedDoctors")]

    public ActionResult<HashSet<DoctorDataDTO>> GetVisitedDoctorsData()
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        HashSet<DoctorDataDTO>? doctorDataDTO = _patientService.GetVisitedDoctorsInfo(patientId);
        if (doctorDataDTO is null)
            return BadRequest(new { message = "Patien id not valid" });

        if (doctorDataDTO.Count == 0)
            return BadRequest(new { message = "Patient doesn't have any appointment with Doctors .. " });

        return doctorDataDTO;
    }


    [HttpGet]
    [Authorize(Policy = "Patient")]
    [Route("GetAppointmentDetails/{docId}")]

    public ActionResult<AppointmentDetailsDTO> GetAppointmentDetailsOfSpecificDoc(string docId)
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        AppointmentDetailsDTO? appointmentDetailsDTO = _patientService.GetAppointmentDetailsOfSpecificDoc(patientId, docId);
        if (appointmentDetailsDTO != null)
            return appointmentDetailsDTO;

        return BadRequest(new { message = "Patient id or Doctor id are not valid ❌" });
    }


    [HttpPatch]
    [Authorize(Policy = "Patient")]
    [Route("RateDoctor/{docId}")]
    public ActionResult RateDoctor(string docId,decimal rating)
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        int? rateDoctor = _patientService.RateDoctor(patientId, docId, rating);
        if (rateDoctor != null)
            return Ok(new { message = "Rating Doctor Successfully ✅" });

        return BadRequest(new { message = "Patient id or Doctor id are not valid" });
    }


    [HttpGet]
    [Authorize(Policy = "Patient")]
    [Route("GetPatientillnesses")]
    public ActionResult<HashSet<PatientIllnessDTO>> GetPatientIllnesses()
    {
        string? patientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (patientId == null)
            return Unauthorized(new { message = "Please login" });

        HashSet<PatientIllnessDTO>? AllAppointments = _patientService.GetAllAppointments(patientId);
        if (AllAppointments != null)
            return AllAppointments;

        return BadRequest(new { message = "Patient doesn't have illnesses " });
    }
}

#region Old Register
//[HttpPost]
//[Route("Register")]
//public async Task<ActionResult> Register(PatientRegisterDto patientRegisterDto)
//{
//    var patientIdentityToAdd = new IdentityUser() { UserName = patientRegisterDto.NationalID, Email = patientRegisterDto.Email, PhoneNumber = patientRegisterDto.Mobile };

//    var result = await _userManager.CreateAsync(patientIdentityToAdd, patientRegisterDto.Password);
//    if (!result.Succeeded)
//    {
//        return BadRequest(result.Errors);
//    }

//    var roleExists = await _roleManager.RoleExistsAsync(UserRoles.Patient);
//    if (!roleExists)
//    {
//        var newRole = new IdentityRole(UserRoles.Patient);
//        await _roleManager.CreateAsync(newRole);
//    }

//    await _userManager.AddToRoleAsync(patientIdentityToAdd, UserRoles.Patient);

//    var patientToAdd = new Patient
//    {
//        User = patientIdentityToAdd,
//        NationalId = patientRegisterDto.NationalID,
//        Name = patientRegisterDto.Name,
//        Age = patientRegisterDto.Age,
//        Gender = patientRegisterDto.Gender
//    };
//    var claims = new List<Claim>
//{
//    new Claim(ClaimTypes.NameIdentifier, patientToAdd.NationalId),
//    new Claim(ClaimTypes.Role, UserRoles.Patient)
//};

//    await _userManager.AddClaimsAsync(patientIdentityToAdd, claims);
//    _Context.patients.Add(patientToAdd);
//    await _Context.SaveChangesAsync();
//    return NoContent();
//} 
#endregion