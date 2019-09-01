using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ShellViewModel : BindableBase
    {

        private string applicationTitle;
        public string ApplicationTitle
        {
            get { return applicationTitle; }
            set { SetProperty(ref applicationTitle, value); }
        }

        public ShellViewModel()
        {
            ApplicationTitle = "AZERTY";
        }
    }
}
