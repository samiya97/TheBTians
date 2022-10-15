using CareProWeb.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CareProWeb.Controllers
{
    public class PatientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetAllPatients()
        {
            var patient = await _unitOfWork.Patients.GetAll();
            return Json(patient);
        }
        public async Task<JsonResult> GetPatient(int id)
        {
            var patient = await _unitOfWork.Patients.GetById(id);
            return Json(patient);
        }
        [HttpPost]
        public async Task<JsonResult> AddPatient(int id)
        {
            var patient = await _unitOfWork.Patients.GetById(id);
            return Json(patient);
        }
    }
}
