using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsitenciaEmpresaProyectoFinal
{
    public partial class Contadores : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Numero del contador
        /// </summary>
        public static string n_empleado;
        /// <summary>
        /// Nombre del contador
        /// </summary>
        public static string nombre;
        /// <summary>
        /// Departamento del empleado
        /// </summary>
        public static string departamento;
        /// <summary>
        /// Salario del contador
        /// </summary>
        public static string salario;
        /// <summary>
        /// Material que necesita para su trabajo
        /// </summary>
        public static string herramientas;
        /// <summary>
        /// Lista de contadores
        /// </summary>
        List<Empleados> lista = new List<Empleados>();
        string[] listar;
        int a = 0;
        public Contadores()
        {
            InitializeComponent();
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;//Cambia el color de fondo del fomulario
            SkinManager.ColorScheme = new ColorScheme(Primary.Pink500, Primary.Pink500, Primary.Pink500, Accent.DeepOrange700, TextShade.WHITE);//Modifica el color de bordes de ventanas del formulario
        }
        /// <summary>
        /// Carga la información de los empleados de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contadores_Load(object sender, EventArgs e)
        {
            string dat = "basededatos.txt";
            //Guardamos la base de datos en una variable.
            listar = File.ReadAllLines(dat);

            //Recorremos nuestra base de datos para separar en ella cada parametro.
            for (int i = 0; i < listar.Length; i++)
            {
                string[] array = listar[i].Split(',');

                Empleados n = new Empleados();
                n.N_Empleado = array[0];
                n.Nombre = array[1];
                n.Departamento = array[2];
                n.Sueldo = array[3];
                lista.Add(n);
                StringBuilder sb = new StringBuilder();
                sb.Append(array).AppendLine();
                sb.ToString();
                string outs = string.Join(",", n.N_Empleado, n.Nombre, n.Departamento, n.Sueldo);
            }
        }
        /// <summary>
        /// Verifica que solo se ingresen números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumTrabCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo es posible utilizar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// Se encargar de mostrar el registro de contadores y cerrar el formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Al hacer clic, realiza la verificación</param>
        private void IngresarCont_Click(object sender, EventArgs e)
        {
            a = 0;
            bool autorizar = false;
            string departamento = "Contadores";
            //recorremos la base de datos, y verifamos que el numero de empleado sea valido.
            foreach (var emp in lista)
            {
                if (NumTrabCont.Text == emp.N_Empleado && (emp.Departamento.Equals(departamento, StringComparison.OrdinalIgnoreCase)))
                {
                    n_empleado = emp.N_Empleado;
                    nombre = emp.Nombre;
                    departamento = emp.Departamento;
                    salario = emp.Sueldo;
                    autorizar = true;
                    //Envia un mensaje si el empleado ha sido localizado.
                    MessageBox.Show("Empleado encontrado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Registro_Contadores regi = new Registro_Contadores();
                    regi.Show();
                    regi.textBox1.Tag = emp.N_Empleado;
                    regi.textBox1.Text = emp.Nombre;
                    this.Close();
                    break;


                }
                else if (NumTrabCont.Text == emp.N_Empleado && emp.Departamento != "Contadores")
                {
                    MessageBox.Show("USTED NO PERTENECE A ESTE DEPARTAMENTO, INTENTE DE NUEVO", "ALERTA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    autorizar = true;
                    Form1 f1 = new Form1();
                    f1.Visible = true;
                    this.Close();
                    break;
                }
            }
            if (autorizar == false)
            {
                //En caso de que un emplead no se pueda localizar, nos manda un mensaje por medio de una ventana emergente.
                MessageBox.Show("Empleado no localizado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumTrabCont.Text = "";

            }



            NumTrabCont.Text = "";



        }
    }
}
