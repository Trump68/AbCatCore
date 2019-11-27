using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbCatCore.Components
{
    public class VideoWidget: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return View();
        }
    }
}
