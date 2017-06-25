using RPCDI.Data.db;
using RPCDI.Data.uow.contract;
using RPCDI.Data.uow.implementation;
using RPCDI.Infrastructure.User;
using RPCDI.UI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RPCDI.UI.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork uow = new UnitOfWork(new CustomIdentityDbContext(ConfigurationManager.ConnectionStrings["IdentityDb"].Name));
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Registration(RegistrationModel model)
        {
            try
            {
                var createNewUser = await uow.UserManagerRepository.CreateAsync(new CustIdentityUser() { UserName = model.UserName }, model.Password);
                if (createNewUser.Succeeded)
                    return RedirectToAction("Index", "Home");
                ModelState.AddModelError("", createNewUser.Errors.FirstOrDefault());
                return View(model);
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var eve in e.EntityValidationErrors)
                {
                 sb.Append(  string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                       sb.Append( string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                ModelState.AddModelError("", sb.ToString());
                return View(model);
            }
        }
    }
}