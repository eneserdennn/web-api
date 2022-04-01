using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

public class VehicleController : Controller
{

    List<Vehicle.Car> _oCars = new List<Vehicle.Car>()
    {
        new Vehicle.Car() {Id = 1, CarId = 1, Type = "car", Color = "black", Headlights = false ,Wheels = 4},
        new Vehicle.Car() {Id = 2, CarId = 2,Type = "car", Color = "white", Headlights = false, Wheels = 4},
        new Vehicle.Car() {Id = 3, CarId = 3,Type = "car", Color = "red", Headlights = false, Wheels = 4},
        new Vehicle.Car() {Id = 4, CarId = 4,Type = "car", Color = "blue", Headlights = false, Wheels = 4},
    };

    List<Vehicle.Bus> _Buses = new List<Vehicle.Bus>()
    {
        new Vehicle.Bus() {Id = 5, BusId = 1, Type = "bus", Color = "white"},
        new Vehicle.Bus() {Id = 6, BusId = 2, Type = "bus", Color = "black"},
        new Vehicle.Bus() {Id = 7, BusId = 3, Type = "bus", Color = "red"},
        new Vehicle.Bus() {Id = 8, BusId = 4, Type = "bus", Color = "blue"},
    };
    
    List<Vehicle.Boat> _oBoats = new List<Vehicle.Boat>()
    {
        new Vehicle.Boat() {Id = 9,  BoatId = 1,Type = "boat", Color = "white"},
        new Vehicle.Boat() {Id = 10,  BoatId = 2,Type = "boat", Color = "black"},
        new Vehicle.Boat() {Id = 11,  BoatId = 3,Type = "boat", Color = "red"},
        new Vehicle.Boat() {Id = 12,  BoatId = 4,Type = "boat", Color = "blue"},
    };
    
    // GET All Cars
    [HttpGet]
    [Route("api/Vehicle/GetCars")]
    public IActionResult GetCars()
    {
        if (_oCars.Count == 0)
        {
            return NotFound("No Cars Found");
        }
        {
            return Ok(_oCars);
        }
    }
    
    // GET Cars by color
    [HttpGet]
    [Route("api/Vehicle/GetCarsByColor/{color}")]
    public IActionResult GetCarsByColor(string color)
    {
        var oCars = _oCars.Where(x => x.Color == color).ToList();
        if (oCars.Count == 0)
        {
            return NotFound("No Cars Found");
        }
        {
            return Ok(oCars);
        }
    }
    
    // Get bus by color
    [HttpGet]
    [Route("api/Vehicle/GetBusesByColor/{color}")]  
    public IActionResult GetBusesByColor(string color)
    {
        var oBuses = _Buses.Where(x => x.Color == color).ToList();
        if (oBuses.Count == 0)
        {
            return NotFound("No Buses Found");
        }
        {
            return Ok(oBuses);
        }
    }
    
    // Get boat by color
    [HttpGet]
    [Route("api/Vehicle/GetBoatsByColor/{color}")]
    public IActionResult GetBoatsByColor(string color)
    {
        var oBoats = _oBoats.Where(x => x.Color == color).ToList();
        if (oBoats.Count == 0)
        {
            return NotFound("No Boats Found");
        }
        {
            return Ok(oBoats);
        }
    }
    
    // POST Car headlights
    [HttpPost]
    [Route("api/Vehicle/GetCar/{id}")]
    public IActionResult Post(int id, bool headlights)
    {
        var oCar = _oCars.FirstOrDefault(x => x.CarId == id);
        if (oCar == null)
        {
            return NotFound("Vehicle not found");
        }
        oCar.Headlights = headlights;
        return Ok(oCar);
    }
    
    // Delete car by id
    [HttpDelete]
    [Route("api/Vehicle/DeleteCar/{id}")]
    public IActionResult Delete(int id)
    {
        var oCar = _oCars.FirstOrDefault(x => x.CarId == id);
        if (oCar == null)
        {
            return NotFound("Vehicle not found");
        }
        _oCars.Remove(oCar);
        return Ok("Vehicle deleted");
    }
    


}