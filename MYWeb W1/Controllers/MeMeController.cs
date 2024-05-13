using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYWeb_W1.Models;

namespace MYWeb_W1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeMeController : ControllerBase
    {
        
        private readonly ILineService _lineService;
        private readonly LineBotConfig _lineBotConfig;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpContext _httpContext;


        public MeMeController(IServiceProvider serviceProvider, ILineService lineService, LineBotConfig config)
        {
            _lineService = lineService;
            _lineBotConfig = config;

            _httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
            _httpContext = _httpContextAccessor.HttpContext;
        }
        // GET: api/MeMe
        [HttpGet]
        public IEnumerable<MeMeModels> Get()
        {
            int a = 3;
            int b = 6;
            
            return new MeMeModels[]
            {
                new MeMeModels(){Id = 1,Type = "梗圖",Content = "瑞克搖"}
                ,new MeMeModels(){Id = 2,Type = "梗圖",Content = "比讚"}

            };
        }

        // GET: api/MeMe/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
/*
        // POST: api/MeMe
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
        
        [HttpPost] //POST {url}/api/MeMe
        public async Task<IActionResult> Post()
        {
            var events = await _httpContext.Request.GetWebhookEventsAsync(_lineBotConfig.channelSecret);
            var lineBotApp = new LineBotApp(_lineBotConfig, _lineService);
            await lineBotApp.RunAsync(events);

            return Ok();
        }

        // PUT: api/MeMe/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/MeMe/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
