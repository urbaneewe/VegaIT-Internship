using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        private readonly IAddressRepository _addressRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClientService(IClientRepository clientRepository, IAddressRepository addressRepository, ICountryRepository countryRepository, IUnitOfWork unitOfWork)
        {
            _repository = clientRepository;
            _addressRepository = addressRepository;
            _countryRepository = countryRepository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(Client client)
        {
            if(client == null || _repository.GetById(client.Id).HasNoValue)
            {
                return Result.Failure("The client that you are trying to delete does not exist.");
            }
            _repository.Delete(client);
            _unitOfWork.SaveChanges();
            return Result.Success("Client successfully deleted.");
        }

        public IEnumerable<Client> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Client> GetByFirstLetterAndSearchText(char letter, string text)
        {
            return _repository.GetByFirstLetterAndSearchText(letter, text);
        }

        public Maybe<Client> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(Client client)
        {
            if (_repository.GetById(client.Id).HasValue)
            {
                return Result.Failure("Client with name already exists.");
            }

            _countryRepository.Insert(client.Address.Country);
            _addressRepository.Insert(client.Address);

            _repository.Insert(client);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a client");
        }

        public Result Update(Client client)
        {
            if (client == null)
            {
                return Result.Failure("The client that you are trying to update does not exist.");
            }
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully updated the client");
        }
    }
}
