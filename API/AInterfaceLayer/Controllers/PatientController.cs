﻿using BBussinesLogicLayer.Dtos.Patients;
using CDataAccessLayer.Data;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly DataContext _Context;

        public PatientController(IConfiguration configuration,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, DataContext Context)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _Context = Context;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(PatientRegisterDto patientRegisterDto)
        {
            var patientIdentityToAdd = new IdentityUser() {UserName= patientRegisterDto.NationalID, Email = patientRegisterDto.Email, PhoneNumber = patientRegisterDto.Mobile };

            var result = await _userManager.CreateAsync(patientIdentityToAdd, patientRegisterDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            var roleExists = await _roleManager.RoleExistsAsync(UserRoles.Patient);
            if (!roleExists)
            {
                var newRole = new IdentityRole(UserRoles.Patient);
                await _roleManager.CreateAsync(newRole);
            }

            await _userManager.AddToRoleAsync(patientIdentityToAdd, UserRoles.Patient);

            var patientToAdd = new Patient
            {
                User = patientIdentityToAdd,
                NationalId = patientRegisterDto.NationalID,
                Name = patientRegisterDto.Name,
                Age = patientRegisterDto.Age,
                Gender = patientRegisterDto.Gender
            };
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, patientToAdd.NationalId),
            new Claim(ClaimTypes.Role, UserRoles.Patient)
        };

            await _userManager.AddClaimsAsync(patientIdentityToAdd, claims);
            _Context.patients.Add(patientToAdd);
            await _Context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDto>> Login_Clean(PatientLoginDto patientLoginDto)
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

            return new TokenDto(tokenString, expiry);
        }



    }
}
