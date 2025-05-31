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
    public partial class Form16 : FormA
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form17();
            fomrNew.Show();
            this.Close();
        }
    }
}
