using System.Net.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MtecDevs.ViewModels;

namespace MtecDevs.Controllers;

    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<IdentityUser> _sigInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(
            ILogger<AccountController> logger,
            SignInManager<IdentityUser> sigInManager,
            UserManager<IdentityUser> userManager)
            {
                _logger = logger;
                _sigInManager = sigInManager;
                _userManager = userManager;
            }
        
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }
       [HttpGet]
        public IActionResult Login(string returnUrl)
        {
           LoginVM loginVM = new(){
            UrlRetorno = returnUrl ?? Url.Content("~/")
           };
            return View(loginVM);
        }

       [HttpPost]
       [ValidateAntiForgeryToken]

       public async Task<IActionResult> login(LoginVM login)
       {
        if (ModelState.IsValid)
        {

        }
        return View(login);
       }  

       private  static bool IsValidEmail(string email)
       {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch
        {
            return false;
        }
       }
}