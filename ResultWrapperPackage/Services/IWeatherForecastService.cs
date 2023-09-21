using ResultWrapperPackage.Models;
using RW;

namespace ResultWrapperPackage.Services;

public interface IWeatherForecastService
{
    IResultWrapper<WeatherForecast[]> GetWeatherForecastsGenericWithSuccess();
    IResultWrapper GetWeatherForecastsNonGenericWithSuccess();
    IResultWrapper<WeatherForecast[]> GetWeatherForecastsGenericWithError();
    IResultWrapper GetWeatherForecastsNonGenericWithError();
}