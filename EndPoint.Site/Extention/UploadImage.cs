using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Extention
{
    public static class UploadImage
    {
        public static string SaveImage(this IFormFile file,string env, string pooshe)
        {
            string path =env+"\\Images"+pooshe+ Guid.NewGuid() + Path.GetExtension(file.FileName);
           

            var f = System.IO.File.Create(path);
            file.CopyTo(f);

            f.Close();

            path = path.Split("wwwroot")[1];

            return path;
        }
    }
}
