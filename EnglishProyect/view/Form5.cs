using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishProyect.controller;
using EnglishProyect.model;

namespace EnglishProyect.view
{
    public partial class Form5 : FormA
    {
        
        public Form5()
        {
            InitializeComponent();
            //this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            model.Texts objModel = new model.Texts();
            etiquetaComun.Text += "3"+objModel.textosStagesContextos[3];
            //aca puedes ver los resultados
            controller.CapturaDeRespuestas r = new CapturaDeRespuestas();
            etiquetaContexto.Text += r.mostrarR();
        }
        private void botonComun_Click(object sender, EventArgs e)
        {
            try
            {
                FormA form6 = new Form6();
                form6.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Form6: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayBtn1();
        }

        private void etiquetaContexto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
