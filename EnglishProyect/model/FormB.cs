using EnglishProyect.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProyect.model
{
    public partial class FormB : FormA
    {
        private string ruta = Path.Combine(Application.StartupPath, "img", "bocina.jpg");
        protected Button audio;

        public FormB()
        {
            audio = new Button();
            audio.BackgroundImage = Image.FromFile(ruta);
            audio.Location = new Point(360,360);
            this.Controls.Add(audio);
            InitializeComponent();

        }

        private void FormB_Load(object sender, EventArgs e)
        {

        }
    }
}
