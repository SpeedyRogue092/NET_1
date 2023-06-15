using Microsoft.AspNetCore.Mvc;
using NET_1.Data.Interfaces;
using NET_1.Data.ViewModels;

namespace NET_1.Controllers
{
    public class ToysController : Controller
    {
        private readonly IAllToys _allToys;
        private readonly IToysCategory _allCategories;
        public ToysController(IAllToys iAllToys, IToysCategory iToysCategory)
        {
            _allToys = iAllToys;
            _allCategories = iToysCategory;
        }

        public ViewResult List()
        {
            ToysListViewModels obj = new ToysListViewModels();
            obj.allToys = _allToys.Toys;
            obj.currCategory = "Іграшки";
            return View(obj);
            ViewBag.Title = "Сторінка з іграшками";
		}

    }
}
