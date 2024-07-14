using Microsoft.AspNetCore.Mvc;

namespace rentCar.Controllers;
[Route("[controller]")]
public class CarController : ControllerBase
{
    private static readonly string[] Brand =
    [
        "Opel", "Peugeot", "Citroen", "Kia", "Volkswagen", "Smart", "Lotus", "BMW", "Ferrari", "Toyota"
    ];

    private static readonly string[] Type =
    [
        "Citadine", "Berline", "4x4", "Sport"
    ];

    private static List<Car> _cars = new List<Car>();

    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCar")]
    public IEnumerable<Car> GetAll()
    {
        return _cars;
    }

    [HttpGet("{id}", Name = "GetCarById")]
    public ActionResult<Car?> GetById(int id)
    {
        var car = _cars.FirstOrDefault(c => c.RentalId == id);
        if (car == null)
        {
            return NotFound();
        }
       return car;
    }

    [HttpPost]
    public ActionResult<Car> Create(Car car)
    {
        car.RentalId = _cars.Count + 1;
         _cars.Add(car);
        return CreatedAtRoute("GetCarById", new { id = car.RentalId }, car);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Car updatedCar)
    {
        var car = _cars.FirstOrDefault(c => c.RentalId == id);
        if (car == null)
        {
            return NotFound();
        }
        car.RentalStartDate = updatedCar.RentalStartDate;
        car.RentalEndDate = updatedCar.RentalEndDate;
        car.FuelCharge = updatedCar.FuelCharge;
        car.Horses = updatedCar.Horses;
        car.extraInsurance = updatedCar.extraInsurance;
        car.Type = updatedCar.Type;
        car.Brand = updatedCar.Brand;
        return NoContent();
    }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = _cars.FirstOrDefault(c => c.RentalId == id);
            if (car == null)
            {
                return NotFound();
            }
            _cars.Remove(car);
            return NoContent();
        }

    
    // Liste des voitures pas loués
    // Liste des locations en cours
    // Liste des voitures des voitures réservés
    // Liste des voitures ayant moins de 1000 km

}

