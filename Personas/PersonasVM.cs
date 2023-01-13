using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class PersonasVM : ObservableObject
    {
        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }

        public RelayCommand CargarNuevaPersona { get; }

        public RelayCommand CargarListadoPersona { get; }

        

        


        public PersonasVM()
        {
            CargarNuevaPersona = new RelayCommand(CargarVentana1);
            CargarListadoPersona = new RelayCommand(CargarVentana2);
            
        }

        

        public void CargarVentana1()
        {
            ContenidoVentana = new UserControl1();
        }

        public void CargarVentana2()
        {
            ContenidoVentana = new UserControl2();
        }
    }
}
