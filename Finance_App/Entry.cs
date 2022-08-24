using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finance_App
{
    public class Entry : INotifyPropertyChanged
    {
        private string _entryLocation;
        private string _entryAmount;
        private string _entryDate;

        public string EntryLocation
        {
            get { return _entryLocation; }
            set
            {
                if (value != _entryLocation)
                {
                    _entryLocation = value;
                    OnPropertyChanged();
                }
            }
        }
        public string EntryAmount
        {
            get { return _entryAmount; }
            set
            {
                if (value != _entryAmount)
                {
                    _entryAmount = value;
                    OnPropertyChanged();
                }
            }
        }
        public string EntryDate
        {
            get { return _entryDate; }
            set
            {
                if (value != _entryDate)
                {
                    _entryDate = value;
                    OnPropertyChanged();
                }
            }
        }        

        public List<Entry> Items { get; set; } = new List<Entry>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }        
}
