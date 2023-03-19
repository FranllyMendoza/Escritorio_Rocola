using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Net.Http;
using Newtonsoft.Json;
using Escritorio_Rocola.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace Escritorio_Rocola.registro
{
    public partial class Escritorio_reproductor : Form
    {
        private WindowsMediaPlayer player;
        public List<Canciones> listaReproduccion;
        private ObservableCollection<Canciones> _listaReproduccion = new ObservableCollection<Canciones>();
        private int indiceCancion;
        private System.Windows.Forms.Timer timer;
        
        
        public Escritorio_reproductor()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.settings.autoStart = true;
            ActualizarDatos();
        }

        private void Escritorio_reproductor_Load(object sender, EventArgs e)
        {
        //    timer.Interval = 5000; // Actualizar cada 5 segundos
        //    timer.Tick += timer_Tick;
        //    timer.Start();
        //    ActualizarDatos(); // Actualiza los datos del DataGridView cuando se carga el formulario
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            ActualizarDatos(); // Actualiza los datos del DataGridView cada vez que se llama el temporizador
        }

        private async void ActualizarDatos()
        {

            try
            {
                // Crear una instancia de HttpClient
                HttpClient client = new HttpClient();

                // Configurar la URL de la API
                string apiUrl = "http://localhost:3000/canciones/";

                string jsonData = await client.GetStringAsync(apiUrl); // Obtener datos de la API en formato JSON

                listaReproduccion = JsonConvert.DeserializeObject<List<Canciones>>(jsonData); // Convertir JSON a una lista de objetos DataModel
                dataGridView_Canciones.DataSource = listaReproduccion;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listaReproduccion == null || listaReproduccion.Count == 0)
            {
                MessageBox.Show("No hay canciones en la lista de reproducción.");
                return;
            }

            player.URL = listaReproduccion[0].ruta;
            player.controls.play();

        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }



        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaReproduccion == null || listaReproduccion.Count == 0)
            {
                MessageBox.Show("No hay canciones en la lista de reproducción.");
                return;
            }

            if (indiceCancion > 0)
            {
                indiceCancion--;
            }
            else
            {
                indiceCancion = listaReproduccion.Count - 1;
            }

            player.URL = listaReproduccion[indiceCancion].ruta;
            player.controls.play();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaReproduccion == null || listaReproduccion.Count == 0)
            {
                MessageBox.Show("No hay canciones en la lista de reproducción.");
                return;
            }

            if (indiceCancion < listaReproduccion.Count - 1)
            {
                indiceCancion++;
            }
            else
            {
                indiceCancion = 0;
            }

            player.URL = listaReproduccion[indiceCancion].ruta;
            player.controls.play();
        }











    }
}
