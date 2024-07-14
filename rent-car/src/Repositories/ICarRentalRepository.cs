using Entities;

namespace Repositories
{
    public interface ICarRentalRepository
    {
        void AddRental(CarRentalEntity rental);
        void RemoveRental(CarRentalEntity rental);
        List<CarRentalEntity> GetAllRentals();
    }
}