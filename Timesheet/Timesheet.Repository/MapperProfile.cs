using AutoMapper;
using Address = Timesheet.Repository.Models.Address;
using Category = Timesheet.Repository.Models.Category;
using Client = Timesheet.Repository.Models.Client;
using Country = Timesheet.Repository.Models.Country;
using Employee = Timesheet.Repository.Models.Employee;
using DomainAddress = Timesheet.Domain.Models.Address;
using DomainCategory = Timesheet.Domain.Models.Category;
using DomainClient = Timesheet.Domain.Models.Client;
using DomainCountry = Timesheet.Domain.Models.Country;
using DomainEmployee = Timesheet.Domain.Models.Employee;

namespace Timesheet.Repository
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, DomainEmployee>().ReverseMap();//TODO: Other mappers

            var countryMap = CreateMap<Country, DomainCountry>()
                .ConstructUsing(country => DomainCountry.Create(country.Id, country.Name).Value).ReverseMap();

            var categoryMap = CreateMap<Category, DomainCategory>()
                .ConstructUsing(category => DomainCategory.Create(category.Id, category.Name).Value).ReverseMap();

            var addressMap = CreateMap<Address, DomainAddress>()
                .ConstructUsing((address, context) => DomainAddress.Create(address.Name, address.City, address.PostalCode,
                context.Mapper.Map<DomainCountry>(address.Country), address.Id).Value).ReverseMap();

            var clientMap = CreateMap<Client, DomainClient>()
                .ConstructUsing((client, context) => DomainClient.Create(client.Name, client.Id,
                context.Mapper.Map<DomainAddress>(client.Address)).Value).ReverseMap();
        }
    }
}
