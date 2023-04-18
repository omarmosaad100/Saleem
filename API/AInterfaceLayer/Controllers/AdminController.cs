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

        //get all drugs
        [HttpGet]
        [Route("GetAllDrugs")]
        public ActionResult GetAllDrugs()
        {
            var drugs = _AdminManager.GetDrugList();

            if (drugs == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(drugs);
        }

        //get drug by Id  
        [HttpGet]
        [Route("GetDrug")]
        public ActionResult GetDrug(Guid Id)
        {
            var drug = _AdminManager.GetDrug(Id);

            if (drug == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(drug);
        }
        //update drug
        //[HttpPut]
        //[Route("AddDrug")]
        //public ActionResult UpdateDrug([FromBody] NewDrugDto drug)
        //{
        //    var result = _AdminManager.AddNewDrug(drug);

        //    if (result == 0)
        //        return BadRequest();
        //    return Ok();
        //}

        //delete drug
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
        public ActionResult AddIssue([FromBody] IssueDto issueDto)
        {

            var result = _AdminManager.AddIssue(issueDto);

            if (result == 0)
                return BadRequest();

            return Ok();
        }

        #endregion

        #region Licence
        //addnewLicence

        [HttpPost]
        [Route("AddLicense")]
        public ActionResult AddLicense([FromBody] LicenseDto licenseDto)
        {
            var result = _AdminManager.AddLicense(licenseDto);

            if (result == null)
                return BadRequest();

            return Ok();

        }

        #endregion

        #region Doctors/Licence
        //getAllDoctors
        #endregion

    }
}
