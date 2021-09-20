using AutoMapper;
using Discount.Grpc.Protos;
using Discount.Grpc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile(string profileName) : base(profileName)
        {   
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
