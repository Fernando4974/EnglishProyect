using EnglishProyect.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProyect.view
{
    public partial class Form8 : FormA
    {
        bool respuesta = false;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "6" + text.textosStagesContextos[3];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlayBtn1();
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }
            }
            button1.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            PlayBtn6();
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }
            }
            button5.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlayBtn2();
            respuesta = true;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }
            }
            button6.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayBtn5();
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }
            }
            button4.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayBtn4();
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }

            }
            button2.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            PlayBtn3();
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = false;

                }

            }
            button3.Visible = true;
            botonComun.Visible = true;
            botonComunChange.Visible = true;
        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {
            respuesta = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = true;

                }

            }
            botonComun.Visible = false;
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            r.resultados(respuesta);
            try
            {
                FormA form9 = new Form9();
                form9.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Form6: " + ex.Message);
            }
        }

        private void etiquetaContexto_Click(object sender, EventArgs e)
        {

        }
    }
}
