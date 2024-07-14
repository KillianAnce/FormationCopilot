using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Repositories
{
    public class CarRentalRepository : ICarRentalRepository
    {
        // Add a private readonly field for the DbContext
        private readonly RentCarDbContext _dbContext;

        private List<CarRentalEntity> rentals;

        // Add a constructor that accepts the DbContext
        public CarRentalRepository(RentCarDbContext dbContext)
        {
            rentals = new List<CarRentalEntity>();
            _dbContext = dbContext;
        }

        public void AddRental(CarRentalEntity rental)
        {
            throw new NotImplementedException();
        }

        public void RemoveRental(CarRentalEntity rental)
        {
            throw new NotImplementedException();
        }

        public List<CarRentalEntity> GetAllRentals()
        {
            throw new NotImplementedException();
        }

        // Liste des locations par id
        // Liste des locations en cours
        // Liste des locations terminées
    }
}