using CareProWeb.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CareProWeb.Core.Entities;
namespace CareProWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<JsonResult> GetAllPatients()
        {
            var patient = await _unitOfWork.Patients.GetAll();
            return new JsonResult(patient);
        }
        [HttpGet("{id}")]
        public async Task<JsonResult> GetPatient(int id)
        {
            var patient = await _unitOfWork.Patients.GetById(id);
            return new JsonResult(patient);
        }

        [HttpPost]
        public async Task<JsonResult> SavePatient(Patient patient)
        {
            return new JsonResult(await _unitOfWork.Patients.Add(patient));
        }

        [HttpPut]
        public async Task<JsonResult> UpdatePatient(Patient patient)
        {
            return new JsonResult(await _unitOfWork.Patients.Update(patient));
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> DeletePatient(int id)
        {
            return new JsonResult(await _unitOfWork.Patients.Remove(id));
        }
    }
}
