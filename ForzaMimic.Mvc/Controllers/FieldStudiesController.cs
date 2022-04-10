#nullable disable
using Microsoft.AspNetCore.Mvc;
using ForzaMimic.TransferObjects;

namespace ForzaMimic.Staging.Controllers
{
    public class FieldStudiesController : Controller
    {
        private IForzaMimicDataAccess _dataAccess;


        public FieldStudiesController(IForzaMimicDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            return View(_dataAccess.RetrieveAllFieldStudies());
        }







        // GET: FieldStudies/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FieldStudy fieldStudy = _dataAccess.RetrieveFieldStudiesById(id.Value);

            if (fieldStudy == null)
            {
                return NotFound();
            }

            return View(fieldStudy);
        }
    }
}
