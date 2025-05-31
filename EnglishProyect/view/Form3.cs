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
            Form form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
