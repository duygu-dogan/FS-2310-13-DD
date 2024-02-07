using AutoMapper;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Helpers
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
