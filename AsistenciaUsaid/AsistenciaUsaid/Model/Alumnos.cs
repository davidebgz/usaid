using System;
using System.Collections.Generic;
using System.Text;

namespace AsistenciaUsaid
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        private string _Especialidad;

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value.ToUpper(); }  //Para recibir datos en mayusculas
        }

    }
}
