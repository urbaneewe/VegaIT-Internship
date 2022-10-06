using Microsoft.AspNetCore.Mvc;
using Timesheet.Api.Dto;
using Timesheet.Domain.Models;
using Timesheet.Domain.Services;

namespace Timesheet.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            var result = _categoryService.GetById(id);

            if(result == null)
            {
                return BadRequest("No category found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if(result == null)
            {
                return BadRequest("No categories found");
            }

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetByFirstLetterAndSearchText(char letter, string text)
        {
            var result = _categoryService.GetByFirstLetterAndSearchText(letter, text);

            if(result == null)
            {
                return BadRequest("No results found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(CategoryDto category)
        {
            Category domainCategory = Category.Create(category.Id, category.Name).Value;
            _categoryService.Insert(domainCategory);

            return Ok("Category inserted.");
        }

        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            Category domainCategory = Category.Create(category.Id, category.Name).Value;
            _categoryService.Update(domainCategory);

            return Ok("Category updated.");
        }

        [HttpDelete]
        public IActionResult Delete(CategoryDto category)
        {
            Category domainCategory = Category.Create(category.Id, category.Name).Value; 
            var result = _categoryService.Delete(domainCategory);

            if (domainCategory == null || result.IsFailure)
            {
                return BadRequest("Category does not exist");
            }

            return Ok("Category deleted.");
        }
    }
}
