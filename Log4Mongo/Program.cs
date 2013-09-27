using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Log4Mongo
{
    class Program
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof (Program));

        static void Main(string[] args)
        {
            _logger.Debug("Will not log.");
            _logger.Info("Informational only");
            _logger.Error("Error, does not compute.");
            Console.ReadKey();
        }
    }
}
