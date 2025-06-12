using EnglishProyect.controller;
using EnglishProyect.model;
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
    public partial class Form6 : FormA
    {
        bool respuesta = false;
        Texts text = new Texts();
        controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
        public Form6()
        { 
            InitializeComponent();
            //this.Load+=Form6_Load;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            etiquetaComun.Text += "4"+text.textosStagesContextos[2];

            back_load();
          
           // etiquetaContexto.Text += r.mostrarR();
            botonComun.Visible = false;

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            if (this.label1.Text== "- I am reviewing my notes ")
            {                       
                respuesta = true;
            }
            r.resultados(respuesta);
            FormA form7 = new Form7();
            form7.Show();
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
            label1.Text = "- ";
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

        private void btnDebug_Click(object sender, EventArgs e)
        {
            lblDebug.Text=label1.Text+"|";
            textBox1.Text = label1.Text + "|";
        }

        private void lblDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
