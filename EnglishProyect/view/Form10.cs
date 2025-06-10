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
    public partial class Form10 : FormA
    {
        bool respuesta = false;
        controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "8" + text.textosStagesContextos[4];
            botonComun.Visible = false;
        }

     
        private void botonComun_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.ToLower() == "i am rewing my notes ")
            {
                respuesta = true;
            }
            r.resultados(respuesta);
            FormA formNew = new Form11();
            formNew.Show();
            this.Close();

        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = true;
                }
                botonComun.Visible = false;

            }
            label1.Text = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text + " ";
            button1.Visible = false;
            botonComun.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text + " ";
            button2.Visible = false;
            botonComun.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text + " ";
            button3.Visible = false;
            botonComun.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text + " ";
            button4.Visible = false;
            botonComun.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text + " ";
            button5.Visible = false;
            botonComun.Visible = true;
        }
    }
}
