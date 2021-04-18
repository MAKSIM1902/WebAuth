using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebTask5.Models;
using WebTask5.ViewModels;

namespace WebTask5.Controllers
{
    public class UsersController : Controller
    {
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;

        public UsersController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index() => View(_userManager.Users.ToList());

        [Authorize]
        public async Task<ActionResult> Block(string[] id) 
        {

            foreach (var i in id)
            {
                var user = await _userManager.FindByIdAsync(i);
                user.IsLockUser = true;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.SetLockoutEndDateAsync(user, new DateTime(9999, 12, 30));
                   var  iuser = await _userManager.FindByNameAsync(User.Identity.Name);
                    if (iuser == user)
                    {
                        await _signInManager.SignOutAsync();
                        return RedirectToAction("Register", "Account");
                    }
                }
                await _signInManager.RefreshSignInAsync(user);
            }
            return RedirectToAction("Register", "Account");
        }
        [Authorize]
        public async Task<ActionResult> Unblock(string[] id)
        {
            foreach (var i in id)
            {
                var user = await _userManager.FindByIdAsync(i);
                user.IsLockUser = false;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.SetLockoutEndDateAsync(user, DateTime.Now - TimeSpan.FromMinutes(1));
                }
                await _signInManager.RefreshSignInAsync(user);
            }
            return RedirectToAction("Register", "Account");
        }
        [Authorize]
        public async Task<ActionResult> Delete(string[] id)
        {
            foreach (var i in id)
            {
                var user = await _userManager.FindByIdAsync(i);
                var iuser = await _userManager.FindByNameAsync(User.Identity.Name);

                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    if (iuser == user)
                    {
                        await _signInManager.SignOutAsync();
                        return RedirectToAction("Register", "Account");
                    }
                }
            }
            return RedirectToAction("Register", "Account");
        }
    }
}
