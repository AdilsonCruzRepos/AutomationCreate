using OpenQA.Selenium;

namespace br.gw.automationcreater.Infra.Interface
{
    public interface ILoginService
    {
        void LoginProjects();
        void LoginMail(IWebDriver driver);
    }
}
