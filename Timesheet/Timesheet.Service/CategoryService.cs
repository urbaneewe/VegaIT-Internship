using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _repository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(Category category)
        {
            if(category == null || _repository.GetById(category.Id).HasNoValue)
            {
                return Result.Failure("Category that you want to delete does not exist.");
            }
            _repository.Delete(category);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully deleted the category.");
        }

        public IEnumerable<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Category> GetByFirstLetterAndSearchText(char letter, string text)
        {
            return _repository.GetByFirstLetterAndSearchText(letter, text);
        }

        public Maybe<Category> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(Category category)
        {
            if(_repository.GetById(category.Id).HasValue)
            {
                return Result.Failure("Category with name" + category.Name + "already exists.");
            }
            _repository.Insert(category);
            _unitOfWork.SaveChanges();
            return Result.Success("Category successfully added.");
        }

        public Result Update(Category category)
        {
            if(category == null)
            {
                return Result.Failure("Category that you are trying to update does not exist.");
            }
            _repository.Update(category);
            _unitOfWork.SaveChanges();
            return Result.Success("Category successfully updated.");
        }
    }
}
