using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KShoppingKartMock.Data.Interfaces;
using KShoppingKartMock.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KShoppingKartMock.Controllers
{
    public class MobileController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMobileRepository _mobileRepository;
        public MobileController(ICategoryRepository categoryRepository, IMobileRepository mobileRepository)
        {
            _categoryRepository = categoryRepository;
            _mobileRepository = mobileRepository;
        }

        public ViewResult List(string category)
        {
            //viewbag is not stronglyTyped, hence we will use view models
            ViewBag.Name = "List of Mobiles";
            var mobies = _mobileRepository.Mobiles;

            MobileListViewModel vm = new MobileListViewModel();
            vm.Mobiles = _mobileRepository.Mobiles;
            vm.CurrentCategory = "Andriod";
            return View(vm); //return View(mobies);
        }
    }
}