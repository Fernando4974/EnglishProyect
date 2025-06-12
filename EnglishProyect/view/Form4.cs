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
    public partial class Form4 : FormA
    {
        bool respuesta;
        model.Texts text = new model.Texts();
        public Form4()
        {
            
            InitializeComponent();
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            etiquetaComun.Text ="Stage: 2"+ text.textosStagesContextos[1];
            botonComun.Visible=false;
        }

       

        private void botonComun_Click(object sender, EventArgs e)
        {
            //aca validas textos
            
            string r1 =  this.comboBox1.Text.ToLower();
            string r2 = this.comboBox2.Text.ToLower();
           // string r3 = this.comboBox1.Text.ToLower();
            if (r1=="is ringing" && r2=="am waking" )
            {
                respuesta = true;
            }
            //aca instancias
            controller.CapturaDeRespuestas r= new CapturaDeRespuestas();
            //aca envias resultado
            r.resultados(respuesta);
            Form form5 = new Form5();
            form5.Show();
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
            botonComun.Visible =false;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            lblDebug.Text=respuesta.ToString();
        }

        private void lblDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
