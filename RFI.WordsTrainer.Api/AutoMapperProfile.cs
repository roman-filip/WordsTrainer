using AutoMapper;

namespace RFI.WordsTrainer.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Data.Models.WordCategory, Models.WordCategory>();
        }
    }
}
