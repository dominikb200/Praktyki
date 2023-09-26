namespace Wyprawa
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
            PlayerPicture = new PictureBox();
            BowPicture = new PictureBox();
            SwordPicture = new PictureBox();
            MacePicture = new PictureBox();
            BatPicture = new PictureBox();
            GhoulPicture = new PictureBox();
            GhostPicture = new PictureBox();
            BluePotionPicture = new PictureBox();
            RedPotionPicture = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PlayerLabel = new Label();
            PlayerHP = new Label();
            GhostLabel = new Label();
            GhostHP = new Label();
            BatLabel = new Label();
            BatHP = new Label();
            GhoulLabel = new Label();
            GhoulHP = new Label();
            groupBox1 = new GroupBox();
            MoveRight = new Button();
            MoveDown = new Button();
            MoveLeft = new Button();
            MoveUp = new Button();
            groupBox2 = new GroupBox();
            AttackUp = new Button();
            AttackDown = new Button();
            AttackLeft = new Button();
            AttackRight = new Button();
            SwordBox = new PictureBox();
            BlueBox = new PictureBox();
            BowBox = new PictureBox();
            MaceBox = new PictureBox();
            RedBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PlayerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BowPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SwordPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MacePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BatPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GhoulPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GhostPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BluePotionPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedPotionPicture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SwordBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BowBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox).BeginInit();
            SuspendLayout();
            // 
            // PlayerPicture
            // 
            PlayerPicture.BackColor = Color.Transparent;
            PlayerPicture.Image = (Image)resources.GetObject("PlayerPicture.Image");
            PlayerPicture.Location = new Point(75, 55);
            PlayerPicture.Name = "PlayerPicture";
            PlayerPicture.Size = new Size(30, 30);
            PlayerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerPicture.TabIndex = 0;
            PlayerPicture.TabStop = false;
            // 
            // BowPicture
            // 
            BowPicture.BackColor = Color.Transparent;
            BowPicture.Image = (Image)resources.GetObject("BowPicture.Image");
            BowPicture.Location = new Point(111, 55);
            BowPicture.Name = "BowPicture";
            BowPicture.Size = new Size(30, 30);
            BowPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            BowPicture.TabIndex = 1;
            BowPicture.TabStop = false;
            // 
            // SwordPicture
            // 
            SwordPicture.BackColor = Color.Transparent;
            SwordPicture.Image = (Image)resources.GetObject("SwordPicture.Image");
            SwordPicture.Location = new Point(147, 55);
            SwordPicture.Name = "SwordPicture";
            SwordPicture.Size = new Size(30, 30);
            SwordPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            SwordPicture.TabIndex = 2;
            SwordPicture.TabStop = false;
            // 
            // MacePicture
            // 
            MacePicture.BackColor = Color.Transparent;
            MacePicture.Image = (Image)resources.GetObject("MacePicture.Image");
            MacePicture.Location = new Point(183, 55);
            MacePicture.Name = "MacePicture";
            MacePicture.Size = new Size(30, 30);
            MacePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            MacePicture.TabIndex = 3;
            MacePicture.TabStop = false;
            // 
            // BatPicture
            // 
            BatPicture.BackColor = Color.Transparent;
            BatPicture.Image = (Image)resources.GetObject("BatPicture.Image");
            BatPicture.Location = new Point(219, 55);
            BatPicture.Name = "BatPicture";
            BatPicture.Size = new Size(30, 30);
            BatPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            BatPicture.TabIndex = 4;
            BatPicture.TabStop = false;
            // 
            // GhoulPicture
            // 
            GhoulPicture.BackColor = Color.Transparent;
            GhoulPicture.Image = (Image)resources.GetObject("GhoulPicture.Image");
            GhoulPicture.Location = new Point(255, 55);
            GhoulPicture.Name = "GhoulPicture";
            GhoulPicture.Size = new Size(30, 30);
            GhoulPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            GhoulPicture.TabIndex = 5;
            GhoulPicture.TabStop = false;
            // 
            // GhostPicture
            // 
            GhostPicture.BackColor = Color.Transparent;
            GhostPicture.Image = (Image)resources.GetObject("GhostPicture.Image");
            GhostPicture.Location = new Point(291, 55);
            GhostPicture.Name = "GhostPicture";
            GhostPicture.Size = new Size(30, 30);
            GhostPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            GhostPicture.TabIndex = 6;
            GhostPicture.TabStop = false;
            // 
            // BluePotionPicture
            // 
            BluePotionPicture.BackColor = Color.Transparent;
            BluePotionPicture.Image = (Image)resources.GetObject("BluePotionPicture.Image");
            BluePotionPicture.Location = new Point(327, 55);
            BluePotionPicture.Name = "BluePotionPicture";
            BluePotionPicture.Size = new Size(30, 30);
            BluePotionPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            BluePotionPicture.TabIndex = 7;
            BluePotionPicture.TabStop = false;
            // 
            // RedPotionPicture
            // 
            RedPotionPicture.BackColor = Color.Transparent;
            RedPotionPicture.Image = (Image)resources.GetObject("RedPotionPicture.Image");
            RedPotionPicture.Location = new Point(363, 55);
            RedPotionPicture.Name = "RedPotionPicture";
            RedPotionPicture.Size = new Size(30, 30);
            RedPotionPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            RedPotionPicture.TabIndex = 8;
            RedPotionPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PlayerLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PlayerHP, 1, 0);
            tableLayoutPanel1.Controls.Add(GhostLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(GhostHP, 1, 1);
            tableLayoutPanel1.Controls.Add(BatLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(BatHP, 1, 2);
            tableLayoutPanel1.Controls.Add(GhoulLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(GhoulHP, 1, 3);
            tableLayoutPanel1.Location = new Point(388, 238);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(138, 63);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // PlayerLabel
            // 
            PlayerLabel.AutoSize = true;
            PlayerLabel.Location = new Point(3, 0);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(36, 15);
            PlayerLabel.TabIndex = 0;
            PlayerLabel.Text = "Gracz";
            // 
            // PlayerHP
            // 
            PlayerHP.AutoSize = true;
            PlayerHP.Location = new Point(72, 0);
            PlayerHP.Name = "PlayerHP";
            PlayerHP.Size = new Size(38, 15);
            PlayerHP.TabIndex = 1;
            PlayerHP.Text = "label2";
            // 
            // GhostLabel
            // 
            GhostLabel.AutoSize = true;
            GhostLabel.Enabled = false;
            GhostLabel.Location = new Point(3, 15);
            GhostLabel.Name = "GhostLabel";
            GhostLabel.Size = new Size(35, 15);
            GhostLabel.TabIndex = 2;
            GhostLabel.Text = "Duch";
            // 
            // GhostHP
            // 
            GhostHP.AutoSize = true;
            GhostHP.Enabled = false;
            GhostHP.Location = new Point(72, 15);
            GhostHP.Name = "GhostHP";
            GhostHP.Size = new Size(38, 15);
            GhostHP.TabIndex = 3;
            GhostHP.Text = "label4";
            // 
            // BatLabel
            // 
            BatLabel.AutoSize = true;
            BatLabel.Enabled = false;
            BatLabel.Location = new Point(3, 30);
            BatLabel.Name = "BatLabel";
            BatLabel.Size = new Size(58, 15);
            BatLabel.TabIndex = 4;
            BatLabel.Text = "Nietoperz";
            // 
            // BatHP
            // 
            BatHP.AutoSize = true;
            BatHP.Enabled = false;
            BatHP.Location = new Point(72, 30);
            BatHP.Name = "BatHP";
            BatHP.Size = new Size(38, 15);
            BatHP.TabIndex = 5;
            BatHP.Text = "label6";
            // 
            // GhoulLabel
            // 
            GhoulLabel.AutoSize = true;
            GhoulLabel.Enabled = false;
            GhoulLabel.Location = new Point(3, 45);
            GhoulLabel.Name = "GhoulLabel";
            GhoulLabel.Size = new Size(36, 15);
            GhoulLabel.TabIndex = 6;
            GhoulLabel.Text = "Upiór";
            // 
            // GhoulHP
            // 
            GhoulHP.AutoSize = true;
            GhoulHP.Enabled = false;
            GhoulHP.Location = new Point(72, 45);
            GhoulHP.Name = "GhoulHP";
            GhoulHP.Size = new Size(38, 15);
            GhoulHP.TabIndex = 7;
            GhoulHP.Text = "label8";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(MoveRight);
            groupBox1.Controls.Add(MoveDown);
            groupBox1.Controls.Add(MoveLeft);
            groupBox1.Controls.Add(MoveUp);
            groupBox1.Location = new Point(327, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(98, 75);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ruch";
            // 
            // MoveRight
            // 
            MoveRight.Location = new Point(69, 46);
            MoveRight.Name = "MoveRight";
            MoveRight.Size = new Size(23, 23);
            MoveRight.TabIndex = 3;
            MoveRight.Text = "→";
            MoveRight.UseVisualStyleBackColor = true;
            MoveRight.Click += MoveRight_Click;
            // 
            // MoveDown
            // 
            MoveDown.Location = new Point(36, 52);
            MoveDown.Name = "MoveDown";
            MoveDown.Size = new Size(27, 23);
            MoveDown.TabIndex = 2;
            MoveDown.Text = "↓";
            MoveDown.UseVisualStyleBackColor = true;
            MoveDown.Click += MoveDown_Click;
            // 
            // MoveLeft
            // 
            MoveLeft.Location = new Point(6, 46);
            MoveLeft.Name = "MoveLeft";
            MoveLeft.Size = new Size(24, 23);
            MoveLeft.TabIndex = 1;
            MoveLeft.Text = "←";
            MoveLeft.UseVisualStyleBackColor = true;
            MoveLeft.Click += MoveLeft_Click;
            // 
            // MoveUp
            // 
            MoveUp.Location = new Point(36, 22);
            MoveUp.Name = "MoveUp";
            MoveUp.Size = new Size(27, 24);
            MoveUp.TabIndex = 0;
            MoveUp.Text = "↑";
            MoveUp.UseVisualStyleBackColor = true;
            MoveUp.Click += MoveUp_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(AttackUp);
            groupBox2.Controls.Add(AttackDown);
            groupBox2.Controls.Add(AttackLeft);
            groupBox2.Controls.Add(AttackRight);
            groupBox2.Location = new Point(439, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(104, 75);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Atak";
            // 
            // AttackUp
            // 
            AttackUp.AutoSize = true;
            AttackUp.Location = new Point(36, 22);
            AttackUp.Name = "AttackUp";
            AttackUp.Size = new Size(27, 25);
            AttackUp.TabIndex = 7;
            AttackUp.Text = "↑";
            AttackUp.UseVisualStyleBackColor = true;
            AttackUp.Click += AttackUp_Click;
            // 
            // AttackDown
            // 
            AttackDown.Location = new Point(36, 52);
            AttackDown.Name = "AttackDown";
            AttackDown.Size = new Size(27, 23);
            AttackDown.TabIndex = 6;
            AttackDown.Text = "↓";
            AttackDown.UseVisualStyleBackColor = true;
            AttackDown.Click += AttackDown_Click;
            // 
            // AttackLeft
            // 
            AttackLeft.Location = new Point(6, 46);
            AttackLeft.Name = "AttackLeft";
            AttackLeft.Size = new Size(24, 23);
            AttackLeft.TabIndex = 5;
            AttackLeft.Text = "s";
            AttackLeft.UseVisualStyleBackColor = true;
            AttackLeft.Click += AttackLeft_Click;
            // 
            // AttackRight
            // 
            AttackRight.Location = new Point(69, 46);
            AttackRight.Name = "AttackRight";
            AttackRight.Size = new Size(23, 23);
            AttackRight.TabIndex = 4;
            AttackRight.Text = "→";
            AttackRight.UseVisualStyleBackColor = true;
            AttackRight.Click += AttackRight_Click;
            // 
            // SwordBox
            // 
            SwordBox.BackColor = Color.Transparent;
            SwordBox.Image = (Image)resources.GetObject("SwordBox.Image");
            SwordBox.Location = new Point(75, 307);
            SwordBox.Name = "SwordBox";
            SwordBox.Size = new Size(45, 45);
            SwordBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SwordBox.TabIndex = 12;
            SwordBox.TabStop = false;
            SwordBox.Visible = false;
            SwordBox.Click += SwordBox_Click;
            // 
            // BlueBox
            // 
            BlueBox.BackColor = Color.Transparent;
            BlueBox.Image = (Image)resources.GetObject("BlueBox.Image");
            BlueBox.Location = new Point(228, 307);
            BlueBox.Name = "BlueBox";
            BlueBox.Size = new Size(45, 45);
            BlueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BlueBox.TabIndex = 13;
            BlueBox.TabStop = false;
            BlueBox.Visible = false;
            BlueBox.Click += BlueBox_Click;
            // 
            // BowBox
            // 
            BowBox.BackColor = Color.Transparent;
            BowBox.Image = (Image)resources.GetObject("BowBox.Image");
            BowBox.Location = new Point(126, 307);
            BowBox.Name = "BowBox";
            BowBox.Size = new Size(45, 45);
            BowBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BowBox.TabIndex = 13;
            BowBox.TabStop = false;
            BowBox.Visible = false;
            BowBox.Click += BowBox_Click;
            // 
            // MaceBox
            // 
            MaceBox.BackColor = Color.Transparent;
            MaceBox.Image = (Image)resources.GetObject("MaceBox.Image");
            MaceBox.Location = new Point(177, 307);
            MaceBox.Name = "MaceBox";
            MaceBox.Size = new Size(45, 45);
            MaceBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MaceBox.TabIndex = 14;
            MaceBox.TabStop = false;
            MaceBox.Visible = false;
            MaceBox.Click += MaceBox_Click;
            // 
            // RedBox
            // 
            RedBox.BackColor = Color.Transparent;
            RedBox.Image = (Image)resources.GetObject("RedBox.Image");
            RedBox.Location = new Point(279, 307);
            RedBox.Name = "RedBox";
            RedBox.Size = new Size(45, 45);
            RedBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RedBox.TabIndex = 15;
            RedBox.TabStop = false;
            RedBox.Visible = false;
            RedBox.Click += RedBox_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(600, 394);
            Controls.Add(RedBox);
            Controls.Add(MaceBox);
            Controls.Add(BowBox);
            Controls.Add(BlueBox);
            Controls.Add(SwordBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(RedPotionPicture);
            Controls.Add(BluePotionPicture);
            Controls.Add(GhostPicture);
            Controls.Add(GhoulPicture);
            Controls.Add(BatPicture);
            Controls.Add(MacePicture);
            Controls.Add(SwordPicture);
            Controls.Add(BowPicture);
            Controls.Add(PlayerPicture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)PlayerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)BowPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)SwordPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)MacePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)BatPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)GhoulPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)GhostPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)BluePotionPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedPotionPicture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SwordBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BowBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PlayerPicture;
        private PictureBox BowPicture;
        private PictureBox SwordPicture;
        private PictureBox MacePicture;
        private PictureBox BatPicture;
        private PictureBox GhoulPicture;
        private PictureBox GhostPicture;
        private PictureBox BluePotionPicture;
        private PictureBox RedPotionPicture;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button MoveRight;
        private Button MoveDown;
        private Button MoveLeft;
        private Button MoveUp;
        private GroupBox groupBox2;
        private Button AttackRight;
        private Label PlayerLabel;
        private Label PlayerHP;
        private Label GhostLabel;
        private Label GhostHP;
        private Label BatLabel;
        private Label BatHP;
        private Label GhoulLabel;
        private Label GhoulHP;
        private Button AttackUp;
        private Button AttackDown;
        private Button AttackLeft;
        private PictureBox SwordBox;
        private PictureBox BlueBox;
        private PictureBox BowBox;
        private PictureBox MaceBox;
        private PictureBox RedBox;
        private System.Windows.Forms.Timer timer1;
    }
}