using AutoMapper;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Web.ViewModels;

namespace ShoppingCart.Web.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>();
        }
    }
}