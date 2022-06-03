using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
  public class CarsController : Controller
  {
    private readonly IAllCars _allCars;
    private readonly ICarsCategory _allCategories;

    public CarsController (IAllCars iallCars, ICarsCategory IcarsCat)
    {
      _allCars = iallCars;
      _allCategories = IcarsCat;
    }
  }
}
