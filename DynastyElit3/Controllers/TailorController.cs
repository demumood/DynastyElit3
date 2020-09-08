
namespace DynastyElit3.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels;

    public class TailorController : Controller
    {
        public IActionResult Index()
        {
            List<TailorViewModel> data = new List<TailorViewModel>();

            for (int i = 0; i < 6; i++)
            {
                TailorViewModel addData = new TailorViewModel()
                {
                    ID = i,
                    Name = "Test User " + i,
                    isActive = true
                };
                data.Add(addData);
            }

            return View(data);
        }

        public IActionResult AddEdit()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEdit([Bind(include: "Id,Name,isActive")]TailorViewModel data)
        {

            return View();
        }
    }
}
