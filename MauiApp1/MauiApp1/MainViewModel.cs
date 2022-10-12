using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
       
        public MainViewModel()
        {
            Cars.Add("Car1");
            Cars.Add("Car2");
            Cars.Add("Car3");
            Cars.Add("Car4");
        }
        public ObservableCollection<string> Cars { get; set; } = new ObservableCollection<string>();
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
