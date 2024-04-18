using BuberBreakfast.Models;

namespace BuberBreakFast.Services.Breakfast;

public interface IBreakfastService
{
    void BreakfastResponse CreateBreakfast(Breakfast breakfast);
}