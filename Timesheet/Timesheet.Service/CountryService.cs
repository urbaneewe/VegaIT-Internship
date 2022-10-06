using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;
        private readonly IUnitOfWork _unitOfWork; 

        public CountryService(ICountryRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(Country country)
        {
            if(country == null || _repository.GetById(country.Id).HasNoValue)
            {
                return Result.Failure("The country you are trying to delete does not exist!");
            }

            _repository.Delete(country);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully deleted a country");
        }

        public IEnumerable<Country> GetAll()
        {
            return _repository.GetAll();
        }

        public Maybe<Country> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(Country country)
        {
            if (_repository.GetById(country.Id).HasValue)
            {
                return Result.Failure("Failed to insert a country!");
            }
            _repository.Insert(country);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a country");
        }

        public Result Update(Country country)
        {
            if(country == null)
            {
                return Result.Failure("The country that you are trying to update does not exist.");
            }
            _repository.Update(country);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully updated the country.");
        }
    }
}
