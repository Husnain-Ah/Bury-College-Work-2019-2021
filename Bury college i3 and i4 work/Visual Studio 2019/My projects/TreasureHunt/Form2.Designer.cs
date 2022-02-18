namespace TreasureHunt
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ClickLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(277, 58);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(248, 49);
            this.TextBox1.TabIndex = 19;
            this.TextBox1.Text = "The treasure has been hidden behind one of the spaces below. Find the treasure be" +
    "fore the time runs out. Click on a space to search for treasure.";
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(461, 321);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(73, 72);
            this.Button9.TabIndex = 18;
            this.Button9.Text = "Button9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(364, 321);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(73, 72);
            this.Button8.TabIndex = 17;
            this.Button8.Text = "Button8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(266, 321);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(73, 72);
            this.Button7.TabIndex = 16;
            this.Button7.Text = "Button7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(461, 225);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(73, 72);
            this.Button6.TabIndex = 15;
            this.Button6.Text = "Button6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(364, 225);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(73, 72);
            this.Button5.TabIndex = 14;
            this.Button5.Text = "Button5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(266, 225);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(73, 72);
            this.Button4.TabIndex = 13;
            this.Button4.Text = "Button4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(461, 131);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(73, 72);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Button3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(364, 131);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(73, 72);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(266, 131);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(73, 72);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ClickLabel
            // 
            this.ClickLabel.AutoSize = true;
            this.ClickLabel.Location = new System.Drawing.Point(263, 420);
            this.ClickLabel.Name = "ClickLabel";
            this.ClickLabel.Size = new System.Drawing.Size(35, 13);
            this.ClickLabel.TabIndex = 20;
            this.ClickLabel.Text = "Clicks";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(504, 420);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(30, 13);
            this.TimeLabel.TabIndex = 21;
            this.TimeLabel.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ClickLabel);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label ClickLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}