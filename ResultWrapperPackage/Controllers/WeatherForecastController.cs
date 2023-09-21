using Microsoft.AspNetCore.Mvc;
using ResultWrapperPackage.Services;

namespace ResultWrapperPackage.Controllers;

[ApiController]
[Route("api/v1/weather-forecasts")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet("success/generics")]
    public ActionResult GetGenericsSuccess()
    {
        var infos = _weatherForecastService.GetWeatherForecastsGenericWithSuccess();

        return Ok(infos);
    }

    [HttpGet("success/non-generics")]
    public ActionResult GetNonGenericsSuccess()
    {
        var infos = _weatherForecastService.GetWeatherForecastsNonGenericWithSuccess();

        return Ok(infos);
    }

    [HttpGet("errors/generics")]
    public ActionResult GetGenericErrors()
    {
        var infos = _weatherForecastService.GetWeatherForecastsGenericWithError();

        return BadRequest(infos);
    }

    [HttpGet("errors/non-generics")]
    public ActionResult GetNonGenericErrors()
    {
        var infos = _weatherForecastService.GetWeatherForecastsNonGenericWithError();

        return BadRequest(infos);
    }
}