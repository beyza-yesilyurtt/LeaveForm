using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class FormController : Controller
    {
        private readonly FormDbContext _db;
        public FormController(FormDbContext db)
        {
            _db = db; 
        }

        [HttpGet]
        public IActionResult CreateForm()
        {
            return View();
        }

        [HttpPost]
        [ActionName("CreateForm")]
        public IActionResult CreateForm(Form form)
        {
            var forms = new Form
            {
                
                Name = form.Name,
                Surname = form.Surname,
                Mail= form.Mail,
                PermissionStartDate= form.PermissionStartDate,
                PermissionEndDate= form.PermissionEndDate,
                PermissionReason= form.PermissionReason,
            };

            _db.Forms.Add(forms);
            _db.SaveChanges();
            return View("CreateForm");
        }            
        
    }
}
