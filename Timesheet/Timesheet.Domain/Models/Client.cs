using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Project> Projects { get; set; }

        private Client(string name, Guid clientId, Address clientAddress)
        {
            Name = name;
            Id = clientId;
            Address = clientAddress;
        }

        public static Result<Client> Create(string clientName, Guid clientId, Address clientAddress)
        {
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(clientName), "Name can not be empty.");
            Result addressResult = Result.SuccessIf(clientAddress != null, "Address can not be empty.");

            Result result = Result.Combine(nameResult, addressResult);

            return result.IsSuccess ? Result.Success<Client>(new Client(clientName, clientId, clientAddress)) : Result.Failure<Client>(result.Error);
        }

    }
}
