using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsitenciaEmpresaProyectoFinal
{
    internal class Empleados
    {
        //Atributos//

        /// <summary>
        /// Numero de empleado.
        /// </summary>
        public string N_Empleado { get; set; }
        /// <summary>
        /// Nombre del empleado.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Departamento donde trabaja el empleado.
        /// </summary>
        public string Departamento { get; set; }
        /// <summary>
        /// Sueldo del empleado.
        /// </summary>
        public string Sueldo { get; set; }

        public string Herramientas { get; set; }



        //Metodos//

        public void Impresion()
        {
            DateTime fecha = DateTime.Now;
            MessageBox.Show("Imprimiendo recibo", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StreamWriter escribir = new StreamWriter("Empleado.txt");

            try
            {
                escribir.WriteLine("Fecha:  " + fecha);
                escribir.WriteLine("Numero de empleado:  " + N_Empleado);
                escribir.WriteLine("Nombre:  " + Nombre);
                escribir.WriteLine("Departamento:  " + Departamento);
                escribir.WriteLine("Solicito:  " + Herramientas);
                escribir.WriteLine("\n");

            }

            catch
            {
                MessageBox.Show("Error en la impresión", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            escribir.Close();


            StreamWriter escribir1 = new StreamWriter("Registro de empleados.txt", true);

            try
            {
                escribir1.WriteLine("Fecha:  " + fecha);
                escribir1.WriteLine("Numero de empleado:  " + N_Empleado);
                escribir1.WriteLine("Nombre:  " + Nombre);
                escribir1.WriteLine("Departamento:  " + Departamento);
                escribir1.WriteLine("Solicito:  " + Herramientas);
                escribir1.WriteLine("\n");

            }

            catch
            {
                MessageBox.Show("Error en la impresión", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            escribir1.Close();




        }
    }
}
