using kybe.presentation.ViewModels.Entity.User.Register;
using kybe_application.DTOs.SharedDTOs;
using kybe_application.DTOs.UserDTOs;
using kybe_application.Interface.IService.IUserServoce;
using Microsoft.AspNetCore.Mvc;

namespace kybe.presentation.Controllers.Auth
{
    public sealed class AuthController : Controller
    {
        private readonly IUserServiceApp _userService;

        public AuthController(IUserServiceApp userService)
        {
            _userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            try
            {
                var dto = MapRegister(viewModel);

                await _userService.RegisterAsync(dto);

                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }
        }

        private static RegisterUser MapRegister(UserViewModel viewModel) 
        {
            return new RegisterUser
            {
                UserName = viewModel.UserName,
                Password = viewModel.Password,
                Name = viewModel.Name,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email,
                Cpf = viewModel.Cpf,
                AddressDTO = viewModel.AddressVM is null
                ? null
                : new AddressDTO
                {
                    Street = viewModel.AddressVM.Street,
                    Number = viewModel.AddressVM.Number,
                    Complementary = viewModel.AddressVM.Complementary,
                    Neighborhood = viewModel.AddressVM.Neighborhood,
                    City = viewModel.AddressVM.City,
                    State = viewModel.AddressVM.State,
                    ZipCode = viewModel.AddressVM.ZipCode
                }
            };
        }
    }
}
