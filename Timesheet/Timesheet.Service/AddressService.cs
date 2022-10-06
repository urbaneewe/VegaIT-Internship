using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public AddressService(IAddressRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(Address address)
        {
            if (address == null || _repository.GetById(address.Id).HasNoValue)
            {
                return Result.Failure("The address you are trying to delete does not exist!");
            }
            _repository.Delete(address);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully deleted an address");
        }

        public IEnumerable<Address> GetAll()
        {
            return _repository.GetAll();
        }

        public Maybe<Address> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public  Result Insert(Address address)
        {
            if (_repository.GetById(address.Id).HasValue)
            {
                return Result.Failure("Failed to insert a address!");
            }
            _repository.Insert(address);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a address");
        }

        public Result Update(Address address)
        {
            if (address == null)
            {
                return Result.Failure("Failed to insert a address!");
            }
            _repository.Update(address);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a address");
        }
    }
}
