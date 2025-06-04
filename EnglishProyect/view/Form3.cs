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
    public partial class Form3 : Form
    {

        public bool respuesta;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lblStage1.BackColor = Color.Transparent;
            this.lblQuery.BackColor = Color.Transparent;
        }

        private void btnNextQuery_Click(object sender, EventArgs e)
        {

            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            r.resultados(respuesta);
            Form form4 = new Form4();
            form4.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnNextQuery.Enabled = true;
            respuesta= true;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnNextQuery.Enabled = true;
            respuesta = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.btnNextQuery.Enabled = true;
            respuesta = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.btnNextQuery.Enabled=false;
            respuesta = false;
        }
    }
}
