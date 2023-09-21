using ResultWrapperPackage.Models;
using RW;

namespace ResultWrapperPackage.Services;

public class WeatherForecastService : IWeatherForecastService
{
    public IResultWrapper<WeatherForecast[]> GetWeatherForecastsGenericWithSuccess()
    {
        return ResultWrapper.Success<WeatherForecast[]>(new WeatherForecast().GetWeatherForecasts(), "Weather forecast generic with success", 200);
    }

    public IResultWrapper GetWeatherForecastsNonGenericWithSuccess()
    {
        return ResultWrapper.Success(new WeatherForecast().GetWeatherForecasts(), "Weather forecast non generic with success", 200);
    }

    public IResultWrapper<WeatherForecast[]> GetWeatherForecastsGenericWithError()
    {
        return ResultWrapper.Failure<WeatherForecast[]>("Weather forecast generic with error", 404);
    }

    public IResultWrapper GetWeatherForecastsNonGenericWithError()
    {
        return ResultWrapper.Failure("Weather forecast non generic with error", 404);
    }
}