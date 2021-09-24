using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App3.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
