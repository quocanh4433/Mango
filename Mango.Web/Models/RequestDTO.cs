

using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    public class RequestDTO
    {
        public APIType APIType { set; get; } = APIType.GET;
        public string URL { set; get; }
        public object Data { set; get; }
        public string AccessToken { set; get; }
    }
}
