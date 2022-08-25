using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_App
{
    public class DataLayoutPageViewModel : INotifyPropertyChanged
    {
        public DataLayoutPageViewModel()
        {

            
        }
                
        public List<Entry> Items { get; set; } = new List<Entry>();
        public string EntryLocation { get; set; }
        public int EntryAmount { get; set; }
        public string EntryDate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
