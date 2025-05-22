using Microsoft.AspNetCore.Mvc;
using UnivatorsKavala2025.Models;
using UnivatorsKavala2025.Security;

namespace UnivatorsKavala2025.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet("GetWeatherForecastById/{id}")]
    public WeatherForecast GetById(int id)
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(id)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
    [HttpPost("CreateWeatherForecast")]
    public WeatherForecast CreateWeatherForecast([FromBody] WeatherForecast weather)
    {
        return new WeatherForecast
        {
            Date = weather.Date,
            TemperatureC = weather.TemperatureC,
            Summary = weather.Summary
        };
    }


    [HttpPut("UpdateWeatherForecast")]
    public IActionResult UpdateWeatherForecast([FromBody] WeatherForecast weatherForecast)
    {
        // Here you would typically update the weather forecast in your database
        // For this example, we'll just return the updated forecast
        return Ok(weatherForecast);
    }
    [HttpDelete("DeleteWeatherForecast/{id}")]
    [ApiKeyAuth]
    public IActionResult DeleteWeatherForecast([FromRoute]int id)
    {
        // Here you would typically delete the weather forecast from your database
        // For this example, we'll just return a success message
        return Ok($"Weather forecast with ID {id} deleted successfully.");
    }


    [HttpGet("protected")]
    [ApiKeyAuth] // Apply only to this action
    public IActionResult GetProtectedData()
    {
        return Ok("Data from protected endpoint");
    }
}

