using System;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace HotelWebApplication.Helpers
{
    public static class ImageSaveHelper
    {
        public static readonly string pathToRoomImages = "/Content/Rooms/";

        public static string SaveRoomImage(HttpPostedFileBase image)
        {
            if (image == null)
                return null;

            var extention = Path.GetExtension(image.FileName);
            var guid = Guid.NewGuid();
            var result = guid.ToString() + extention;

            var filePathOriginal = HostingEnvironment.MapPath(pathToRoomImages);
            string savedFileName = Path.Combine(filePathOriginal ?? throw new InvalidOperationException(), result);

            image.SaveAs(savedFileName);

            return pathToRoomImages + result;
        }
    }
}