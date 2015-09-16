using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AppDemo.Shell.Startup;
using Microsoft.Practices.ServiceLocation;

namespace AppDemo.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var bootstrapper = new BootStrapper();
            bootstrapper.Run();

        }
       
        
    }
}
