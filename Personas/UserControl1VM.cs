using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class UserControl1VM : ObservableObject
    {
        private ServicioNavegacion servicio;

        public RelayCommand CargarVentanaNacionalidad { get; }

        


        private ObservableCollection<string> nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        public UserControl1VM()
        {
          
            servicio = new ServicioNavegacion();
            CargarVentanaNacionalidad = new RelayCommand(AbrirVentanaNacionalidad);
            Nacionalidades = new ObservableCollection<string>();
            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");
        }

        public void AbrirVentanaNacionalidad()
        {
            servicio.AbrirVentanaNacionalidad();
        }
    }
}
