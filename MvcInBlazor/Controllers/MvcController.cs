using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcInBlazor.Data;
using MvcInBlazor.ViewModel;

namespace MvcInBlazor.Controllers
{
    public class MvcController : Controller
    {
        public IActionResult MvcView()
        {
            var vModel = new MvcViewModel();
            vModel.ViewModelValue = "ViewModelValue";
            return View(vModel);
        }
    }
}
