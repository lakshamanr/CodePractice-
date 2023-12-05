using DI.Controllers;

namespace DI.Models
{
    public interface IMyLocalLoger
    {
        void Print(string strMessage);
    }
    public class MyLocalLoger : IMyLocalLoger
    {
        private readonly ILogger<MyLocalLoger> _logger;
        public MyLocalLoger(ILogger<MyLocalLoger> logger)
        {
            _logger = logger;
        }
        public void Print(string strMessage)
        {
            _logger.LogInformation(strMessage);
        }
    }
}
