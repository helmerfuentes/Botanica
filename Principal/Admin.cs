using Entidades;
using logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormAdmin : Form
    {
        LogicaTipoPlantas LogicaTipoPlantas;
        LogicaPlanta LogicaPlanta;
        PlantaModel Planta;
        IEnumerable<TipoPlanta> tiposPlantas;

        public FormAdmin()
        {
            InitializeComponent();

            LogicaTipoPlantas = new LogicaTipoPlantas();
            LogicaPlanta = new LogicaPlanta();
            Planta = new PlantaModel();
            CargarClasificacionPlantas();
        }

        private void CargarClasificacionPlantas()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            tiposPlantas = LogicaTipoPlantas.getAll();
            foreach (TipoPlanta item in tiposPlantas)
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
                pcImagen.Image = Image.FromFile(examinar.FileName);
                Planta.Imagenes.Add(examinar.FileName);
                jlbCantidadImagenes.Text = Planta.Imagenes.Count.ToString();


            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    var nombreTipo = listBox2.Items[i].ToString();
                    var tipo = tiposPlantas.FirstOrDefault(x => x.Nombre == nombreTipo);
                    Planta.TipoPlanta.Add(tipo);
                }

                Planta.Nombre = txtnombrePlanta.Text;
                Planta.Descripcion = txtDescripcionPlanta.Text;
                try
                {
                    LogicaPlanta.AgregarPlanta(Planta);
                    MessageBox.Show("Registro Exitoso");
                    Limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.Message, "Error al agregar");
                }
            }
        }

        private void Limpiar()
        {
            this.txtDescripcionPlanta.Text = "";
            this.txtnombrePlanta.Text = "";
            this.jlbCantidadImagenes.Text = "0";
            CargarClasificacionPlantas();

        }

        private bool Validar()
        {
            if (txtnombrePlanta.Text == "" || txtnombrePlanta.Text == "Digite Nombre Planta")
            {
                MessageBox.Show("Digite Nombre Planta");
                return false;
            }
            else if (txtDescripcionPlanta.Text == "" || txtDescripcionPlanta.Text == "Descripción")
            {
                MessageBox.Show("Digite Descripción");
                return false;
            }
            else if (Planta.Imagenes.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos una Imagen");
                return false;
            }
            else if (listBox2.Items.Count == 0)
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
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                while (listBox1.SelectedItems.Count != 0)
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
            FormPrincipal form1 = new FormPrincipal();
            form1.Show();
            this.Close();
        }
    }
}
