using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Vezeta.APIs.Dtos;
using Vezeta.APIs.Errors;
using Vezeta.APIs.Helpers;
using Vezeta.Core.Entities.Identity;
using Vezeta.Core.Services;

namespace Vezeta.APIs.Controllers
{
    public class AccountController : ApiBaseController
    {
        private readonly UserManager<AppUser> _appUserManger;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<AppUser> appUserManger,SignInManager<AppUser> signInManager, ITokenService tokenService)
        {
            _appUserManger = appUserManger;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost("Login")] 
        public async Task<ActionResult<UserDto>> Login(LoginDto model)
        {
            var user = await _appUserManger.FindByEmailAsync(model.Email);
            if (user is null) return Unauthorized(new ApiResponse(401));
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!result.Succeeded) return Unauthorized(new ApiResponse(401));
            return Ok(new UserDto()
            {
                DisplayName = user.UserName,
                Email = user.Email,
                Token = await _tokenService.CreateTokenAsync(user, _appUserManger)
            });
        }

        [HttpPost("Register")] 
        public async Task<ActionResult<UserDto>> Register(RegisterDto model)
        {
            if (CheckEmailExists(model.Email).Result.Value)
                return BadRequest(new ApiValidationErrorResponse() { Errors = new string[] { "This email already exists." } });
            var user = new AppUser()
            {
                DisplayName = model.UserName,
                Email = model.Email,
                UserName = model.Email.Split('@')[0],
                PhoneNumber = model.PhoneNumber,

            };
            var result = await _appUserManger.CreateAsync(user, model.Password);
            if (!result.Succeeded) return BadRequest(new ApiResponse(400, "a problem with this user"));
            return Ok(new UserDto()
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = await _tokenService.CreateTokenAsync(user, _appUserManger)
            });
        }

        [HttpPost("ResetPassowrd")]
        public async Task<ActionResult<UserDto>> ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {                           
                var user = await _appUserManger.FindByEmailAsync(model.Email);
                var token = await _appUserManger.GeneratePasswordResetTokenAsync(user);
                var result = await _appUserManger.ResetPasswordAsync(user, token, model.NewPassword);
                var ResetPasswordLink = Url.Action("ResetPassword", "Account", new { email = user.Email, token = token }, Request.Scheme);
                var email = new Email()
                {
                    Subject = "Reset Password",
                    Body = ResetPasswordLink,
                    To = model.Email,
                };
                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return BadRequest("Invalid Email or User not found");
        }

        [HttpPost("SendEmail")]
        public async Task<ActionResult<UserDto>> SendEmail(ForgetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _appUserManger.FindByEmailAsync(model.Email);

                if (user is not null)
                {
                    var token = await _appUserManger.GeneratePasswordResetTokenAsync(user);
                    var ResetPasswordLink = Url.Action("ResetPassword", "Account", new { email = user.Email, token = token }, Request.Scheme);
                    var email = new Email()
                    {
                        Subject = "Reset Password",
                        Body = ResetPasswordLink,
                        To = model.Email,
                    };
                    EmailSetting.SendEmail(email);
                    return Ok(new UserDto()
                    {
                        DisplayName = user.DisplayName,
                        Email = user.Email,
                        Token = await _tokenService.CreateTokenAsync(user, _appUserManger)
                    });
                }
            }
            return BadRequest("Invalid Email or User not found");
        }

        [HttpGet("Emailexists")] 
        public async Task<ActionResult<bool>> CheckEmailExists(string email)
        {
            return await _appUserManger.FindByEmailAsync(email) is not null;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var user = await _appUserManger.FindByEmailAsync(email);
            return Ok(new UserDto()
            {
                DisplayName = user.UserName,
                Email = user.Email,
                Token = await _tokenService.CreateTokenAsync(user, _appUserManger)
            });
        }
    }
}
