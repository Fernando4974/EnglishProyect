namespace EnglishProyect.view
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonComunChange
            // 
            this.botonComunChange.Click += new System.EventHandler(this.botonComunChange_Click);
            // 
            // botonComun
            // 
            this.botonComun.Click += new System.EventHandler(this.botonComun_Click);
            // 
            // etiquetaContexto
            // 
            this.etiquetaContexto.Size = new System.Drawing.Size(798, 174);
            this.etiquetaContexto.Text = "You enter the room and sit at the\r\nfront. Which option best describes\r\nyour curre" +
    "nt situation?";
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::EnglishProyect.Properties.Resources.nini;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(55, 526);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(597, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "I sat at the front.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(597, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "I sit at the front.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(597, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "I am sitting at the front.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::EnglishProyect.Properties.Resources.back_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 919);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form12";
            //  this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.Controls.SetChildIndex(this.botonComunChange, 0);
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.etiquetaContexto, 0);
            this.Controls.SetChildIndex(this.etiquetaComun, 0);
            this.Controls.SetChildIndex(this.botonComun, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}