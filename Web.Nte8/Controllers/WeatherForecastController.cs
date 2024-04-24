using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Nte8.IService;
using Web.Nte8.Model;

namespace Web.Nte8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBaseService<Role, RoleVo> _roleService;
        private readonly IMapper _mapper;
        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="roleService"></param>
        /// <param name="mapper"></param>
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IBaseService<Role, RoleVo> roleService,
            IMapper mapper)
        {

            _logger = logger;
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<object> Get()
        {
            /*  return Enumerable.Range(1, 5).Select(index => new WeatherForecast
              {
                  Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                  TemperatureC = Random.Shared.Next(-20, 55),
                  Summary = Summaries[Random.Shared.Next(Summaries.Length)]
              })
              .ToArray();*/
            /*
                        var roleService = new BaseService<Role, RoleVo>(_mapper);*/
            var roleList2 = await _roleService.Query();
            return roleList2;

        }
    }
}
