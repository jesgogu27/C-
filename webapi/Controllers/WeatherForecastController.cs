using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    

    private readonly ILogger<WeatherForecastController> _logger;

    private static List<WeatherForecast> listWeatherForecast = new List<WeatherForecast>();
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        if (listWeatherForecast == null || !listWeatherForecast.Any()){
            listWeatherForecast= Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
        .ToList();
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Retornando una lista de weatherforecast");
        return listWeatherForecast;        
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public IActionResult Post(WeatherForecast weatherForecast){
        listWeatherForecast.Add(weatherForecast);
        return Ok();
    }

    [HttpDelete("{index}")]
    public IActionResult Delete(int index){
        listWeatherForecast.RemoveAt(index);
        return Ok();
    }

}
