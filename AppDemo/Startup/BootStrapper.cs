using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AppDemo.Interfaces;
using AppDemo.ViewModels;
using AppDemo.Views;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism;
using Prism.Regions;
using Prism.Unity;

namespace AppDemo.Startup
{
    public class Bootstrapper : Prism.Bootstrapper
    {
        private IUnityContainer _container;
        public Bootstrapper()
        {
          
        }

       

        

        public override void Run(bool runWithDefaultConfiguration)
        {
                
            ConfigureContrainer();
            ConfigureServiceLocator();
            CreateShell();

        }

      

        private void ConfigureContrainer()
        {
            var container = new UnityContainer();
            
            container.RegisterType<IUnityContainer, UnityContainer>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRegionManager, RegionManager>();
            container.RegisterType<ISorterViewModel, SorterViewModel>();
            container.RegisterTypeForNavigation<GenerateView>("GenerateRegion");
            container.RegisterType<MenuViewModel>();
            container.RegisterType<ContentViewModel>();
            container.RegisterType<object, MainWindow>();
            container.RegisterType<object, ContentView>();
            container.RegisterType<object, MenuView>();
            _container = container;
        }

        protected override DependencyObject CreateShell()
        {
            return _container.Resolve<MainWindow>();
        }

        protected override void ConfigureServiceLocator()
        {
            
            var locator = new UnityServiceLocator(_container);
            ServiceLocator.SetLocatorProvider(()=>locator);
            
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
           
        }
    }


    public class A : IA
    {
        public A()
        {
            Str = "1";
        }
        public string Str { get; set; }
    }

    public interface IA
    {
        
    }
}
