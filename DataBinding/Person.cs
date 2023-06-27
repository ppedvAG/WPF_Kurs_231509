using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public int Alter { get; set; }

        public List<DateTime> WichtigeTage { get; set; } = new List<DateTime>()
        {
            new DateTime(2003, 12, 3),
            new DateTime(2004, 1, 5),
            DateTime.Now
        };

        public DateTime LetzterTag { get =>  WichtigeTage.Last();  }


        public Person()
        {
            Name = "Rainer Zufall";
            Alter = 34;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public override string ToString()
        {
            return $"{this.Name} ({this.Alter})";
        }

    }
}
