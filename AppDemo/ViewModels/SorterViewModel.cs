using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDemo.Interfaces;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace AppDemo.ViewModels
{
    public class SorterViewModel : ISorterViewModel
    {
        

        public SorterViewModel(IUnityContainer container)
        {
            
        }

        public int X = 3;

    }
}
