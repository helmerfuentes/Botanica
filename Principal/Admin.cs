using Entidades;
using logica;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormAdmin : Form
    {
        LogicaTipoPlantas LogicaTipoPlantas;
        LogicaPlanta LogicaPlanta;
        Planta Planta;
        string url;

        public FormAdmin()
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

        private int SubirArchivo()
        {

            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://127.0.0.1/" + Path.GetFileName(url));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("usuario", "helmer");
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = true;
            FileStream stream = File.OpenRead(url);
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Flush();
            reqStream.Close();
            return 1;
        }

        public void prueba()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                pcImagen.ImageLocation = url;
                if (SubirArchivo() == 1)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("error");
                }

            }

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
                    Planta.TipoPlanta.Add(new TipoPlanta(0, "", listBox2.Items[i].ToString()));


                Planta.Nombre = txtnombrePlanta.Text;
                Planta.Descripcion = txtDescripcionPlanta.Text;
                if (LogicaPlanta.AgregarPlanta(Planta))
                {
                    MessageBox.Show("Registro Exitoso");
                    Limpiar();
                    Planta = new Planta();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }






            }
        }

        private void Limpiar()
        {
            this.txtDescripcionPlanta.Text = "";
            this.txtnombrePlanta.Text = "";
            this.jlbCantidadImagenes.Text = "0";
            cargarClasificacionPlantas();

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (SubirArchivo() == 1)
            {
                MessageBox.Show("imagen subida");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
