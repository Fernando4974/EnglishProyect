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
    public partial class Form5 : FormA
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void botonComun_Click(object sender, EventArgs e)
        {
            try
            {
                Form form6 = new Form6();
                form6.Show();
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
    }
}
