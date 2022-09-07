namespace NumberGuessing_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbutton = new System.Windows.Forms.Button();
            this.lblquestion = new System.Windows.Forms.Label();
            this.lblguesstimes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(304, 249);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(204, 85);
            this.checkbutton.TabIndex = 0;
            this.checkbutton.Text = "Check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Location = new System.Drawing.Point(145, 78);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(218, 20);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "choose a number between 0-10";
            this.lblquestion.Click += new System.EventHandler(this.lblquestion_Click);
            // 
            // lblguesstimes
            // 
            this.lblguesstimes.AutoSize = true;
            this.lblguesstimes.Location = new System.Drawing.Point(121, 350);
            this.lblguesstimes.Name = "lblguesstimes";
            this.lblguesstimes.Size = new System.Drawing.Size(126, 20);
            this.lblguesstimes.TabIndex = 2;
            this.lblguesstimes.Text = "you guess 0 times";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblguesstimes);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.checkbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkbutton;
        private Label lblquestion;
        private Label lblguesstimes;
        private TextBox textBox1;
    }
}