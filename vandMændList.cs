using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OrderList.Annotations;

namespace OrderList
{
    class vandMændList : INotifyPropertyChanged
    {
        private string _tentacleLength;
        private string _name;
        private string _deepThoughtsFromTheDeepOcean;
        public vandMændList(string tentacleLength, string name, string deepThoughtsFromTheDeepOcean)
        {
            this._tentacleLength = tentacleLength;
            this._name = name;
            this._deepThoughtsFromTheDeepOcean = deepThoughtsFromTheDeepOcean;
        }

        public string TentacleLength
        {
            get { return _tentacleLength; }
            set { _tentacleLength = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string DeepThoughtsFromTheDeepOcean
        {
            get { return _deepThoughtsFromTheDeepOcean; }
            set { _deepThoughtsFromTheDeepOcean = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
