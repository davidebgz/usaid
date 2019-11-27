using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AsistenciaUsaid
{
    public partial class MainPage : ContentPage
    {
        public List<Alumnos> RegistroAlumnos { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Alumnos Alumn = new Alumnos();
            Alumn.Nombre = ENombre.Text;
            Alumn.Apellido = EApellido.Text;
            Alumn.Edad = Convert.ToInt32(EEdad.Text);
            Alumn.Especialidad = EEspecialidad.Text;

            RegistroAlumnos.Add(Alumn);
            ListViewAlumnos.ItemsSource = null;
            ListViewAlumnos.ItemsSource = RegistroAlumnos;
        }
    }
}
