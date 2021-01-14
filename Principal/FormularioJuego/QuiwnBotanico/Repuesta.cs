﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.FormularioJuego.QuiwnBotanico
{
    public partial class Repuesta : Form
    {
        logica.LogicaPlanta LogicaPlanta;
        logica.LogicaTipoPlantas logicaTipoPlantas;
        private int respuesta = -1;
        private int preguntaNumero = -1;
        private string nombre = "",sRespuesta;

        public Repuesta(string nombre, int cual)
        {
            InitializeComponent();
            this.Visible = true;
            this.nombre = nombre;
            preguntaNumero = cual;
            cargarPregunta();
        }

        private void Repuesta_Load(object sender, EventArgs e)
        {

        }
        private void cargarPregunta()
        {
            LogicaPlanta = new logica.LogicaPlanta();
            logicaTipoPlantas = new logica.LogicaTipoPlantas();
            Random rando = new Random();
            int idPlanta = rando.Next(1, LogicaPlanta.NumeroPlantas());
          Planta planta=  LogicaPlanta.getPlantaId(idPlanta.ToString());
            label2.Text = planta.Nombre + ".";
            picImagen.Image = byteArrayToImage(planta.Imagenes[rando.Next(0, planta.Imagenes.Count-1)]);
            List<TipoPlanta> noLista = logicaTipoPlantas.getNoTipo(idPlanta);
            //$$$$PREGUNTA ERRONEAS
            this.respuesta = rando.Next(4);
            sRespuesta = planta.TipoPlanta[rando.Next(0, (planta.TipoPlanta.Count - 1))].Nombre;
            for (int i = 0; i < 4; i++)
            {
                var numAletorio = rando.Next(0, noLista.Count - 1);
                switch (i)
                {
                    case 0:
                        b1.ButtonText = noLista[numAletorio].Nombre;
                        break;
                    case 1:
                        b2.ButtonText = noLista[numAletorio].Nombre;
                        break;
                    case 2:
                        b3.ButtonText = noLista[numAletorio].Nombre;
                        break;
                    case 3:
                        b4.ButtonText = noLista[numAletorio].Nombre;
                        break;
                }
            }
            
            switch (respuesta)
            {
                case 0:
                    b1.ButtonText = sRespuesta;
                    break;
                case 1:
                    b2.ButtonText = sRespuesta;
                    break;
                case 2:
                    b3.ButtonText = sRespuesta;
                    break;
                case 3:
                    b4.ButtonText = sRespuesta;
                    break;
            }


        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuThinButton2 cerrar = sender as Bunifu.Framework.UI.BunifuThinButton2;
            int boton = int.Parse(cerrar.Name[1] + "");

            if (respuesta == (boton - 1))
            {
                Pregunta pre = new Pregunta(this.nombre, this.preguntaNumero + 1);
                this.Close();
            }
            else
            {
                MessageBox.Show("perdio, La respuesta es=>\n\t" + sRespuesta, label2.Text);
                this.Close();
                Inicio inicio = new Inicio();
            }
        }
    }
}
