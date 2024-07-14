using Entity;
using Microsoft.EntityFrameworkCore;

namespace Repositories // Replace "YourNamespace" with the actual namespace of your repositories
{
    public class CarRepository : ICarRepository // Replace "ICarRepository" with the actual interface name, if applicable
    {
        // Add a private readonly field for the DbContext
        private readonly RentCarDbContext _dbContext;

        // Add a constructor that accepts the DbContext
        public CarRepository(RentCarDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CarEntity> GetAllCars()
        {
            return _dbContext.Cars.ToList();
        }

        public CarEntity GetCarById(int id)
        {
            return _dbContext.Cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(CarEntity car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void UpdateCar(CarEntity car)
        {
            _dbContext.Entry(car).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
            }
        }

        // Function to only retrieve red cars
        public IEnumerable<CarEntity> GetRedCars()
        {
            return _dbContext.Cars.Where(c => c.Color == "Red").ToList();
        }
    }
}