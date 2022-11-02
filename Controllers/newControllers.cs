//aisha mashrah
//  we are  turning an entire webapi application that has endpoints 
//11-2-22
//Add 2 Numbers - Endpoint
using Microsoft.AspNetCore.Mvc;

namespace mashrahaAdd2_Numbers_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   [HttpGet]
    [Route("addingNumbers")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }

}