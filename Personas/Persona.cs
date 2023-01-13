using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Persona : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona()
        {

        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.nacionalidad = nacionalidad;
        }

        public static ObservableCollection<Persona> GetSamples()
        {
            ObservableCollection<Persona> list = new ObservableCollection<Persona>();
            list.Add(new Persona("Pietro", 30, "Italiana"));
            list.Add(new Persona("Julia", 25, "Española"));
            list.Add(new Persona("Sophie", 35, "Francesa"));
            return list;
        }



    }
}
