using System;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace HotelWebApplication.Helpers
{
    public class ImageSaveHelper
    {
        public static string SaveImage(HttpPostedFileBase imageData)
        {
            var ext = Path.GetExtension(imageData.FileName);
            var guid = Guid.NewGuid();
            var result = guid.ToString() + ext;

            if (imageData == null)
                return null;

            var filePathOriginal = HostingEnvironment.MapPath("/Content/Images/Uploads/");
            string savedFileName = Path.Combine(filePathOriginal ?? throw new InvalidOperationException(), result);

            imageData.SaveAs(savedFileName);

            return $"/Content/Images/Uploads/{result}";
        }
    }
}