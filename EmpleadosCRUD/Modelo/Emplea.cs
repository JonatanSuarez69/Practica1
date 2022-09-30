using System;
using System.Collections.Generic;
using System.Text;

namespace EmpleadosCRUD.Modelo
{
    internal class Emplea
    {
       private string nombre;
       private string apellidos;
       private string correo;
       private string fechaIngreso;

        public Emplea()
        {
            this.nombre = "";
            this.apellidos = "";
            this.correo = "";
            this.fechaIngreso = "";
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }
}
