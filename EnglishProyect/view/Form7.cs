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
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA form8 = new Form8();
            form8.Show();
            this.Close();   
        }

        private void botonComunChange_Click(object sender, EventArgs e)
        {

        }
    }
}
