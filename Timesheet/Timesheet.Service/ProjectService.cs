using CSharpFunctionalExtensions;
using Timesheet.Domain.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;

namespace Timesheet.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IProjectRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Result Delete(Project project)
        {
            if (project == null || _repository.GetById(project.Id).HasNoValue)
            {
                return Result.Failure("The project that you are trying to delete does not exist.");
            }

            _repository.Delete(project);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully deleted the project.");
        }

        public IEnumerable<Project> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Project> GetByFirstLetterAndSearchText(char letter, string text)
        {
            return _repository.GetByFirstLetterAndSearchText(letter, text);
        }

        public Maybe<Project> GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Result Insert(Project project)
        {
            if(_repository.GetById(project.Id).HasValue)
            {
                return Result.Failure("The project " + project.Name + "already exists.");
            }

            _repository.Insert(project);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully inserted a project.");
        }

        public Result Update(Project project)
        {
            if(project == null)
            {
                return Result.Failure("The project that you are trying to update does not exist.");
            }
            _repository.Update(project);
            _unitOfWork.SaveChanges();
            return Result.Success("You have successfully updated the project");
        }
    }
}
