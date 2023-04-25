using BBussinesLogicLayer.Dtos.Doctor;
using BBussinesLogicLayer.Managers.Doctor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace AInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorManager _doctorManager;

        public DoctorController(IDoctorManager doctorManager)
        {
            _doctorManager = doctorManager;
        }

        [HttpPost]
        [Route("AddAppointment")]
        public ActionResult AddAppointment(AppointmentDto appointmentDto)
        {
            var result = _doctorManager.AddAppointment(appointmentDto);

            if (result == 0)
                return BadRequest();
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