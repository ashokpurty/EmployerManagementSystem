using EmployerManagementSystem.Models;
using EmployerManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployerManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        private IRepositoryService repositoryService;
        public EmployeeController(RepositoryService repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        public ActionResult Index()
        {
            var model = this.repositoryService.GetAllEmployee();

            return View(model);
        }

        [HttpGet]
        public JsonResult GetEmployees()
        {
            return Json(this.repositoryService.GetAllEmployee(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetEmployers()
        {
            RepositoryService repository = new RepositoryService();
            return Json(this.repositoryService.GetAllEmployer());
        }

        // POST api/values
        public void PostEmployee(EmployeeModel employeeModel)
        {
            this.repositoryService.AddEmployee(employeeModel);
        }

        public void PostEmployer(EmployerModel value)
        {
        }

        // PUT api/values/5
        public void PutEmployee(int id, string value)
        {
            this.repositoryService.UpdateEmployee(id, value);
        }

        public void PutEmployer(int id, string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
