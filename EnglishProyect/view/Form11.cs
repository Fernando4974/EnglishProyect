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
    public partial class Form11 : FormA
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "9" + text.textosStagesContextos[2];
        }

     
        private void botonComun_Click(object sender, EventArgs e)
        {
            //aca validas textos
            bool respuesta = false;
            string r1 = this.comboBox1.Text.ToLower();
            string r2 = this.comboBox2.Text.ToLower();
            // string r3 = this.comboBox1.Text.ToLower();
            if (r1 == "goes" && r2 == "helps")
            {
                respuesta = true;
            }
            //aca instancias
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            //aca envias resultado
            r.resultados(respuesta);
            FormA formNew = new Form12();
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
    }
}
