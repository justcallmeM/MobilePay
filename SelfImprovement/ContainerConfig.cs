using Autofac;
using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfImprovement
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Library.Utilities.ProcessedData>().As<Library.Utilities.IProcessedData>();
            builder.RegisterType<Library.Utilities.Fees>().As<Library.Utilities.IFees>();
            builder.RegisterType<Library.Utilities.Discounts>().As<Library.Utilities.IDiscounts>();

            return builder.Build();
        }
    }
}
