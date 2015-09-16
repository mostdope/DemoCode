using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDemo.Shell.Interfaces;

namespace AppDemo.Shell.ViewModels
{
    public class ShellViewModel : IShellViewModel
    {
        
        public ShellViewModel()
        {
           MenuViewModel = new MenuViewModel();
           ContentViewModel = new ContentViewModel();
        }

        public MenuViewModel MenuViewModel { get; set; }

        public ContentViewModel ContentViewModel { get; set; }
    }
}
