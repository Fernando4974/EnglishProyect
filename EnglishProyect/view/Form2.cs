using EnglishProyect.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProyect.view
{
    
    public partial class Form2 : Form
    {

        //contador de bonton next y back
        private static int cont = 0;
        public Boolean indice=false;
        //instanciamos el Text
        model.Texts texto = new model.Texts();

        //Selector de imagen
        string rutaImagen = Path.Combine(Application.StartupPath, "img", $"img{cont.ToString()}.png");



        public Form2()
        {
            InitializeComponent();
            this.lblTextInstructions.Text = texto.textosInstruciones[cont];
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = Image.FromFile(rutaImagen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //luego del evento cambiamos indice a true
            this.indice = true;
            //el contador valida luego suma o resta
            contadorBotones(indice);
            //asignamos el texto
            this.lblTextInstructions.Text = texto.textosInstruciones[cont] ;
            string rutaImagen = Path.Combine(Application.StartupPath, "img", $"img{cont.ToString()}.png");
            this.panel1.BackgroundImage = Image.FromFile(rutaImagen);
            
        }

        public int contadorBotones(Boolean indice) {

            if (indice)
            {
                if (cont >= 2)
                {
                    this.button1.Visible = false;
                    this.button2.Visible = true;
                }
                else
                {
                    if (cont < 0)

                    {
                        this.button2.Visible = false;
                        this.button1.Visible = true;

                    }
                    else
                    {
                        this.button2.Visible = true;
                        this.button1.Visible = true;
                        cont++;
                    }
                }               
            }
            else
            {
                if (cont <= 0)
                {
                    this.button2.Visible = false;
                    this.button1.Visible = true;
                }
                else
                {
                    this.button1.Visible = true;
                    cont--;
                }
            }
            return cont;
            
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.indice=false;
            contadorBotones(indice);
            this.lblTextInstructions.Text = texto.textosInstruciones[cont];
            string rutaImagen = Path.Combine(Application.StartupPath, "img", $"img{cont.ToString()}.png");
            this.panel1.BackgroundImage = Image.FromFile(rutaImagen);
        }

      
    }
}
