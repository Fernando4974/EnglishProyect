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
    public partial class Form12 : FormA
    {
        bool respuesta=false;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "10" + text.textosStagesContextos[1];
            botonComun.Visible = false;
            botonComun.Enabled = true;
        }

        private void botonComun_Click(object sender, EventArgs e)
        {

            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            r.resultados(respuesta);
            FormA formNew = new Form13();
            formNew.Show();
            this.Close();

        }


      

        private void button1_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = true;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = false;
            button1.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
            respuesta = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {
            this.botonComun.Visible = false;
            button2.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;

            respuesta = false;
        }

       
    }
}
