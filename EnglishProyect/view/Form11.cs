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
        bool respuesta;

        string r1;
        string r2;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "9" + text.textosStagesContextos[2];
            botonComun.Visible = false;
        }

     
        private void botonComun_Click(object sender, EventArgs e)
        {
            //aca validas textos
           
             r1 = this.comboBox1.Text.ToLower();
             r2 = this.comboBox2.Text.ToLower();
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

        private void btnDebug_Click(object sender, EventArgs e)
        {
            lblDebug.Text=r1.ToString()+r2.ToString();
        }

        private void lblDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
