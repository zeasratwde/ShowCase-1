using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using Moq;
using System.Web.Mvc;
using AsratShowCase.DAL;
using AsratShowCase.Models;

namespace AsratShowCase.Infrastructure
{
    public class NinjectDependencyResolver: IDependencyResolver {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            addBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void addBindings()
        {
            kernel.Bind<IStateInfoRepository>().To<DefaultConnectionRepostory>();

            //Mock<IStateInfoRepository> mock = new Mock<IStateInfoRepository>();
            //mock.Setup(s => s.StatesInfo).Returns(new List<StateInfo> {
            //    new StateInfo { name = "New York", abbreviation = "NY", capital = "Albany"},
            //    new StateInfo { name = "MASSACHUSETTS", abbreviation = "MA", capital = "Boston" }
            //});
            //kernel.Bind<IStateInfoRepository>().ToConstant(mock.Object);

        }
    }
  
}