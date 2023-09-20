namespace dwieTalie418
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
            moveToDeck2 = new Button();
            moveToDeck1 = new Button();
            shuffle1 = new Button();
            reset1 = new Button();
            reset2 = new Button();
            shuffle2 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // moveToDeck2
            // 
            moveToDeck2.Location = new Point(161, 87);
            moveToDeck2.Name = "moveToDeck2";
            moveToDeck2.Size = new Size(49, 32);
            moveToDeck2.TabIndex = 2;
            moveToDeck2.Text = ">>";
            moveToDeck2.UseVisualStyleBackColor = true;
            // 
            // moveToDeck1
            // 
            moveToDeck1.Location = new Point(161, 134);
            moveToDeck1.Name = "moveToDeck1";
            moveToDeck1.Size = new Size(49, 31);
            moveToDeck1.TabIndex = 3;
            moveToDeck1.Text = "<<";
            moveToDeck1.UseVisualStyleBackColor = true;
            // 
            // shuffle1
            // 
            shuffle1.Location = new Point(16, 310);
            shuffle1.Name = "shuffle1";
            shuffle1.Size = new Size(139, 23);
            shuffle1.TabIndex = 4;
            shuffle1.Text = "Wymieszaj zestaw 1";
            shuffle1.UseVisualStyleBackColor = true;
            // 
            // reset1
            // 
            reset1.Location = new Point(16, 281);
            reset1.Name = "reset1";
            reset1.Size = new Size(139, 23);
            reset1.TabIndex = 5;
            reset1.Text = "Przywróć zestaw 1";
            reset1.UseVisualStyleBackColor = true;
            // 
            // reset2
            // 
            reset2.Location = new Point(216, 281);
            reset2.Name = "reset2";
            reset2.Size = new Size(140, 23);
            reset2.TabIndex = 6;
            reset2.Text = "Przywróć zestaw 2";
            reset2.UseVisualStyleBackColor = true;
            // 
            // shuffle2
            // 
            shuffle2.Location = new Point(216, 310);
            shuffle2.Name = "shuffle2";
            shuffle2.Size = new Size(140, 23);
            shuffle2.TabIndex = 7;
            shuffle2.Text = "Wymieszaj zestaw 2";
            shuffle2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 8;
            label1.Text = "Zestaw 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 22);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Zestaw2";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(139, 229);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(216, 40);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(140, 229);
            listBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shuffle2);
            Controls.Add(reset2);
            Controls.Add(reset1);
            Controls.Add(shuffle1);
            Controls.Add(moveToDeck1);
            Controls.Add(moveToDeck2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox deck1;
        private TextBox deck2;
        private Button moveToDeck2;
        private Button moveToDeck1;
        private Button shuffle1;
        private Button reset1;
        private Button reset2;
        private Button shuffle2;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}