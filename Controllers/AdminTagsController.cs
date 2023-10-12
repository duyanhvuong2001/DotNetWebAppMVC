using DotNetWebAppMVC.Data;
using DotNetWebAppMVC.Models.Domain;
using DotNetWebAppMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAppMVC.Controllers
{
    public class AdminTagsController : Controller
    {
        private BlogWebDbContext _dbContext;
        //Constructor injection
        public AdminTagsController(BlogWebDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SaveTag(AddTagRequest addTagRequest)
        {
            //Mapping addTagRequest obj to Tag Domain Model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            _dbContext.Tags.Add(tag);
            
            //Commit to the database
            _dbContext.SaveChanges();
            return View("Add");
        }
    }
}
