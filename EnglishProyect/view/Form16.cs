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
    public partial class Form16 : FormE
    {
        string r1 = "";
        string r2 = "";
        bool respuesta = false;
        bool bonus = false;
        controller.CapturaDeRespuestas r = new controller.CapturaDeRespuestas();    
        public Form16()
        {
            InitializeComponent();
        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
       
      

        private void Form16_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            r1 = comboBox1.Text;
            if (r1.ToLower() == "is going to rain")
            {
                bonus = true;

            }
            r.resultadosBonus(bonus);
            r.resultados(respuesta);
            FormE form = new Form17();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            respuesta = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            respuesta = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            respuesta = false;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            respuesta = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
        }

        private void labelR_Click(object sender, EventArgs e)
        {

        }
    }
}
