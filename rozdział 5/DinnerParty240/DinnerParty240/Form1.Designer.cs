namespace DinnerParty240
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            fancyBox = new CheckBox();
            healthyBox = new CheckBox();
            label2 = new Label();
            costLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            birthdayCost = new Label();
            label6 = new Label();
            tooLongLabel = new Label();
            cakeWriting = new TextBox();
            label4 = new Label();
            fancyBirthday = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość osób";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(15, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Location = new Point(15, 62);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(135, 19);
            fancyBox.TabIndex = 2;
            fancyBox.Text = "Dekoracje fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += fancyBox_CheckedChanged;
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(15, 87);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(98, 19);
            healthyBox.TabIndex = 3;
            healthyBox.Text = "Opcja zdrowa";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += healthyBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 122);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Koszt";
            // 
            // costLabel
            // 
            costLabel.BorderStyle = BorderStyle.Fixed3D;
            costLabel.Location = new Point(79, 121);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(100, 23);
            costLabel.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(407, 236);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(costLabel);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(healthyBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(fancyBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(399, 208);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Impreza okolicznościowa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(birthdayCost);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tooLongLabel);
            tabPage2.Controls.Add(cakeWriting);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(fancyBirthday);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(399, 208);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przyjęcie urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            birthdayCost.BorderStyle = BorderStyle.Fixed3D;
            birthdayCost.Location = new Point(59, 148);
            birthdayCost.Name = "birthdayCost";
            birthdayCost.Size = new Size(100, 23);
            birthdayCost.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 149);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "Koszt";
            // 
            // tooLongLabel
            // 
            tooLongLabel.AutoSize = true;
            tooLongLabel.BackColor = Color.Red;
            tooLongLabel.Location = new Point(105, 93);
            tooLongLabel.Name = "tooLongLabel";
            tooLongLabel.Size = new Size(70, 15);
            tooLongLabel.TabIndex = 10;
            tooLongLabel.Text = "ZBYT DŁUGI";
            // 
            // cakeWriting
            // 
            cakeWriting.Location = new Point(16, 111);
            cakeWriting.Name = "cakeWriting";
            cakeWriting.Size = new Size(159, 23);
            cakeWriting.TabIndex = 9;
            cakeWriting.Text = "Sto lat!";
            cakeWriting.TextChanged += cakeWriting_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 93);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Napis na torcie";
            // 
            // fancyBirthday
            // 
            fancyBirthday.AutoSize = true;
            fancyBirthday.Location = new Point(16, 60);
            fancyBirthday.Name = "fancyBirthday";
            fancyBirthday.Size = new Size(135, 19);
            fancyBirthday.TabIndex = 7;
            fancyBirthday.Text = "Dekoracje fantazyjne";
            fancyBirthday.UseVisualStyleBackColor = true;
            fancyBirthday.CheckedChanged += fancyBirthday_CheckedChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(16, 31);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 13);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Ilość osób";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 291);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Planista przyjęć";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label label2;
        private Label costLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private CheckBox fancyBirthday;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label birthdayCost;
        private Label label6;
        private Label tooLongLabel;
        private TextBox cakeWriting;
    }
}