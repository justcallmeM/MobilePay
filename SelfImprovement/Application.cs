using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfImprovement
{
    class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
        public void Run()
        {
            _businessLogic.OutputResults();
        }
    }
}
