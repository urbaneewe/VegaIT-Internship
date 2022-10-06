using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private Country(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public static Result<Country> Create(Guid id, string name)
        {
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(name), "Country name can not be empty.");
            Result result = Result.Combine(nameResult);

            return result.IsSuccess ? Result.Success<Country>(new Country(id, name)) : Result.Failure<Country>(result.Error);
        }
    }
}
