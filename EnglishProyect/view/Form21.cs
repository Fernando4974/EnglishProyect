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
    public partial class Form21 : Form
    {
        controller.CalculoPuntuacion rr = new controller.CalculoPuntuacion();
        
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            int ptsExamen = rr.CalcularExamen();
            int ptsViaje = rr.CalcularTrip();
            int ptsBonus = rr.CalcularBonus();

            label2.Text +=" "+ ptsViaje.ToString()+" / 12";
            label3.Text +=" "+ ptsExamen.ToString() + " / 6";
            label4.Text += " + "+ptsBonus.ToString();
            label5.Text =" "+ rr.CalcularTotal(ptsExamen,ptsBonus,ptsViaje).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rr.setPtsTrip(0);
            rr.setPtsExamen(0);
            rr.setPtsBonus(0);
            rr.setPtsTotal(0);
            rr.VaciarListas();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
