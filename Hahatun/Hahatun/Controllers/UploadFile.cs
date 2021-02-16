using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Hahatun.Controllers   
{
    public class UploadFile : Controller
    {
        IWebHostEnvironment _appEnvironment;
        public UploadFile(IWebHostEnvironment appEnvironment)
        {
            
            _appEnvironment = appEnvironment;
        }

      

        [HttpPost]
        public IActionResult LoadFile(IFormFile picture)
        {
            if (picture != null)
            {
                string path = "/Files/" + picture.FileName;
                using (var filestream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    picture.CopyToAsync(filestream);
                }
            }

                return View();
        }

        
       
    }
}
