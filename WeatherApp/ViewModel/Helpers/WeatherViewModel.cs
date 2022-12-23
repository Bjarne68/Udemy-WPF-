using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using WeatherApp.Model;
using WeatherApp.ViewModel.Commands;

namespace WeatherApp.ViewModel.Helpers
{
    [AddINotifyPropertyChangedInterface]
    
    public class WeatherViewModel
    {
        public string Query { get; set; }
        public CurrentConditions CurrentConditions { get; set; }
        public City SelectedCity { get; set; }
        public SearchCommand SearchCommand { get; set; }
        public ObservableCollection<City> Cities { get; set; }
        
        public WeatherViewModel()
        {
        

            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                SelectedCity = new City()
                {
                    LocalizedName = "New York"
                };
                CurrentConditions = new CurrentConditions()
                {
                    WeatherText = "Partly cloudy",
                    Temperature = new Temperature
                    {
                        Metric = new Units
                        {
                            Value = 21
                        }
                    }
                };
            }
            SearchCommand = new SearchCommand(this);
            var Cities = new ObservableCollection<City>();

        }
        public  async void MakeQuery()
        {
            var cities = await AccuWeatherHelper.GetCities(Query); 
           Cities.Clear();
            foreach (var city in cities)
            {
                Cities.Add(city);
            }

           
        }
    }
}
