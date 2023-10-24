using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDTO?> GetCouponAsync(string couponCode);
        Task<ResponseDTO?> GetAllCouponAsync();
        Task<ResponseDTO?> GetCouponByIDAsync(int id);
        Task<ResponseDTO?> CreateCouponAsync(CouponDTO couponDTO);
        Task<ResponseDTO?> UpdateouponAsync(CouponDTO couponDTO);
        Task<ResponseDTO?> DeleteCouponAsync(int id);
    }
}
