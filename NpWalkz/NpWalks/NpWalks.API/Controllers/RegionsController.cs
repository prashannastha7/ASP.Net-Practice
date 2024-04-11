using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NpWalks.API.Data;
using NpWalks.API.Models.Domain;
using NpWalks.API.Models.DTO;

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

            // Get Data From Database - Domain models
            var regionsDomain = dbContext.Regions.ToList();


            //Map Domian Modeks to DTOs
            var regionDTO = new List<RegionDto>();
            foreach (var region in regionsDomain) 
            {
                regionDTO.Add(new RegionDto()
                {
                    Id = region.Id,
                    Name = region.Name,
                    Code = region.Code,
                    RegionImageUrl = region.RegionImageUrl
                });
             
            }
            //Return DTOs
            return Ok(regionDTO);
        }

        //Get Single region: Get:https://localhost:portno/api/regions/{id}

        [HttpGet]
        [Route("{id}")]

        public IActionResult GetById([FromRoute]Guid id)
        {
            //Get Region Domain Model from db
            var regionDomain = dbContext.Regions.Find(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            //Map Region Domain Model to Region DTO

            var regionDto = new RegionDto
            {
                Id = regionDomain.Id,
                Name = regionDomain.Name,
                Code = regionDomain.Code,
                RegionImageUrl = regionDomain.RegionImageUrl

            };
            return Ok(regionDto);
        }

    }
}

