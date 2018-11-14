using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OrderList.Annotations;

namespace OrderList
{
    class viewModel : INotifyPropertyChanged
    {
        private ObservableCollection<vandMændList> _vandMændLists = new ObservableCollection<vandMændList>();

        public viewModel()
        {
            _vandMændLists.Add(new vandMændList("27", "Benny", "fisk"));
            _vandMændLists.Add(new vandMændList("28", "Kaj", "light"));
            _vandMændLists.Add(new vandMændList("too long", "Finn", "darkness"));
        }


  
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<vandMændList> VandMændLists
        {
            get { return _vandMændLists; }
            set { _vandMændLists = value; }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
