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
    public partial class Form7 : FormA
    {
        public bool respuesta= false;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "5" + text.textosStagesContextos[0];
            this.botonComun.Visible = false;
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            r.resultados(respuesta);
            FormA form8 = new Form8();
            form8.Show();
            this.Close();   
        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = false;
            button2.Visible = true;
            button1.Visible = true;
            button3.Visible = true;

            respuesta = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = true;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = false;
            button1.Visible = false;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = false;
            button2.Visible = false;
            button1.Visible = false;
        }

       
    }
}
