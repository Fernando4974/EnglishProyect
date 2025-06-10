using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProyect.model
{
    public partial class FormE : Form
    {
        protected Panel panel;
        protected Button botonComun;
        protected Button botonComunChange;

        public FormE()
        {
           
            panel = new Panel();
            panel.Size = new Size(770, 838);
            this.Controls.Add(panel);
            this.Size = new System.Drawing.Size(770, 838);
           // this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;


          

        }

        private void FormE_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormE
            // 
            this.ClientSize = new System.Drawing.Size(752, 899);
            this.Name = "FormE";
            this.Load += new System.EventHandler(this.FormE_Load);
            this.ResumeLayout(false);

        }

        private void FormE_Load_1(object sender, EventArgs e)
        {

        }
    }
}
