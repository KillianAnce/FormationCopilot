using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories 
{
    public class CarRepository : ICarRepository
    {
        // Add a private readonly field for the DbContext
        private readonly RentCarDbContext _dbContext;

        // Add a constructor that accepts the DbContext
        public CarRepository(RentCarDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCar(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarEntity> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public CarEntity GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(CarEntity car)
        {
            throw new NotImplementedException();
        }
    }
}