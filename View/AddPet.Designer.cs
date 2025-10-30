namespace zhFelkeszito2.View
{
    partial class AddPet
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
            tableLayoutPanel1 = new TableLayoutPanel();
            weightNum = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTB = new TextBox();
            genderRB = new RadioButton();
            ageNum = new NumericUpDown();
            speciesCombo = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageNum).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(weightNum, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(nameTB, 1, 0);
            tableLayoutPanel1.Controls.Add(genderRB, 1, 1);
            tableLayoutPanel1.Controls.Add(ageNum, 1, 2);
            tableLayoutPanel1.Controls.Add(speciesCombo, 1, 4);
            tableLayoutPanel1.Location = new Point(2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(510, 371);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // weightNum
            // 
            weightNum.Anchor = AnchorStyles.None;
            weightNum.DecimalPlaces = 1;
            weightNum.Location = new Point(307, 245);
            weightNum.Name = "weightNum";
            weightNum.Size = new Size(150, 27);
            weightNum.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(108, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Név:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(105, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Nem:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(98, 175);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Életkor:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(108, 249);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Súly:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(89, 323);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Kategória:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // nameTB
            // 
            nameTB.Anchor = AnchorStyles.None;
            nameTB.Location = new Point(320, 23);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 5;
            // 
            // genderRB
            // 
            genderRB.Anchor = AnchorStyles.None;
            genderRB.AutoSize = true;
            genderRB.Location = new Point(324, 99);
            genderRB.Name = "genderRB";
            genderRB.Size = new Size(117, 24);
            genderRB.TabIndex = 6;
            genderRB.TabStop = true;
            genderRB.Text = "radioButton1";
            genderRB.UseVisualStyleBackColor = true;
            // 
            // ageNum
            // 
            ageNum.Anchor = AnchorStyles.None;
            ageNum.Location = new Point(307, 171);
            ageNum.Name = "ageNum";
            ageNum.Size = new Size(150, 27);
            ageNum.TabIndex = 7;
            // 
            // speciesCombo
            // 
            speciesCombo.Anchor = AnchorStyles.None;
            speciesCombo.FormattingEnabled = true;
            speciesCombo.Items.AddRange(new object[] { "macska", "kutya", "ló", "sas" });
            speciesCombo.Location = new Point(307, 319);
            speciesCombo.Name = "speciesCombo";
            speciesCombo.Size = new Size(151, 28);
            speciesCombo.TabIndex = 9;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(338, 414);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 1;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(91, 414);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 479);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(tableLayoutPanel1);
            Name = "AddPet";
            Text = "AddPet";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown weightNum;
        private TextBox nameTB;
        private RadioButton genderRB;
        private NumericUpDown ageNum;
        private ComboBox speciesCombo;
        private Button okButton;
        private Button cancelButton;
    }
}