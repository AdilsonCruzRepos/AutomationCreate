using br.gw.automationcreater.Infra.Interface;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace br.gw.automationcreater.Infra.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> _logger;
        public LoginService(ILogger<LoginService> logger)
        {
            _logger = logger;
        }

        public void LoginMail(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(" https://mail.zimbra.com.br:7071/zimbraAdmin/");

            var pageUnsave = driver.FindElement(By.Id("details-button"));
            pageUnsave.Click();

            var openUnsav = driver.FindElement(By.Id("proceed-link"));
            openUnsav.Click();

            var loginAdmin = driver.FindElement(By.XPath("//*[@id='ZLoginUserName']"));
            var passAdmin = driver.FindElement(By.XPath(" //*[@id='ZLoginPassword']"));
            var clickAdmin = driver.FindElement(By.XPath("//*[@id='ZLoginButton']"));

            loginAdmin.SendKeys("meu email");
            passAdmin.SendKeys("minha senha");

            clickAdmin.Click();

            throw new NotImplementedException();
        }

        public void LoginProjects()
        {

            IWebDriver driver = new ChromeDriver("C:/Development");

            driver.Navigate().GoToUrl("http://projetos.gateware.com.br:8000/");

            var loginInput = driver.FindElement(By .Id("email"));
            loginInput.SendKeys("adilson.cruz@gateware.com.br");

            var passInput = driver.FindElement(By.Id("password"));
            passInput.SendKeys("n1010");

            var NUMBER_OF_MILLIS = 3000;

            Thread.Sleep(NUMBER_OF_MILLIS);

            var buttonLogin = driver.FindElement(By.XPath("//*[@id='login']/table/tbody/tr[4]/td/input"));
            buttonLogin.Click();

            Console.WriteLine("...");
            throw new NotImplementedException();
        }
    }
}
