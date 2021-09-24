using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App3.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        public string Apellido1
        {
            get => _apellido1;
            set
            {
                if (string.Equals(_apellido1, value)) return;
                _apellido1 = value;
                OnPropertyChanged(nameof(Apellido1));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Apellido2
        {
            get => _apellido2;
            set
            {
                if (string.Equals(_apellido2, value)) return;
                _apellido2 = value;
                OnPropertyChanged(nameof(Apellido2));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => string.Format("Tu nombre completo es {0} {1} {2}", _nombre, _apellido1, _apellido2 );
        }

    }

}

