using System;
using System.Collections.Generic;
using System.Text;

namespace AppPa2.Infrastructure
{
    using AppPa2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
