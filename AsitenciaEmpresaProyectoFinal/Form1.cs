using OpenCvSharp;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using ZXing.QrCode;
using ZXing.Aztec;
using MaterialSkin;
using OpenCvSharp.Extensions;
using Size = OpenCvSharp.Size;

namespace AsitenciaEmpresaProyectoFinal
{
    /// <summary>
    /// Clase del formulario principal
    /// </summary>
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Formulario 1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        public void Carga()
        {
        }
        public void CerrarCam()
        {
        }
        /// <summary>
        /// Se encarga tanto de identificar los diferentes colores como de leer los codigos QR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Iniciar(object sender, EventArgs e)
        {

            using VideoCapture video = new VideoCapture(0);

            using Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(25, 25));
            button1.Visible = false;
            label1.Visible = true;

            while (Cv2.WaitKey(30) != 27)
            {
                using Mat imgp = new Mat();
                video.Read(imgp); // adquisicion de imagen
                using Mat imgp2 = imgp.GaussianBlur(new Size(11, 11), 22);//filtro blur
                using Mat img = imgp2.BilateralFilter(20, 40, 10);//filtro bilateral

                using Mat img2 = img.CvtColor(ColorConversionCodes.BGR2HSV);//conversion de bgr a Hvs
                var hmin = 96;
                var smin = 121;
                var vmin = 167;
                var hmax = 133;
                var smax = 160;
                var vmax = 255;

                //procesameinto azul
                Vec3i Bluelow = new Vec3i(hmin, smin, vmin);
                Vec3i Bluehigh = new Vec3i(hmax, smax, vmax);
                using Mat Bluemask = img2.InRange(Bluelow, Bluehigh);
                Cv2.Dilate(Bluemask, Bluemask, element);
                Rect Blueboundingbox = Cv2.BoundingRect(Bluemask);
                imgp.Rectangle(Blueboundingbox, new Scalar(255, 0, 0), 5);
                //procesameinto amarillo
                Vec3i Yellowlow = new Vec3i(25, 32, 205);
                Vec3i Yellowhigh = new Vec3i(35, 38, 255);
                using Mat Yellowmask = img2.InRange(Yellowlow, Yellowhigh);
                Cv2.Dilate(Yellowmask, Yellowmask, element);
                Rect Yellowboundingbox = Cv2.BoundingRect(Yellowmask);
                imgp.Rectangle(Yellowboundingbox, new Scalar(0, 255, 255), 5);
                //procesameinto rojo
                Vec3i Redlow = new Vec3i(0, 120, 210);
                Vec3i Redhigh = new Vec3i(5, 160, 250);
                using Mat Redmask = img2.InRange(Redlow, Redhigh);
                Cv2.Dilate(Redmask, Redmask, element);
                Rect Redboundingbox = Cv2.BoundingRect(Redmask);
                imgp.Rectangle(Redboundingbox, new Scalar(0, 0, 255), 5);
                //procesameinto rosa
                Vec3i Pinklow = new Vec3i(153, 90, 140);
                Vec3i Pinkhigh = new Vec3i(160, 160, 255);
                using Mat Pinkmask = img2.InRange(Pinklow, Pinkhigh);
                Cv2.Dilate(Pinkmask, Pinkmask, element);
                Rect Pinkboundingbox = Cv2.BoundingRect(Pinkmask);
                imgp.Rectangle(Pinkboundingbox, new Scalar(240, 0, 255), 5);
                //procesameinto verde
                Vec3i Greenlow = new Vec3i(40, 86, 184);
                Vec3i Greenhigh = new Vec3i(60, 195, 255);
                using Mat Greenmask = img2.InRange(Greenlow, Greenhigh);
                Cv2.Dilate(Greenmask, Greenmask, element);
                Rect Greenboundingbox = Cv2.BoundingRect(Greenmask);
                imgp.Rectangle(Greenboundingbox, new Scalar(2, 255, 0), 5);


                pictureBox1.Image = imgp.ToBitmap();

                if (pictureBox1.Image != null)
                {
                    BarcodeReader barcodereader = new BarcodeReader();
                    Result result = barcodereader.Decode((Bitmap)pictureBox1.Image);//obtnemos la plabra del QR
                    if (result != null)
                    {
                        texQR.Text = result.ToString();

                        if (texQR.Text == "Amarillo")//la comparamos con Amarillo
                        {
                            texQR.Text = "Bienvendio Administrativo";
                            Administrativos Adm = new Administrativos();
                            Adm.Visible = true;
                            this.Close();
                            break;
                        }
                        if (texQR.Text == "Pink")//la comparamos con rosa
                        {
                            texQR.Text = "Bienvendio Contador";
                            Contadores Ctd = new Contadores();
                            Ctd.Visible = true;
                            this.Close();
                            break;
                        }
                        if (texQR.Text == "Azul")//la comparamos con azul
                        {
                            texQR.Text = "Bienvendio Conserje";
                            Limpieza Lpz = new Limpieza();
                            Lpz.Visible = true;
                            this.Close();
                            break;
                        }
                        if (texQR.Text == "Verde")//la comparamos con verde
                        {
                            texQR.Text = "Bienvendio Jardinero";
                            Jardinero Jardinero = new Jardinero();
                            Jardinero.Visible = true;
                            this.Close();
                            break;
                        }
                        if (texQR.Text == "Rojo")//la comparamos con rojo
                        {
                            texQR.Text = "Bienvendio Dueño";
                            Dueños dueño = new Dueños();
                            dueño.Visible = true;
                            this.Close();
                            break;
                        }
                    }
                }
            }


        }
        private void Captura(object sender, NewFrameEventArgs eventArgs)
        {

        }
        private void Carga(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}