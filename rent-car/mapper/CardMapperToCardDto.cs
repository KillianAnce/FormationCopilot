using AutoMapper;
using RentCar.Models;
using RentCar.Dtos;

namespace RentCar.Mapper
{
    public class CardMapperToCardDto : Profile
    {
        public CardMapperToCardDto()
        {
            CreateMap<Card, CardDto>();
        }
    }
}