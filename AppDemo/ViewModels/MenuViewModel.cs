using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
using Prism.Regions;
using MenuItem = AppDemo.Models.MenuItem;

namespace AppDemo.ViewModels
{
    public class MenuViewModel
    {
        public MenuViewModel(IRegionManager regionManager)
        {
            MenuItems = new ObservableCollection<MenuItem>()
            {
              new MenuItem{Text = "Sorter", Command = new RelayCommand(() => regionManager.RequestNavigate("GenerateRegion", new Uri("")))}  
            };
        }

        public ObservableCollection<MenuItem> MenuItems { get; set; }
    }
}
