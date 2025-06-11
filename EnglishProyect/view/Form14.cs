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
    public partial class Form14 : FormA
    {
        controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "12" + text.textosStagesContextos[4];
            botonComun.Visible = false;
            
           // etiquetaContexto.Text+= r.mostrarR();
        }

     
        private void botonComun_Click(object sender, EventArgs e)
        {
            //aca validas textos
            bool respuesta = false;
            string r1 = this.comboBox1.Text.ToLower();
            string r2 = this.comboBox2.Text.ToLower();
            // string r3 = this.comboBox1.Text.ToLower();
            if (r1 == "has" && r2 == "started")
            {
                respuesta = true;
            }
            //aca instancias
           
            //aca envias resultado
            r.resultados(respuesta);
            FormE formNew = new Form15();
            formNew.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.botonComun.Visible = true;
        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            botonComun.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
