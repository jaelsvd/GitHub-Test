using App.BLL;
using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class UserController : Controller
    {
        private UserBusiness _userBll;

        public UserController()
        {
            _userBll = new UserBusiness();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(User model)
        {
            
            if(ModelState.IsValid)
            {
                try
                {
                    _userBll.AddUser(model);
                }
                catch (UserAlreadyExistException)
                {
                    ModelState.AddModelError("Name", "Name Already Exist");
                }
            }
            return View();
        }

        public ActionResult ListUser()
        {
            var users = _userBll.GetAll();
            return View(users);
        }
    }
}