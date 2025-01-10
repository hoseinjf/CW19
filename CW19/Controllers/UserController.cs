using AppDomainCore.CW19.Users.Contract.AppService;
using Microsoft.AspNetCore.Mvc;

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
    }
}
