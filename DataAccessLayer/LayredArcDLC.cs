using DataAccessLayer.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class LayredArcDLC : ILayredArcDemoDLC
    {
        private readonly ILogger _logger;
        public LayredArcDLC(ILogger<LayredArcDLC> logger)
        {
            _logger = logger;
        }
        public void MethodTest()          
        {
            _logger.LogInformation("method test started");
         
            Console.WriteLine("yeah data acces layer is accessible");

            _logger.LogInformation("method test completed");
           
        }
    }
}
