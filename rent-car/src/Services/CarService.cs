using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using Repositories;

namespace YourNamespace.Services // Replace YourNamespace with the actual namespace of your service
{
    public class CarService
    {
        private readonly CarRepository _carRepository;

        public CarService(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<CarEntity>> GetAllCars()
        {
            return _carRepository.GetAllCars().ToList();
        }

        // Add more methods as needed
        

        // Example method:
        public async Task<CarEntity> GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }
    }
}