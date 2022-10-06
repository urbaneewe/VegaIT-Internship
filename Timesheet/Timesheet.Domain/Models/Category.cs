using CSharpFunctionalExtensions;

namespace Timesheet.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Timesheet> Timesheets { get; set; }

        private Category(Guid categoryId, string name)
        {
            Id = categoryId;
            Name = name;
            Timesheets = new List<Timesheet>();
        }

        public static Result<Category> Create(Guid id, string name)
        {
            Result nameResult = Result.SuccessIf(!string.IsNullOrEmpty(name), "Category can not be empty.");

            Result result = Result.Combine(nameResult);

            return result.IsSuccess ? Result.Success<Category>(new Category(id, name)) : Result.Failure<Category>(result.Error);
        }
    }
}
