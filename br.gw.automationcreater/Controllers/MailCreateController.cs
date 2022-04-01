using br.gw.automationcreater.Infra.Interface;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace br.gw.automationcreater.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailCreateController
    {
        private readonly ILogger<MailCreateController> _logger;
        private readonly ILoginService _login;

        public MailCreateController(ILogger<MailCreateController> logger, ILoginService login)
        {
            _logger = logger;
            _login = login;
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public  void PostCreateAsync(string email, string password)
        {
            IWebDriver driver = new ChromeDriver("C:/Development");
            _login.LoginMail(driver);

        }
    }
}
