using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
  public interface IAllCars
  {
    IEnumerable<Car> Cars { get; set; }
    IEnumerable<Car> GetFavCars { get; set; }
    Car GetCarByID(int carId);
  }
}
