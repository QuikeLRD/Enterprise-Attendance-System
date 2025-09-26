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
    public partial class Registro_jardinero : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Numero del empleado
        /// </summary>
        public static string n_empleado;
        /// <summary>
        /// Nombre del empleado
        /// </summary>
        public static string nombre;
        /// <summary>
        /// Departamento del empleado
        /// </summary>
        public static string departamento;
        /// <summary>
        /// Salario del empleado
        /// </summary>
        public static string salario;
        /// <summary>
        /// Herramientas que solicita
        /// </summary>
        public static string herramientas;
        int Nlist;
        string Time;
        int horas;
        int shora;

        /// <summary>
        /// Lista de empleados
        /// </summary>
        List<Empleados> lista = new List<Empleados>();
        string[] listar;
        int a = 0;
        public Registro_jardinero()
        {
            InitializeComponent();
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;//Cambia el color de fondo del fomulario
            SkinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green900, Primary.Green900, Accent.DeepOrange700, TextShade.WHITE);//Modifica el color de bordes de ventanas del formulario
        }

        /// <summary>
        /// Muestra la fecha y hora actuales en el fomulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FechaHoraJardin_Tick(object sender, EventArgs e)
        {
            fechaJardin.Text= DateTime.Now.ToLongDateString();
            horajardin.Text = DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// Realiza la verificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AsistenJardi_Click(object sender, EventArgs e)
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
            //VALIDACION DE TIEMPO EN FUNCIÓN DE DEPARTAMENTO
            a = 0;
            bool autorizar = false;
            foreach (var emp in lista)
            {
                if ((string)textBox1.Tag == emp.N_Empleado)
                {

                    n_empleado = emp.N_Empleado;
                    nombre = emp.Nombre;
                    departamento = emp.Departamento;
                    salario = emp.Sueldo;
                    autorizar = true;
                    //TOMA DE TIEMPO AL MOMENTO DE REGISTRAR
                    string time = DateTime.Now.ToString("h:mm:ss:tt");
                    //CUENTA DE SEGUNDOS DECONSTRUYENDO EL STRING DEL TIEMPO REGISTRADO
                    string[] tiempo = time.Split(":");
                    int shora = Convert.ToInt32(tiempo[0]);
                    if (tiempo[0] == "12")
                    {
                        shora = 0;
                    }
                    int shr = shora * 3600;
                    int smin = Convert.ToInt32(tiempo[1]);
                    int m = smin * 60;
                    int seg = Convert.ToInt32(tiempo[2]);

                    if (tiempo[3] == "p. m.")
                    {
                        horas = 43200;
                    }
                    else if (tiempo[3] == "a. m." || tiempo[0] == "12" && tiempo[3] == "p. m.")
                    {
                        horas = 0;
                    }
                    //SUMA DE TODOS LOS SEGUNDOS Y VALIDACIONES EN DIFERENTES CASOS 
                    int segtotal = shr + m + seg + horas;
                    if (segtotal < 25200)
                    {
                        label7.Visible = true;
                        label7.ForeColor = Color.Green;
                        label7.Text = "USTED HA LLEGADO A TIEMPO";
                    }
                    else
                    {
                        int descuento = ((segtotal - 25200) / 3600) * 50;
                        label8.Visible = true;
                        label7.Visible = true;
                        label8.Text = (segtotal - 25200) / 3600 + " Horas";
                        label7.ForeColor = Color.Red;
                        label7.Text = "USTED HA LLEGADO TARDE POR:";
                        emp.Sueldo = Convert.ToString(Convert.ToInt32(emp.Sueldo) - descuento);
                        string direcc = @"G:\Mi unidad\UPIITA\Semestres\Cuarto\Programación avanzada\Proyecto final\AsitenciaEmpresaProyectoFinaltt\AsitenciaEmpresaProyectoFinal\bin\Debug\net6.0-windows\basededatos.txt";
                        string[] BASENEW = new String[lista.Count];
                        for (int i = 0; i < lista.Count; i++)

                        {
                            string createText = lista[i].N_Empleado + "," + lista[i].Nombre + "," + lista[i].Departamento + "," + lista[i].Sueldo;
                            BASENEW[i] = createText;

                        }
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label5.Text = Convert.ToString(descuento);
                        label6.Text = emp.Sueldo;
                        File.WriteAllLines(direcc, BASENEW, Encoding.UTF8);


                    }
                    break;
                }

            }

        }
        /// <summary>
        /// Permite imprimir un ticket con las herrientas que necesitamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">guarda los datos en un archivo txt</param>
        private void ticketJardi_Click(object sender, EventArgs e)
        {
            a = 0;
            bool autorizar = false;
            //recorremos la base de datos, y verifamos que el numero de empleado sea valido.
            foreach (var emp in lista)
            {
                if ((string)textBox1.Tag == emp.N_Empleado)
                {
                    emp.Herramientas = ErrorJardin.Text;
                    n_empleado = emp.N_Empleado;
                    nombre = emp.Nombre;
                    departamento = emp.Departamento;
                    salario = emp.Sueldo;
                    autorizar = true;
                    //escribe los datos del empleado en un archivo .txt
                    emp.Impresion();
                    ErrorJardin.Text = "Ticket Generado";
                    break;

                }



            }
        }
        /// <summary>
        /// Se sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Close();
        }
    }
}
