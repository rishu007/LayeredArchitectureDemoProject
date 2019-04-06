using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using Microsoft.Extensions.Logging;

namespace BusinessLayer
{
   public class LayredArcBLC : ILayredArcDemoBLC      
    {
        private readonly ILayredArcDemoDLC _dlcInterfaceObj;
        private readonly ILogger _logger;


        public LayredArcBLC(ILayredArcDemoDLC dlcInterfaceObj, ILogger<LayredArcBLC> logger)
        {
            _dlcInterfaceObj = dlcInterfaceObj;
            _logger = logger;
        }
        public void MethodOneBLC()
        {
            _logger.LogInformation("MethodOneBLC started");
            _dlcInterfaceObj.MethodTest();
            // throw new NotImplementedException();

            _logger.LogInformation("MethodOneBLC ended");
        }
    }
}
