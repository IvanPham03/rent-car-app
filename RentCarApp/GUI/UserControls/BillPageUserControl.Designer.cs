using sun.awt;

namespace RentCarApp.GUI.UserControls
{
    partial class BillPageUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            selectedBillPanel = new Panel();
            label9 = new Label();
            billDetailsLabel = new Label();
            billAmountLabel = new Label();
            billDateLabel = new Label();
            billRentDateEndLabel = new Label();
            billRentDateStartLabel = new Label();
            billManagedByLabel = new Label();
            billCarLabel = new Label();
            billNumLabel = new Label();
            billRentIdLabel = new Label();
            billClientLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            label4 = new Label();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            label10 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            billNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            billBindingSource = new BindingSource(components);
            panel4 = new Panel();
            panel3.SuspendLayout();
            selectedBillPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1392, 154);
            panel3.TabIndex = 2;
            // 
            // selectedBillPanel
            // 
            selectedBillPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectedBillPanel.BackColor = SystemColors.ButtonFace;
            selectedBillPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedBillPanel.Controls.Add(label9);
            selectedBillPanel.Controls.Add(billDetailsLabel);
            selectedBillPanel.Controls.Add(billAmountLabel);
            selectedBillPanel.Controls.Add(billDateLabel);
            selectedBillPanel.Controls.Add(billRentDateEndLabel);
            selectedBillPanel.Controls.Add(billRentDateStartLabel);
            selectedBillPanel.Controls.Add(billManagedByLabel);
            selectedBillPanel.Controls.Add(billCarLabel);
            selectedBillPanel.Controls.Add(billNumLabel);
            selectedBillPanel.Controls.Add(billRentIdLabel);
            selectedBillPanel.Controls.Add(billClientLabel);
            selectedBillPanel.Controls.Add(label3);
            selectedBillPanel.Controls.Add(label2);
            selectedBillPanel.Controls.Add(label14);
            selectedBillPanel.Controls.Add(label4);
            selectedBillPanel.Controls.Add(label12);
            selectedBillPanel.Controls.Add(label11);
            selectedBillPanel.Controls.Add(label1);
            selectedBillPanel.Controls.Add(label10);
            selectedBillPanel.Controls.Add(label5);
            selectedBillPanel.Location = new Point(21, 46);
            selectedBillPanel.Margin = new Padding(4, 5, 4, 5);
            selectedBillPanel.MinimumSize = new Size(615, 682);
            selectedBillPanel.Name = "selectedBillPanel";
            selectedBillPanel.Size = new Size(615, 694);
            selectedBillPanel.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(460, 478);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 26;
            label9.Text = "VNĐ";
            // 
            // billDetailsLabel
            // 
            billDetailsLabel.AutoSize = true;
            billDetailsLabel.BackColor = SystemColors.Window;
            billDetailsLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billDetailsLabel.ForeColor = SystemColors.ControlDarkDark;
            billDetailsLabel.Location = new Point(248, 548);
            billDetailsLabel.Margin = new Padding(4, 0, 4, 0);
            billDetailsLabel.MinimumSize = new Size(267, 77);
            billDetailsLabel.Name = "billDetailsLabel";
            billDetailsLabel.Size = new Size(267, 77);
            billDetailsLabel.TabIndex = 21;
            // 
            // billAmountLabel
            // 
            billAmountLabel.AutoSize = true;
            billAmountLabel.BackColor = SystemColors.Window;
            billAmountLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billAmountLabel.ForeColor = SystemColors.ControlDarkDark;
            billAmountLabel.Location = new Point(248, 471);
            billAmountLabel.Margin = new Padding(4, 0, 4, 0);
            billAmountLabel.MinimumSize = new Size(200, 32);
            billAmountLabel.Name = "billAmountLabel";
            billAmountLabel.Size = new Size(200, 32);
            billAmountLabel.TabIndex = 21;
            // 
            // billDateLabel
            // 
            billDateLabel.AutoSize = true;
            billDateLabel.BackColor = SystemColors.InactiveBorder;
            billDateLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billDateLabel.ForeColor = SystemColors.ControlDarkDark;
            billDateLabel.Location = new Point(41, 651);
            billDateLabel.Margin = new Padding(4, 0, 4, 0);
            billDateLabel.MinimumSize = new Size(267, 32);
            billDateLabel.Name = "billDateLabel";
            billDateLabel.Size = new Size(267, 32);
            billDateLabel.TabIndex = 21;
            // 
            // billRentDateEndLabel
            // 
            billRentDateEndLabel.AutoSize = true;
            billRentDateEndLabel.BackColor = SystemColors.Window;
            billRentDateEndLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billRentDateEndLabel.ForeColor = SystemColors.ControlDarkDark;
            billRentDateEndLabel.Location = new Point(244, 409);
            billRentDateEndLabel.Margin = new Padding(4, 0, 4, 0);
            billRentDateEndLabel.MinimumSize = new Size(267, 32);
            billRentDateEndLabel.Name = "billRentDateEndLabel";
            billRentDateEndLabel.Size = new Size(267, 32);
            billRentDateEndLabel.TabIndex = 21;
            // 
            // billRentDateStartLabel
            // 
            billRentDateStartLabel.AutoSize = true;
            billRentDateStartLabel.BackColor = SystemColors.Window;
            billRentDateStartLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billRentDateStartLabel.ForeColor = SystemColors.ControlDarkDark;
            billRentDateStartLabel.Location = new Point(244, 346);
            billRentDateStartLabel.Margin = new Padding(4, 0, 4, 0);
            billRentDateStartLabel.MinimumSize = new Size(267, 32);
            billRentDateStartLabel.Name = "billRentDateStartLabel";
            billRentDateStartLabel.Size = new Size(267, 32);
            billRentDateStartLabel.TabIndex = 21;
            // 
            // billManagedByLabel
            // 
            billManagedByLabel.AutoSize = true;
            billManagedByLabel.BackColor = SystemColors.Window;
            billManagedByLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billManagedByLabel.ForeColor = SystemColors.ControlDarkDark;
            billManagedByLabel.Location = new Point(248, 272);
            billManagedByLabel.Margin = new Padding(4, 0, 4, 0);
            billManagedByLabel.MinimumSize = new Size(267, 32);
            billManagedByLabel.Name = "billManagedByLabel";
            billManagedByLabel.Size = new Size(267, 32);
            billManagedByLabel.TabIndex = 21;
            // 
            // billCarLabel
            // 
            billCarLabel.AutoSize = true;
            billCarLabel.BackColor = SystemColors.Window;
            billCarLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billCarLabel.ForeColor = SystemColors.ControlDarkDark;
            billCarLabel.Location = new Point(244, 209);
            billCarLabel.Margin = new Padding(4, 0, 4, 0);
            billCarLabel.MinimumSize = new Size(267, 32);
            billCarLabel.Name = "billCarLabel";
            billCarLabel.Size = new Size(267, 32);
            billCarLabel.TabIndex = 22;
            // 
            // billNumLabel
            // 
            billNumLabel.AutoSize = true;
            billNumLabel.BackColor = Color.FloralWhite;
            billNumLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            billNumLabel.ForeColor = Color.DodgerBlue;
            billNumLabel.Location = new Point(157, 35);
            billNumLabel.Margin = new Padding(4, 0, 4, 0);
            billNumLabel.MinimumSize = new Size(267, 32);
            billNumLabel.Name = "billNumLabel";
            billNumLabel.Size = new Size(267, 32);
            billNumLabel.TabIndex = 23;
            // 
            // billRentIdLabel
            // 
            billRentIdLabel.AutoSize = true;
            billRentIdLabel.BackColor = SystemColors.Window;
            billRentIdLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billRentIdLabel.ForeColor = SystemColors.ControlDarkDark;
            billRentIdLabel.Location = new Point(157, 92);
            billRentIdLabel.Margin = new Padding(4, 0, 4, 0);
            billRentIdLabel.MinimumSize = new Size(267, 32);
            billRentIdLabel.Name = "billRentIdLabel";
            billRentIdLabel.Size = new Size(267, 32);
            billRentIdLabel.TabIndex = 24;
            // 
            // billClientLabel
            // 
            billClientLabel.AutoSize = true;
            billClientLabel.BackColor = SystemColors.Window;
            billClientLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            billClientLabel.ForeColor = SystemColors.ControlDarkDark;
            billClientLabel.Location = new Point(244, 146);
            billClientLabel.Margin = new Padding(4, 0, 4, 0);
            billClientLabel.MinimumSize = new Size(267, 32);
            billClientLabel.Name = "billClientLabel";
            billClientLabel.Size = new Size(267, 32);
            billClientLabel.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(44, 280);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 13;
            label3.Text = "Managed By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(41, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 14;
            label2.Text = "Car";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.GrayText;
            label14.Location = new Point(41, 417);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(132, 20);
            label14.TabIndex = 15;
            label14.Text = "Rent Date End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(44, 354);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 15;
            label4.Text = "Rent Date Start";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.GrayText;
            label12.Location = new Point(41, 35);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 16;
            label12.Text = "`Bill Num";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.GrayText;
            label11.Location = new Point(44, 100);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 17;
            label11.Text = "Rent Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(41, 154);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "Client";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(41, 548);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 18;
            label10.Text = "Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(41, 478);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 19;
            label5.Text = "Amount";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(selectedBillPanel);
            panel1.Location = new Point(4, 163);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 792);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(700, 158);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(692, 822);
            panel2.TabIndex = 17;
            // 
            // billNumberDataGridViewTextBoxColumn
            // 
            billNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber";
            billNumberDataGridViewTextBoxColumn.HeaderText = "BillNumber";
            billNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            billNumberDataGridViewTextBoxColumn.Name = "billNumberDataGridViewTextBoxColumn";
            billNumberDataGridViewTextBoxColumn.ReadOnly = true;
            billNumberDataGridViewTextBoxColumn.Width = 96;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 60;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // rentDataGridViewTextBoxColumn
            // 
            rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            rentDataGridViewTextBoxColumn.MinimumWidth = 6;
            rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            rentDataGridViewTextBoxColumn.ReadOnly = true;
            rentDataGridViewTextBoxColumn.Width = 60;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            detailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            detailsDataGridViewTextBoxColumn.ReadOnly = true;
            detailsDataGridViewTextBoxColumn.Width = 71;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(0, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(1392, 17);
            panel4.TabIndex = 0;
            // 
            // BillPageUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BillPageUserControl";
            Size = new Size(1392, 1048);
            panel3.ResumeLayout(false);
            selectedBillPanel.ResumeLayout(false);
            selectedBillPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)billBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private BindingSource billBindingSource;
        private Panel selectedBillPanel;
        private Label label9;
        private Label billAmountLabel;
        private Label billDateLabel;
        private Label billManagedByLabel;
        private Label billCarLabel;
        private Label billNumLabel;
        private Label billClientLabel;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label12;
        private Label label1;
        private Label label10;
        private Label label5;
        private Label billDetailsLabel;
        private Label billRentIdLabel;
        private Label label11;
        private Label label14;
        private Label billRentDateEndLabel;
        private Label billRentDateStartLabel;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn billNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private Panel panel4;
    }
}
