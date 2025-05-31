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
    public partial class Form17 : FormA
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form18();
            fomrNew.Show();
            this.Close();
        }
    }
}
