using BBussinesLogicLayer.Dtos;
using BBussinesLogicLayer.Managers.Admin;
using CDataAccessLayer.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace AInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager _AdminManager;

        public AdminController(IAdminManager adminManager)
        {
            _AdminManager = adminManager;
        }

        #region Drug
        [HttpPost]
        [Route("AddDrug")]
        public ActionResult AddNewDrug([FromBody] NewDrugDto drug)
        {
            var result = _AdminManager.AddNewDrug(drug);

            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpGet]
        [Route("GetAllDrugs")]
        public ActionResult GetAllDrugs()
        {
            var drugs = _AdminManager.GetDrugList();

            if (drugs == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(drugs);
        }

        [HttpGet]
        [Route("GetDrug")]
        public ActionResult GetDrugById(Guid Id)
        {
            var drug = _AdminManager.GetDrug(Id);

            if (drug == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(drug);
        }
        
        [HttpPut]
        [Route("UpdateDrug")]
        public ActionResult UpdateDrug([FromBody] NewDrugDto drug , Guid id)
        {
            var result = _AdminManager.UpdateDrug(drug , id);

            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteDrug")]
        public ActionResult DeleteDrug(Guid Id)
        {
            var result = _AdminManager.DeleteDrug(Id);

            if (result < 1)
                return StatusCode(StatusCodes.Status400BadRequest);

            return Ok();
        }
        #endregion

        #region Issue
        [HttpPost]
        [Route("AddIssue")]
        public ActionResult AddIssue(string IssueName)
        {

            var result = _AdminManager.AddIssue(IssueName);

            if (result == 0)
                return BadRequest();

            return Ok();
        }

        #endregion

        #region Licence
        [HttpPost]
        [Route("AddLicense")]
        public ActionResult AddLicense([FromBody] LicenseDto licenseDto)
        {
            var result = _AdminManager.AddLicense(licenseDto);

            if (result == 0)
                return BadRequest(new {message = "Couldn't Add this Licencse make sure the data is in the right format!"});

            return Ok();

        }
        #endregion

        #region Doctors
        [HttpGet]
        [Route("GetAllDoctors")]
        public ActionResult GetAllDoctors()
        {
            var doctors = _AdminManager.GetAllDoctors();

            if (doctors == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(doctors);
        }

        [HttpDelete]
        [Route("RemoveDoctorLicense")]
        public ActionResult RemoveDoctorLicense(string Id)
        {
            var result = _AdminManager.DeleteDoctor(Id);

            if (result < 1)
                return StatusCode(StatusCodes.Status400BadRequest);

            return Ok(new { Message = "Doctor License Has been Removed."});
        }

        #endregion

    }
}
