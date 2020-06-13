using System;
using System.Collections.Generic;
using System.Text;

namespace AppPa2.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public PlaceViewModel Places { get; set; }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            this.Places = new PlaceViewModel();
                
        }
        #endregion
    }
}
