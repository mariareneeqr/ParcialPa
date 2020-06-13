using AppPa2.Models;
using AppPa2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPa2.ViewModels
{
    public class PlaceViewModel:BaseViewModel
    {
        //Apirest
        #region Services
        private ApiService apiServices;
        #endregion
        #region Attributes
        private long id;
        private string tittle;
        private Uri url;
        #endregion
        #region Properties
        public long Id
        {
            get { return this.id; }
            set { SetValue(ref this.id, value); }
        }
        public string Tittle
        {
            get { return this.tittle; }
            set { SetValue(ref this.tittle, value); }
        }
        public Uri Url
        {
            get { return this.url; }
            set { SetValue(ref this.url, value); }
        }
        #endregion
        #region Constructor 
        public PlaceViewModel()
        {
            this.apiServices = new ApiService();
            this.LoadPlace();
        }
        #endregion
        #region Methods

        private async void LoadPlace()
        {
            var place = await this.apiServices.Get<Place>(
                "https://jsonplaceholder.typicode.com/photos/"
                "jsonplaceholder.typicode.com/",
                "photos/"
                 );
            this.Id = place[0].Id;
            this.Tittle = place[0].Tittle;
            this.Url= place[0].Url;

            //llamar api
        }
        #endregion
    }
}


