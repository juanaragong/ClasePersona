using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Persona
    {
        public int ine;
        public string nombre = "";
        public int edad;
        public string domicilio="";
        public string numTelefono = "";

        public void Tienepension()
        {
            if (edad >= 65)
            {
                MessageBox.Show("Person con pension ");
            }
            else
            {
                MessageBox.Show("Person sin pension que siga trabajando ");
            }

        }


    }
}
