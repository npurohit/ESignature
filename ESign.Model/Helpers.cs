using System.Drawing;

namespace ESign.Model
{
    public static class Helpers
    {
        public static Bitmap GetStatusImage(SignatureStatus status)
        {
            var imageName = "RedX";

            if (status == SignatureStatus.Complete)
            {
                imageName = "GreenCheck";
            }
            return new Bitmap(System.Web.HttpContext.Current.Server.MapPath(string.Format("~/Content/Img/{0}.gif", imageName)));
        }
    }
}
