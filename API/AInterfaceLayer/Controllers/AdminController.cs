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

        //getall drugs
        [HttpGet]
        [Route("GetAllDrugs")]
        public ActionResult GetAllDrugs()
        {
           var drugs = _AdminManager.GetDrugList();
            
            if(drugs == null)
                return StatusCode(StatusCodes.Status404NotFound);

            return Ok(drugs);
        }

        //update drug

        //delete drug

        //get drug by Id  
        #endregion

        #region Doctors/Licence
        //addnewLicence
        //getAllDoctors
        #endregion

    }
}
