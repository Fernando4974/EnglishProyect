namespace EnglishProyect.view
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNextQuery = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishProyect.Properties.Resources.img0;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(979, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 1031);
            this.panel1.TabIndex = 0;
            // 
            // lblStage1
            // 
            this.lblStage1.AutoSize = true;
            this.lblStage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStage1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStage1.Location = new System.Drawing.Point(57, 18);
            this.lblStage1.Name = "lblStage1";
            this.lblStage1.Size = new System.Drawing.Size(663, 79);
            this.lblStage1.TabIndex = 1;
            this.lblStage1.Text = "Stage 1: Past Simple.";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuery.Location = new System.Drawing.Point(63, 132);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(679, 176);
            this.lblQuery.TabIndex = 2;
            this.lblQuery.Text = "\"Last night you set your alarm to go off \r\nat seven in the morning\".\r\n\r\nSelect th" +
    "e action you performed:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(796, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "I set the alarm to go off at 7 a.m.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(71, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(796, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "I set the alarm to go off at 8 a.m.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(71, 548);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(796, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "I was setting the alarm to go off at 7 a.m. ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNextQuery
            // 
            this.btnNextQuery.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNextQuery.Enabled = false;
            this.btnNextQuery.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuery.Location = new System.Drawing.Point(477, 879);
            this.btnNextQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextQuery.Name = "btnNextQuery";
            this.btnNextQuery.Size = new System.Drawing.Size(443, 86);
            this.btnNextQuery.TabIndex = 6;
            this.btnNextQuery.Text = "Next";
            this.btnNextQuery.UseVisualStyleBackColor = false;
            this.btnNextQuery.Click += new System.EventHandler(this.btnNextQuery_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(15, 879);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(443, 86);
            this.button4.TabIndex = 7;
            this.button4.Text = "Change answer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(778, 97);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(11, 16);
            this.lblDebug.TabIndex = 8;
            this.lblDebug.Text = "-";
            this.lblDebug.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnglishProyect.Properties.Resources.back_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnNextQuery);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.lblStage1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNextQuery;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDebug;
    }
}