﻿using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Serviece.IServiece;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDTO?> CreateCouponAsync(CouponDTO couponDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.POST,
                Data = couponDTO,
                URL = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDTO?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.DELETE,
                URL = SD.CouponAPIBase + "/api/coupon/" + id
            }); ;
        }

        public async Task<ResponseDTO?> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.GET,
                URL = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDTO?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.GET,
                URL = SD.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            }); ;
        }

        public async Task<ResponseDTO?> GetCouponByIDAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.GET,
                URL = SD.CouponAPIBase + "/api/coupon/" + id
            }); ;
        }

        public async Task<ResponseDTO?> UpdateouponAsync(CouponDTO couponDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                APIType = SD.APIType.PUT,
                Data = couponDTO,
                URL = SD.CouponAPIBase + "/api/coupon"
            });
        }
    }
}
