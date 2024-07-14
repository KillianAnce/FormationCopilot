using Entities;

namespace Repositories
{
    public interface ICarRepository
    {
        IEnumerable<CarEntity> GetAllCars();
        CarEntity GetCarById(int id);
        void AddCar(CarEntity car);
        void UpdateCar(CarEntity car);
        void DeleteCar(int id);

    }
}