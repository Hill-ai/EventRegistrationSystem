using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using EventRegistrationSystem.Abstract; 
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Concrete;

namespace EventRegistrationSystem.Infrastructure
{
        public class NinjectDependencyResolver : IDependencyResolver
        {
            private IKernel kernel;
            public NinjectDependencyResolver(IKernel kernelParam)
            {
                kernel = kernelParam;
                AddBindings();
            }
            public object GetService(Type serviceType)
            {
                return kernel.TryGet(serviceType);
            }
            public IEnumerable<object> GetServices(Type serviceType)
            {
                return kernel.GetAll(serviceType);
            }
            private void AddBindings()
            {

            kernel.Bind<IEventRepository>().To<EFEventRepository>();

            
            
            //fake repo data
            /*Mock<IEventRepository> mockEventRepo = new Mock<IEventRepository>();
            mockEventRepo.Setup(m1 => m1.Events).Returns(new List<Event>{
                new Event{ Company = "CSX",
                NonProfit =  "Helping Hand" ,
                EventTime = DateTime.Now,
                RestrictedByCompany = true,
                EventLocked = true,
                EventHidden = true,
                EventCapacity = 50,
                EventID = 1001,
                EventName = "5k Fun Run",
                EventDescription = "Help out by collecting donations for every mile you run",
                EventDate = new DateTime(2018, 12, 01),
                EventStartTime = new DateTime(5, 1, 1),
                EventEndTime = DateTime.Now,
                EventDetails = "located at such and such location",
                EventInterest = 15,
                EventFiles = "some files and stuff",
                EventTotalTime = "3 hours",
                NonProfitID = 2100 },

            new Event{ Company = "Black Knight",
                NonProfit =  "Yoga 4 Change" ,
                EventTime = DateTime.Now,
                RestrictedByCompany = true,
                EventLocked = true,
                EventHidden = true,
                EventCapacity = 50,
                EventID = 1002,
                EventName = "Yoga Lessons",
                EventDescription = "Help out by teaching yoga",
                EventDate = new DateTime(2018, 12, 25),
                EventStartTime = new DateTime(10, 1, 1),
                EventEndTime = DateTime.Now,
                EventDetails = "located at such and such location",
                EventInterest = 15,
                EventFiles = "some files and stuff",
                EventTotalTime = "3 hours",
                NonProfitID = 2101 }
            });
            */
            //kernel.Bind<IEventRepository>().ToConstant(mockEventRepo.Object);
            
            
          
            }
        }
}
