using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Timesheet.Domain.Repository;
using DomainProject = Timesheet.Domain.Models.Project;
using Project = Timesheet.Repository.Models.Project;

namespace Timesheet.Repository.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly TimesheetDbContext _dbContext;
        private DbSet<Project> entities;
        private readonly IMapper _mapper;

        public ProjectRepository(TimesheetDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            entities = _dbContext.Set<Project>();
            _mapper = mapper;
        }

        public void Delete(DomainProject entity)
        {
            Project project = entities.Find(entity.Id);
            entities.Remove(project);
        }

        public IEnumerable<DomainProject> GetAll()
        {
            return entities.Select(_mapper.Map<DomainProject>);
        }

        public IEnumerable<DomainProject> GetByFirstLetterAndSearchText(char letter, string text)
        { 
            return entities.Where(s => s.Name.StartsWith(letter) && s.Name.Contains(text)).Select(_mapper.Map<DomainProject>);
        }

        public Maybe<DomainProject> GetById(Guid id)
        {
            Project project = entities.Find(id);

            if (project == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainProject>(project));
        }

        public Maybe<DomainProject> GetByName(string name)
        {
            var employee = entities.SingleOrDefault(x => x.Name == name);
            if (employee == null)
            {
                return Maybe.None;
            }

            return Maybe.From(_mapper.Map<DomainProject>(employee));
        }

        public void Insert(DomainProject entity)
        {
            var project = new Project(entity.Id, entity.Description, entity.Name, entity.Status.ToString(), entity.Client.Id, entity.Lead.Id);
            entities.Add(project);
        }

        public void Update(DomainProject entity)
        {
            Project project = entities.Find(entity.Id);
            project.Name = entity.Name;
            project.Description = entity.Description;
            project.Client.Name = entity.Client.Name;
            project.LeadId= entity.Lead.Id;
            project.ProjectStatus = entity.Status.ToString();

            entities.Update(project);
        }
    }
}
