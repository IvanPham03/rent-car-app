﻿namespace RentCarApp.GUI
{
    partial class fHome
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 71);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(77, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 39);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(17, 36);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Rents";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(183, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 71);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(137, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 39);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 36);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 1;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(11, 10);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "Rents in pending";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(419, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 71);
            panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(95, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 39);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(17, 36);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(11, 10);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 0;
            label6.Text = "Customers";
            // 
            // fHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 547);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "fHome";
            Text = "fHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
    }
}