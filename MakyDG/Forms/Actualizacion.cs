using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;


namespace MakyDG.Forms
{
    public partial class Actualizacion : Form
    {
        //Variables de la Barra de Progreso
        private int progresoMaximo = 100;
        private int incremento = 1;

        //Variables del Control de Actualizacion
        private bool BuscandoActualizacion = false;
        private bool EncontradaActualizacion = false;
        private bool Actualizando = false;

        //Variable de Versiones
        private Version VersionActual = new Version(Assembly.GetExecutingAssembly().GetName().Version.ToString());
        //private Version VersionActual = new Version("1.0.0.0");
        private Version VersionNueva;


        //Variables de FTP
        private string ftpServer = "ftp://138.59.135.48:2121"; 
        private string ftpUser = "FtpUserMakyDG"; 
        private string ftpPassword = "MakyDG0192"; 
        private string filePath = "/Version.txt"; 
        private string FolderPath = "/MakyDG";

        public Actualizacion()
        {
            InitializeComponent();
            // Configura el Timer
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Configura el ProgressBar
            Progreso.Maximum = progresoMaximo;
            Progreso.Value = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Si no se está buscando actualizaciones, inicia la búsqueda
            if (!BuscandoActualizacion)
            {
                BuscandoActualizacion = true;
                GetFileVersionFromFtpAsync(); // Ejecuta la búsqueda de forma asíncrona
            }

            // Validar si se encontró actualización

            if (EncontradaActualizacion && !Actualizando)
            {
                Progreso.Value = progresoMaximo; // Establece el valor máximo del ProgressBar
                lblActualizacion.Text = "Actualización encontrada"; // Cambia el texto del Label           
                if (VersionNueva>VersionActual)
                {
                    Progreso.Value = 0;
                    GetFileCompressAppFromFtpAsync();
                    lblActualizacion.Text = "Actualizando...";
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("No hay Actualizaciones Disponibles");
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
            }

            // Incrementa el valor del ProgressBar
            if (Progreso.Value < progresoMaximo)
            {
                Progreso.Value += incremento;
            }
            else
            {
                timer.Stop();
            }
        }

        private async Task GetFileVersionFromFtpAsync()
        {
            string content = string.Empty;
            try
            {
                // Construye la URL completa del archivo FTP
                string url = ftpServer + filePath;

                // Crea la solicitud FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);

                // Ejecuta la solicitud de manera Normal
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    content = await reader.ReadToEndAsync();
                    VersionNueva = new Version(content);
                    EncontradaActualizacion = true;
                }
            }
            catch (Exception ex)
            {
                lblActualizacion.Text = "Error al Encontrar Actualizacion";
                Progreso.Value = progresoMaximo;
                timer.Stop();
                MessageBox.Show("Error al obtener el archivo: " + ex.Message);               
                Application.Exit();
            }
        }

        private async Task GetFileCompressAppFromFtpAsync()
        {
            try
            {
                // Reiniciar la barra de progreso
                Progreso.Value = 0;

                // Construye la URL completa del archivo FTP
                string url = ftpServer + FolderPath + VersionNueva.ToString() + ".zip";

                // Crea la solicitud FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);

                // Define la ruta local donde se guardará el archivo en Documents
                string localFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MakyDG" + VersionNueva + ".zip");

                // Ejecuta la solicitud de manera normal
                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create, FileAccess.Write))
                {
                    // Copia el contenido del archivo desde el FTP al archivo local
                    await responseStream.CopyToAsync(fileStream);
                }

                lblActualizacion.Text = "Actualización descargada exitosamente";
                Actualizando = true;
                Progreso.Value = 0;
                lblActualizacion.Text = "Descomprimiendo...";
                DescomprimirArchivoZip(localFilePath, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            }
            catch (Exception ex)
            {
                lblActualizacion.Text = "Error al descargar el archivo";
                Progreso.Value = progresoMaximo;
                timer.Stop();
                MessageBox.Show("Error al descargar el archivo: " + ex.Message);
                Application.Exit();
            }
        }


        private void DescomprimirArchivoZip(string rutaZip, string rutaDestino)
        {
            try
            {
                // Descomprimir el archivo ZIP en la ruta de destino
                ZipFile.ExtractToDirectory(rutaZip, rutaDestino);
                Progreso.Value = progresoMaximo;
                lblActualizacion.Text = "Archivo descomprimido con éxito";
                //Eliminar el archivo ZIP
                System.IO.File.Delete(rutaZip);

                //Crear Acceso Directo
                CrearAccesoDirecto("MakyDG"+VersionNueva, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\MakyDG"+VersionNueva, "MakyDG.exe"));
            }
            catch (Exception ex)
            {
                timer.Stop();
                Progreso.Value = progresoMaximo;
                lblActualizacion.Text = "Error al descomprimir el archivo";
                MessageBox.Show("Error al descomprimir el archivo: " + ex.Message);
                Application.Exit();
            }
        }
        public void CrearAccesoDirecto(string nombreAccesoDirecto, string rutaAplicacion, string argumentos = "")
        {
            try
            {
                // Obtener la ruta al escritorio
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                // Crear la ruta completa para el nuevo acceso directo
                string rutaAccesoDirecto = Path.Combine(escritorio, nombreAccesoDirecto + ".lnk");

                // Eliminar el acceso directo anterior si existe
                string rutaAccesoDirectoAnterior = Path.Combine(escritorio, "MakyDG.lnk");
                if (System.IO.File.Exists(rutaAccesoDirectoAnterior))
                {
                    System.IO.File.Delete(rutaAccesoDirectoAnterior);
                }

                // Crear un nuevo objeto WshShell
                WshShell shell = new WshShell();

                // Crear un acceso directo
                IWshShortcut accesoDirecto = (IWshShortcut)shell.CreateShortcut(rutaAccesoDirecto);

                // Configurar las propiedades del acceso directo
                accesoDirecto.TargetPath = rutaAplicacion; // Ruta al ejecutable
                accesoDirecto.WorkingDirectory = Path.GetDirectoryName(rutaAplicacion); // Directorio de trabajo
                accesoDirecto.Arguments = argumentos; // Argumentos (si hay)
                accesoDirecto.Save(); // Guardar el acceso directo

                // Abrir el nuevo acceso directo
                System.Diagnostics.Process.Start(rutaAccesoDirecto);

                lblActualizacion.Text = "Acceso directo creado con éxito en el escritorio.";

                timer.Stop();
                Progreso.Value = progresoMaximo;
                Application.Exit();
            }
            catch (Exception ex)
            {
                lblActualizacion.Text = "Error al crear el acceso directo";
                timer.Stop();
                Progreso.Value = progresoMaximo;
                MessageBox.Show("Error al crear el acceso directo: " + ex.Message);
            }
        }


    }
}
