namespace LabDzienNaWyscigach225
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            groupBox1 = new GroupBox();
            minBetLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            betUpDown = new NumericUpDown();
            betButton = new Button();
            nameLabel = new Label();
            button1 = new Button();
            alBetLabel = new Label();
            bobBetLabel = new Label();
            joeBetLabel = new Label();
            alRadioButton = new RadioButton();
            bobRadioButton = new RadioButton();
            joeRadioButton = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 25);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 69);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 25);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(31, 128);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 25);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(31, 186);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(75, 25);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(minBetLabel);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(betUpDown);
            groupBox1.Controls.Add(betButton);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(alBetLabel);
            groupBox1.Controls.Add(bobBetLabel);
            groupBox1.Controls.Add(joeBetLabel);
            groupBox1.Controls.Add(alRadioButton);
            groupBox1.Controls.Add(bobRadioButton);
            groupBox1.Controls.Add(joeRadioButton);
            groupBox1.Location = new Point(12, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 203);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dom bukmacherski";
            // 
            // minBetLabel
            // 
            minBetLabel.AutoSize = true;
            minBetLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minBetLabel.Location = new Point(19, 31);
            minBetLabel.Name = "minBetLabel";
            minBetLabel.Size = new Size(116, 15);
            minBetLabel.TabIndex = 12;
            minBetLabel.Text = "minimumBetLabel";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(384, 161);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 165);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 10;
            label1.Text = "zł na charta numer";
            // 
            // betUpDown
            // 
            betUpDown.Location = new Point(191, 161);
            betUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            betUpDown.Name = "betUpDown";
            betUpDown.Size = new Size(63, 23);
            betUpDown.TabIndex = 9;
            betUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // betButton
            // 
            betButton.Location = new Point(95, 161);
            betButton.Name = "betButton";
            betButton.Size = new Size(75, 23);
            betButton.TabIndex = 8;
            betButton.Text = "stawia";
            betButton.UseVisualStyleBackColor = true;
            betButton.Click += betButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(33, 165);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(37, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(502, 22);
            button1.Name = "button1";
            button1.Size = new Size(268, 175);
            button1.TabIndex = 6;
            button1.Text = "Start!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // alBetLabel
            // 
            alBetLabel.BorderStyle = BorderStyle.FixedSingle;
            alBetLabel.Location = new Point(191, 111);
            alBetLabel.Name = "alBetLabel";
            alBetLabel.Size = new Size(248, 17);
            alBetLabel.TabIndex = 5;
            alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            bobBetLabel.BorderStyle = BorderStyle.FixedSingle;
            bobBetLabel.Location = new Point(191, 86);
            bobBetLabel.Name = "bobBetLabel";
            bobBetLabel.Size = new Size(248, 17);
            bobBetLabel.TabIndex = 4;
            bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            joeBetLabel.BorderStyle = BorderStyle.FixedSingle;
            joeBetLabel.Location = new Point(191, 61);
            joeBetLabel.Name = "joeBetLabel";
            joeBetLabel.Size = new Size(248, 17);
            joeBetLabel.TabIndex = 3;
            joeBetLabel.Text = "joeBetLabel";
            // 
            // alRadioButton
            // 
            alRadioButton.AutoSize = true;
            alRadioButton.Location = new Point(19, 109);
            alRadioButton.Name = "alRadioButton";
            alRadioButton.Size = new Size(100, 19);
            alRadioButton.TabIndex = 2;
            alRadioButton.TabStop = true;
            alRadioButton.Text = "alRadioButton";
            alRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            bobRadioButton.AutoSize = true;
            bobRadioButton.Location = new Point(19, 84);
            bobRadioButton.Name = "bobRadioButton";
            bobRadioButton.Size = new Size(112, 19);
            bobRadioButton.TabIndex = 1;
            bobRadioButton.TabStop = true;
            bobRadioButton.Text = "bobRadioButton";
            bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // joeRadioButton
            // 
            joeRadioButton.AutoSize = true;
            joeRadioButton.Location = new Point(19, 59);
            joeRadioButton.Name = "joeRadioButton";
            joeRadioButton.Size = new Size(107, 19);
            joeRadioButton.TabIndex = 0;
            joeRadioButton.TabStop = true;
            joeRadioButton.Text = "joeRadioButton";
            joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)betUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private GroupBox groupBox1;
        private RadioButton alRadioButton;
        private RadioButton bobRadioButton;
        private RadioButton joeRadioButton;
        private Label alBetLabel;
        private Label bobBetLabel;
        private Label joeBetLabel;
        private NumericUpDown betUpDown;
        private Button betButton;
        private Label nameLabel;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label minBetLabel;
        private System.Windows.Forms.Timer timer1;
    }
}