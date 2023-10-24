using Mango.Web.Models;

namespace Mango.Web.Serviece.IServiece
{
    public interface IBaseService
    {
         Task<ResponseDTO?> SendAsync(RequestDTO requestDTO);
    }
}
