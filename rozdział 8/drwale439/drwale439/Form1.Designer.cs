namespace drwale439
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
            label2 = new Label();
            line = new ListBox();
            addLumberjack = new Button();
            name = new TextBox();
            groupBox1 = new GroupBox();
            howMany = new NumericUpDown();
            nextLumberjack = new Button();
            addFlapjacks = new Button();
            banana = new RadioButton();
            browned = new RadioButton();
            soggy = new RadioButton();
            crispy = new RadioButton();
            nextInLine = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)howMany).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię drwala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Kolejka do śniadania";
            // 
            // line
            // 
            line.FormattingEnabled = true;
            line.ItemHeight = 15;
            line.Location = new Point(22, 105);
            line.Name = "line";
            line.Size = new Size(115, 289);
            line.TabIndex = 3;
            // 
            // addLumberjack
            // 
            addLumberjack.Location = new Point(22, 38);
            addLumberjack.Name = "addLumberjack";
            addLumberjack.Size = new Size(221, 23);
            addLumberjack.TabIndex = 4;
            addLumberjack.Text = "Dodaj drwala";
            addLumberjack.UseVisualStyleBackColor = true;
            addLumberjack.Click += addLumberjack_Click;
            // 
            // name
            // 
            name.Location = new Point(96, 6);
            name.Name = "name";
            name.Size = new Size(147, 23);
            name.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(howMany);
            groupBox1.Controls.Add(nextLumberjack);
            groupBox1.Controls.Add(addFlapjacks);
            groupBox1.Controls.Add(banana);
            groupBox1.Controls.Add(browned);
            groupBox1.Controls.Add(soggy);
            groupBox1.Controls.Add(crispy);
            groupBox1.Controls.Add(nextInLine);
            groupBox1.Location = new Point(143, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(111, 288);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nakarm drwala";
            // 
            // howMany
            // 
            howMany.Location = new Point(5, 22);
            howMany.Name = "howMany";
            howMany.Size = new Size(87, 23);
            howMany.TabIndex = 7;
            // 
            // nextLumberjack
            // 
            nextLumberjack.Location = new Point(6, 259);
            nextLumberjack.Name = "nextLumberjack";
            nextLumberjack.Size = new Size(99, 23);
            nextLumberjack.TabIndex = 6;
            nextLumberjack.Text = "Następny drwal";
            nextLumberjack.UseVisualStyleBackColor = true;
            nextLumberjack.Click += nextLumberjack_Click;
            // 
            // addFlapjacks
            // 
            addFlapjacks.Location = new Point(6, 172);
            addFlapjacks.Name = "addFlapjacks";
            addFlapjacks.Size = new Size(99, 23);
            addFlapjacks.TabIndex = 5;
            addFlapjacks.Text = "Dodaj naleśniki";
            addFlapjacks.UseVisualStyleBackColor = true;
            addFlapjacks.Click += addFlapjacks_Click;
            // 
            // banana
            // 
            banana.AutoSize = true;
            banana.Location = new Point(6, 138);
            banana.Name = "banana";
            banana.Size = new Size(94, 19);
            banana.TabIndex = 4;
            banana.TabStop = true;
            banana.Text = "Bananowego";
            banana.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            browned.AutoSize = true;
            browned.Location = new Point(6, 113);
            browned.Name = "browned";
            browned.Size = new Size(86, 19);
            browned.TabIndex = 3;
            browned.TabStop = true;
            browned.Text = "Rumianego";
            browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            soggy.AutoSize = true;
            soggy.Location = new Point(6, 88);
            soggy.Name = "soggy";
            soggy.Size = new Size(87, 19);
            soggy.TabIndex = 2;
            soggy.TabStop = true;
            soggy.Text = "Wilgotnego";
            soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            crispy.AutoSize = true;
            crispy.Location = new Point(6, 63);
            crispy.Name = "crispy";
            crispy.Size = new Size(87, 19);
            crispy.TabIndex = 1;
            crispy.TabStop = true;
            crispy.Text = "Chrupkiego";
            crispy.UseVisualStyleBackColor = true;
            // 
            // nextInLine
            // 
            nextInLine.Location = new Point(6, 201);
            nextInLine.Multiline = true;
            nextInLine.Name = "nextInLine";
            nextInLine.ReadOnly = true;
            nextInLine.Size = new Size(100, 52);
            nextInLine.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(name);
            Controls.Add(addLumberjack);
            Controls.Add(line);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)howMany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox line;
        private Button addLumberjack;
        private TextBox name;
        private GroupBox groupBox1;
        private Button nextLumberjack;
        private Button addFlapjacks;
        private RadioButton banana;
        private RadioButton browned;
        private RadioButton soggy;
        private RadioButton crispy;
        private TextBox nextInLine;
        private NumericUpDown howMany;
    }
}