using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Media;
using EnglishProyect.model;
using System.ComponentModel;

namespace EnglishProyect.view
{
    public class FormA : Form
    {
       
        static controller.CapturaDeRespuestas capturaGlobal = new controller.CapturaDeRespuestas();

        protected Button botonComunChange;
        protected Button botonComun;
        protected Label etiquetaComun;
        protected Label etiquetaContexto;
        protected Panel panel;


        //-----------------------------NICOLAS---------------------------------AUDIOS

        static string ruta1 = Path.Combine(Application.StartupPath, "sound", "ruta1.wav");
        SoundPlayer SoundPlayer_1 = new SoundPlayer(ruta1);
        static string ruta2 = Path.Combine(Application.StartupPath, "sound", "correctaForm8.wav");
        SoundPlayer SoundPlayer_2 = new SoundPlayer(ruta2);
        static string ruta3 = Path.Combine(Application.StartupPath, "sound", "correctaForm13.wav");
        SoundPlayer SoundPlayer_3 = new SoundPlayer(ruta3);
        static string ruta4 = Path.Combine(Application.StartupPath, "sound", "audio3.wav");
        SoundPlayer SoundPlayer_4 = new SoundPlayer(ruta4);
        static string ruta5 = Path.Combine(Application.StartupPath, "sound", "audio4.wav");
        SoundPlayer SoundPlayer_5 = new SoundPlayer(ruta5);
        static string ruta6 = Path.Combine(Application.StartupPath, "sound", "audio5.wav");
        SoundPlayer SoundPlayer_6 = new SoundPlayer(ruta6);
        public FormA()
        {
            this.Text = " On The Way To Your Exam";
          
           // string ruta = Path.Combine(Application.StartupPath, "img", "back_5.jpg");
            //this.BackgroundImage = Image.FromFile(ruta);
            this.Size = new System.Drawing.Size(1919, 1080);
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Fondo común
            this.BackColor = Color.LightBlue;

            // Botón común
            botonComun = new Button();
            botonComun.Font=new Font( "MV Boli",36,FontStyle.Bold | FontStyle.Italic);
            botonComun.Text = "Next";
            botonComun.BackColor = Color.Green;
            botonComun.Size = new System.Drawing.Size(332, 70);
            botonComun.Location = new Point(380, 729 );
            //botonComun.Enabled= false;
            this.Controls.Add(botonComun);

            // Botón común change
            botonComunChange = new Button();
            botonComunChange.Font = new Font("MV Boli", 26, FontStyle.Bold | FontStyle.Italic);
            botonComunChange.Text = "Change anwser";
            botonComunChange.BackColor = Color.DarkRed;
            botonComunChange.Size = new System.Drawing.Size(332, 70);
            botonComunChange.Location = new Point(38, 729);
            this.Controls.Add(botonComunChange);

            // Label stage
            etiquetaComun = new Label();
            etiquetaComun.Font = new Font("MV boli", 36, FontStyle.Bold | FontStyle.Italic);
            etiquetaComun.BackColor = Color.Transparent;
            etiquetaComun.Text = "Stage :";
            etiquetaComun.Location = new Point(10,10);
            etiquetaComun.AutoSize= true;
           // etiquetaComun.Size = new System.Drawing.Size(332, 70);
            etiquetaComun.ForeColor = Color.White;
            this.Controls.Add(etiquetaComun);
            // Label contexto
            etiquetaContexto = new Label();
            etiquetaContexto.Font = new Font("MV boli", 26, FontStyle.Bold | FontStyle.Italic);
            etiquetaContexto.BackColor = Color.Transparent;
            etiquetaContexto.Text = "Error al obtener el texto !!! \nError al obtener el texto !!! \nError al obtener el texto !!! ";
            etiquetaContexto.Location = new Point(10, 100);
            etiquetaContexto.AutoSize = true;
            //etiquetaComun.Size = new System.Drawing.Size(332, 70);
            etiquetaContexto.ForeColor = Color.White;
            this.Controls.Add(etiquetaContexto);
            this.Text = " On The Way To Your Exam";
            //Panel de foto

            panel = new Panel();
            panel.Location = new Point(730, 0);
            panel.Size= new Size(770,838);
            this.Controls.Add(panel);
            back_load();

        }
                    
        //public void botonComun_Click() {


        //    this.Close();
        //}
       
            
        
        private void InitializeComponent()
        {

           
               // string ruta = Path.Combine(Application.StartupPath, "img", "back_5.jpg");
                //this.BackgroundImage = Image.FromFile(ruta);
                this.BackgroundImageLayout= ImageLayout.Stretch;
            
            this.SuspendLayout();
            // 
            // FormA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormA";
            this.Load += new System.EventHandler(this.FormA_Load_1);
            this.ResumeLayout(false);
            this.botonComun.Visible = false;

        }

        //-----------------------------NICOLAS---------------------------------funcion cambiar fondo y letra de labels
        public void back_load()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                }
            }
        }
        private void FormA_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                }
            }
        }

        //--------------------NICOLAS------------------------------------funcion reproducir audio de botones, faltan 3l 4 5 y 6
        public void PlayBtn1()
        {
            //this.Load += new System.EventHandler(this.FormA_Load);
            //this.ResumeLayout(false);
            SoundPlayer_1.Play();
        }
        public void PlayBtn2()
        {
            SoundPlayer_2.Play();
        }
        public void PlayBtn3()
        {
            SoundPlayer_3.Play();
        }
        public void PlayBtn4()
        {
            SoundPlayer_4.Play();
        }
        public void PlayBtn5()
        {
            SoundPlayer_5.Play();
        }
        public void PlayBtn6()
        {
            SoundPlayer_6.Play();
        }

        private void FormA_Load_1(object sender, EventArgs e)
        {

        }
    }
}
