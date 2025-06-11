using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishProyect.controller;
using EnglishProyect.model;

namespace EnglishProyect.view
{
    public partial class Form5 : FormA
    {
        public bool respuesta = false;
        
        public Form5()
        {
            InitializeComponent();
            //this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            model.Texts objModel = new model.Texts();
            etiquetaComun.Text += "3"+objModel.textosStagesContextos[3];
            //aca puedes ver los resultados
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            //etiquetaContexto.Text += r.mostrarR();
            botonComun.Enabled = true;
            botonComun.Visible = false;
        }
        private void botonComun_Click(object sender, EventArgs e)
        {
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            r.resultados(respuesta);
            try
            {
                FormA form6 = new Form6();
                form6.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Form6: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayBtn1();
            respuesta=true;
            foreach (Control control  in this.Controls)
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

        private void etiquetaContexto_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
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
            respuesta = false;
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

            }botonComun.Visible = false;
            
        }
    }
}
