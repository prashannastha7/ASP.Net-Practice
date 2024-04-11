using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NpWalks.API.Data;
using NpWalks.API.Models.Domain;

namespace NpWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NpWalkDbContext dbContext;

        public RegionsController(NpWalkDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
            
        
        //GET ALL REGIONS -> Get:https://localhost:portno/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            /*  without db to check in postman write this
             var regions = new List<Region>
             {
                 new Region
                 {
                     Id = Guid.NewGuid(),
                     Name = "Patan Region",
                     Code = "Pt",
                     RegionImageUrl = "https://www.istockphoto.com/photo/patan-durbar-square-gm514651173-47651120"
                 },
                  new Region
                 {
                     Id = Guid.NewGuid(),
                     Name = "Pokhara Region",
                     Code = "Pkr",
                     RegionImageUrl = "https://www.shutterstock.com/image-photo/phewa-lake-nepal-132349601"
                 }
             };*/


            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }

        //Get Single region: Get:https://localhost:portno/api/regions/{id}

        [HttpGet]
        [Route("{id}")]

        public IActionResult GetById([FromRoute]Guid id)
        {
            var region = dbContext.Regions.Find(id);

            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }

    }
}

