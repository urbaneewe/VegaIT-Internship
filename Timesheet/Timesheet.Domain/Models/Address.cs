using CSharpFunctionalExtensions;


namespace Timesheet.Domain.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }

        private Address(string addressName, string city, int postalCode, Country country, Guid id)
        {
            Name = addressName;
            City = city;
            PostalCode = postalCode;
            Country = country;
            Id = id;
        }

        public static Result<Address> Create(string addressName, string city, int postalCode, Country country, Guid id)
        {
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(addressName), "Address can not be empty.");
            Result cityResult = Result.SuccessIf(!string.IsNullOrEmpty(city), "City can not be empty.");
            Result postalCodeResult = Result.SuccessIf(postalCode != 0, "Postal code can not be empty");
            Result countryResult = Result.SuccessIf(country != null, "Country can not be empty.");

            Result result = Result.Combine(nameResult, cityResult, postalCodeResult, countryResult);

            return result.IsSuccess ? Result.Success<Address>(new Address(addressName, city, postalCode, country, id)) : Result.Failure<Address>(result.Error);

        }
    }
}
