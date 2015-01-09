using Mvc4DDD.Application.Apps;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Interfaces.Repositories;
using Mvc4DDD.Domain.Interfaces.Services;
using Mvc4DDD.Domain.Services;
using Mvc4DDD.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Mvc4DDD.Administration.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Mvc4DDD.Administration.App_Start.NinjectWebCommon), "Stop")]

namespace Mvc4DDD.Administration.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof (IAppServiceBase<>)).To(typeof (AppServiceBase<>));
            kernel.Bind<ICompanyAppService>().To<CompanyAppService>();

            kernel.Bind(typeof (IServiceBase<>)).To(typeof (ServiceBase<>));
            kernel.Bind<ICompanyService>().To<CompanyService>();

            kernel.Bind(typeof (IRepositoryBase<>)).To(typeof (RepositoryBase<>));
            kernel.Bind<ICompanyRepository>().To<CompanyRepository>().WithConstructorArgument("conn", "Mvc4DDD");
        }
    }
}
