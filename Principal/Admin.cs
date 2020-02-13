using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using System.IO;

namespace Principal
{
    public partial class e : Form
    {
        LogicaTipoPlantas LogicaTipoPlantas;
        LogicaPlanta LogicaPlanta;
        Planta Planta;
      
        public e()
        {
            InitializeComponent();

            LogicaTipoPlantas = new LogicaTipoPlantas();
            LogicaPlanta = new LogicaPlanta();
            Planta = new Planta();
            cargarClasificacionPlantas();
        }

        private void cargarClasificacionPlantas()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (TipoPlanta item in LogicaTipoPlantas.getAll())
            {
                listBox1.Items.Add(item.Nombre);
            }
            
        }

        private void chbvuelnerarias_OnChange(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "image files |*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.OK)
            {
                
                pcImagen.Image= Image.FromFile(examinar.FileName);
                byte[] imagenConvertida = File.ReadAllBytes(examinar.FileName);
                Planta.Imagenes.Add(imagenConvertida);
                jlbCantidadImagenes.Text = Planta.Imagenes.Count.ToString();
                

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                    Planta.TipoPlanta.Add(new TipoPlanta(0, "", listBox2.Items[i].ToString()));

                Planta.Nombre = txtnombrePlanta.Text;
                Planta.Descripcion = txtDescripcionPlanta.Text;
                if (LogicaPlanta.addPlanta(Planta))
                {
                    MessageBox.Show("Registro Exitoso");
                    limpiar();
                    Planta = new Planta();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }

                
     
            


            }
        }

        private void limpiar()
        {
            this.txtDescripcionPlanta.Text = "";
            this.txtnombrePlanta.Text = "";
            this.jlbCantidadImagenes.Text = "0";
            cargarClasificacionPlantas();

        }

        private bool validar()
        {
            if (txtnombrePlanta.Text == "" || txtnombrePlanta.Text == "Digite Nombre Planta")
            {
                MessageBox.Show("Digite Nombre Planta");
                return false;
            }else if(txtDescripcionPlanta.Text=="" || txtDescripcionPlanta.Text== "Descripción")
            {
                MessageBox.Show("Digite Descripción");
                return false;
            }else if (Planta.Imagenes.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos una Imagen");
                return false;
            }else if (listBox2.Items.Count==0)
            {
                MessageBox.Show("Selecionar al menos una clasificación");
                return false;
            }
            return true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex!=-1)
            {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                while (listBox1.SelectedItems.Count!=0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                while (listBox2.SelectedItems.Count != 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
