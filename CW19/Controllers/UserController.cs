using AppDomainCore.CW19.Users.Contract.AppService;
using CW19.Models.Entity;
using CW19.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CW19_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public IActionResult Index()
        {

            var userList = _userAppService.GetAllUser();

            return View(userList);
        }

        public IActionResult Add(User user,int i =0)
        {
            user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            var userList = _userAppService.Add(user);
            return RedirectToAction("Index");
        }


        public IActionResult Update(int Id)
        {
            var user = _userAppService.GetUserById(Id);
            ViewBag.member = new SelectList(_userAppService.GetUserById(Id).MembershipType.ToString());
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            var us = user;

            _userAppService.Update(us);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _userAppService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Search(string name)
        {
            var list = _userAppService.Search(name);

            return View("Index",list);
        }

    }
}
