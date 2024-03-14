using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Api.CarServeces;
using Test.Api.Entity.Car;

namespace Test.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IcarServece _icarServece;

        public CarController(IcarServece icarServece)
        {
            _icarServece = icarServece;
        }

        [HttpPost]
        public async Task<ActionResult<Car>> Create(Car carDTO)
        {
           var result = await _icarServece.CreateAsync(carDTO);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<Car>> GetAll()
        {
            var result =await _icarServece.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<Car>> GetById(int id)
        {
            var result = await _icarServece.GetById(id);
            return result;
        }
        [HttpPut]
        public async Task<ActionResult<Car>> Update(int id, CarDTO carDTO)
        {
            var result = await _icarServece.UpdateAsync(id, carDTO);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult<string>> Delete(int id)
        {
            var result = await _icarServece.GetById(id);
            if (result != null)
            {
                return Ok("Delet boldi");
            }
            return BadRequest("Something went wrong");

        }
    }
}
