using AutoMapper;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShop.MVC.Helpers
{
    public class GeneralMappinProfile : Profile
    {
        public GeneralMappinProfile()
        {
            CreateMap<ProductViewModel, EditProductViewModel>().ReverseMap();
            CreateMap<ProductViewModel, DeleteProductViewModel>().ReverseMap();
        }

    }
}
