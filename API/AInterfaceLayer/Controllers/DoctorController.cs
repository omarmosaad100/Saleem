using BBussinesLogicLayer.Dtos.Doctor;
using BBussinesLogicLayer.Managers.Doctor;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace AInterfaceLayer.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]

    public class DoctorController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDoctorManager _doctorManager;
        private readonly UserManager<IdentityUser> _userManager;


        public DoctorController(IDoctorManager doctorManager, UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _doctorManager = doctorManager;
            _userManager = userManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(DoctorRegisterDto doctorRegisterDto)
        {
            IdentityResult result =await _doctorManager.CreateAccountAsync(doctorRegisterDto);
            if (!result.Succeeded)
                return BadRequest(result.Errors);
            return NoContent();

        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<DoctorTokenDto>> Login(DoctorLoginDto doctorLoginDto)
        {
            var user = await _userManager.FindByNameAsync(doctorLoginDto.UserNationalId);
            if (user == null)
            {
                return NotFound();
            }

            var isAuthenitcated = await _userManager.CheckPasswordAsync(user, doctorLoginDto.Password);
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
            
            return new DoctorTokenDto(tokenString, expiry, role, username, user.Id);
        }

        [HttpPost]
        [Route("AddAppointment")]

        public ActionResult AddAppointment(AppointmentDto appointmentDto)
        
        {
            var result = _doctorManager.AddAppointment(appointmentDto);
            if (result == 0)
                return BadRequest();

            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok();
        }

        [HttpGet]
        [Route("GetAppointmentsByNid")]
        public ActionResult GetAppointmentsByNid(string nid)
        {
            var result = _doctorManager.GetAppointmentsByNid(nid);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }


        [HttpGet]
        [Route("GetDoctorProfileById")]
        public ActionResult GetDoctorProfileById(string did)
        {
            var result = _doctorManager.GetDoctorProfileById(did);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteIssueByPidAndIssueName")]
        public ActionResult DeleteIssueByPidAndIssueName(string pid, string name)
        {
            var result = _doctorManager.DeleteIssueByPidAndIssueName(pid, name);

            if (result == false)
                return BadRequest("result is false");
            return Ok(result);
        }


        [HttpGet]
        [Route("GetDrugRecommendation")]
        public ActionResult GetDrugRecommendation(string issueName, string pid)
        {
            var result = _doctorManager.GetDrugRecommendation(issueName, pid);

            if (result != null)
                return Ok(result);
                
            return BadRequest();
        }


        [HttpGet]
        [Route("GetAllIssues")]
        public ActionResult GetAllIssues()
        {
            var result = _doctorManager.GetAllIssues();

            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet]
        [Route("GetIssuesByPid")]
        public ActionResult GetIssuesByPid(string pid)
        {
            var result = _doctorManager.GetIssuesByPid(pid);

            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet]
        [Route("GetPidByNid")]
        public ActionResult GetPidByNid(string nid)
        {
            var result = _doctorManager.GetPidByNid(nid);

            if (result != null)
                return Ok(result);

            return BadRequest();
        }

    }
}