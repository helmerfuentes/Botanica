using Dato;
using Entidades;
using Entidades.Enums;
using logica;
using Principal.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Principal.FormularioJuego.ParejaCartas
{
    public partial class JuegoPareja : Form
    {
        private List<PlantaModel> plantaModels;
        private readonly LogicaPlanta logicaPlanta;
        private ControlCarta primeraCartaSeleccionada;
        private Image imagenCartaOculta;
        private Timer timerOcultarCartas; // Temporizador para ocultar cartas
        private const int tiempoVisible = 1000; // Tiempo en milisegundos para mostrar las cartas antes de ocultarlas
        int puntajes = 0;
        bool inicioJuego = false;
        const int PUNTAJE_MAXIMO = 2;
        private Timer timer;
        private DateTime inicioJuegoDate;

        public JuegoPareja()
        {
            InitializeComponent();
            logicaPlanta = new LogicaPlanta();
            plantaModels = logicaPlanta.GetPlantasParaJuego1Vs1().ToList();
            imagenCartaOculta = Resources.RIK;
            Resize += TuFormulario_Resize;
            // Configurar el temporizador
            timer = new Timer();
            timer.Interval = 1000; // 1000 milisegundos = 1 segundo
            timer.Tick += Timer_Tick;
        }

        public void IniciarJuego()
        {
            var random = new Random();
            var plantasCartas = plantaModels;
            plantasCartas = plantasCartas.Concat(plantaModels).OrderBy(x => random.Next()).ToList();
            // Crear las cartas en el TableLayoutPanel
            foreach (var planta in plantasCartas)
            {
                ControlCarta controlCarta = new ControlCarta
                {
                    Imagen = imagenCartaOculta,
                    Tag = planta
                };

                controlCarta.Click += ControlCarta_Click;
                layoutPanel.Controls.Add(controlCarta);
            }

            timerOcultarCartas = new Timer();
            timerOcultarCartas.Interval = tiempoVisible;
            timerOcultarCartas.Tick += TimerOcultarCartas_Tick;

        }

        public static Image BytesAImagen(byte[] bytesDeImagen)
        {
            using (MemoryStream ms = new MemoryStream(bytesDeImagen))
            {
                Image imagen = Image.FromStream(ms);
                return imagen;
            }
        }

        private void ControlCarta_Click(object sender, EventArgs e)
        {
            ControlCarta cartaClickeada = (ControlCarta)sender;

            if (cartaClickeada.Imagen == imagenCartaOculta)
            {
                cartaClickeada.Imagen = BytesAImagen(((PlantaModel)cartaClickeada.Tag).ImagenesConvertidas1[0]);

                if (primeraCartaSeleccionada == null)
                {
                    primeraCartaSeleccionada = cartaClickeada;
                }
                else
                {
                    if (cartaClickeada.SonIguales(primeraCartaSeleccionada))
                    {
                        // Si las cartas son iguales, dejarlas visibles
                        puntajes++;
                        jlbRecord.Text = "Puntaje :" + (puntajes * 1000).ToString();
                        cartaClickeada.Enabled = false;
                        primeraCartaSeleccionada.Enabled = false;
                        primeraCartaSeleccionada = null;

                        if (puntajes == PUNTAJE_MAXIMO)
                        {
							var puntajeDatos = new PuntajeDatos();

                            var timer = this.timer;
                            var a = jllTiempo.Text;

							puntajeDatos.GuardarPuntaje(txtNombre.Text, "0", TiposDeJuegoEnum.Memoria, jllTiempo.Text);
							timer.Stop();
                            btnReiniciar.Text = "Volver a Jugar";
                            MessageBox.Show("Felicidades has ganado");
                        }
                    }
                    else
                    {
                        // Si las cartas no son iguales, ocultarlas nuevamente después de un breve período de tiempo
                        timerOcultarCartas.Start();
                    }
                }
            }
        }

        private void TimerOcultarCartas_Tick(object sender, EventArgs e)
        {
            try
            {

                timerOcultarCartas.Stop();

                // Ocultar las cartas seleccionadas
                primeraCartaSeleccionada.Imagen = imagenCartaOculta;
                primeraCartaSeleccionada.Enabled = true;

                foreach (Control control in layoutPanel.Controls)
                {
                    if (control is ControlCarta carta && carta != primeraCartaSeleccionada)
                    {
                        if (carta.Imagen != imagenCartaOculta)
                        {
                            carta.Imagen = imagenCartaOculta;
                            carta.Enabled = true;
                        }
                    }
                }

                primeraCartaSeleccionada = null;
            }
            catch { }
        }

        private void TuFormulario_Resize(object sender, EventArgs e)
        {
            // Calcula el nuevo ancho del TableLayoutPanel como el 80% del ancho de la ventana del formulario
            int nuevoAncho = (int)(Width * 0.8);

            // Establece el nuevo ancho del TableLayoutPanel
            layoutPanel.Width = nuevoAncho;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Digite Nombre y Apellido" || txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Digite nombre y apellido");
            }
            else
            {
                if (!inicioJuego)
                {
                    inicioJuegoDate = DateTime.Now;
                    timer.Start();
                    txtNombre.Enabled = false;
                    btnReiniciar.Text = "Jugando";
                    inicioJuego = true;
                    IniciarJuego();
                }
            }

            if (btnReiniciar.Text == "Volver a Jugar")
            {
                jlbRecord.Text = "Puntaje: 0";
                layoutPanel.Controls.Clear();
                puntajes = 0;
                btnReiniciar.Text = "Jugando";
                inicioJuegoDate = DateTime.Now;
                timer.Start();
                IniciarJuego();
            }
        }

        private void jlbMensaje_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Calcular el tiempo transcurrido desde el inicio del juego
            TimeSpan tiempoTranscurrido = DateTime.Now - inicioJuegoDate;

            // Actualizar el texto del Label con el tiempo transcurrido
            jllTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }

		private void btnPuntaje_Click(object sender, EventArgs e)
		{
			PuntajeDeJuegos puntaje = new PuntajeDeJuegos(Entidades.Enums.TiposDeJuegoEnum.Memoria);
			puntaje.ShowDialog();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			MenuJuegos mj = new MenuJuegos();
			mj.Show();
			this.Hide();
		}
	}
}
