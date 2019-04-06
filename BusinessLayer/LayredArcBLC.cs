using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;

namespace BusinessLayer
{
   public class LayredArcBLC : ILayredArcDemoBLC      
    {
        private readonly ILayredArcDemoDLC _dlcInterfaceObj;

        public LayredArcBLC(ILayredArcDemoDLC dlcInterfaceObj)
        {
            _dlcInterfaceObj = dlcInterfaceObj;
        }
        public void MethodOneBLC()
        {
            _dlcInterfaceObj.MethodTest();
           // throw new NotImplementedException();
        }
    }
}
