namespace wymówki464
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
            folder = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            save = new Button();
            open = new Button();
            randomExcuse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fileDate = new Label();
            description = new TextBox();
            results = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            lastUsed = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // folder
            // 
            folder.Location = new Point(12, 177);
            folder.Name = "folder";
            folder.Size = new Size(77, 23);
            folder.TabIndex = 0;
            folder.Text = "Folder";
            folder.UseVisualStyleBackColor = true;
            folder.Click += folder_Click;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(95, 177);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 1;
            save.Text = "Zapisz";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // open
            // 
            open.Enabled = false;
            open.Location = new Point(176, 177);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 2;
            open.Text = "Otwórz";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // randomExcuse
            // 
            randomExcuse.Enabled = false;
            randomExcuse.Location = new Point(257, 177);
            randomExcuse.Name = "randomExcuse";
            randomExcuse.Size = new Size(131, 23);
            randomExcuse.TabIndex = 3;
            randomExcuse.Text = "Losowa wymówka";
            randomExcuse.UseVisualStyleBackColor = true;
            randomExcuse.Click += randomExcuse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Wymówka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Wyniki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Ostatio użyte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Data pliku";
            // 
            // fileDate
            // 
            fileDate.BorderStyle = BorderStyle.Fixed3D;
            fileDate.Location = new Point(95, 120);
            fileDate.Name = "fileDate";
            fileDate.Size = new Size(262, 23);
            fileDate.TabIndex = 8;
            // 
            // description
            // 
            description.Location = new Point(95, 19);
            description.Name = "description";
            description.Size = new Size(100, 23);
            description.TabIndex = 9;
            description.TextChanged += description_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(95, 50);
            results.Name = "results";
            results.Size = new Size(100, 23);
            results.TabIndex = 10;
            results.TextChanged += results_TextChanged;
            // 
            // lastUsed
            // 
            lastUsed.Location = new Point(95, 81);
            lastUsed.Name = "lastUsed";
            lastUsed.Size = new Size(200, 23);
            lastUsed.TabIndex = 11;
            lastUsed.ValueChanged += lastUsed_ValueChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastUsed);
            Controls.Add(results);
            Controls.Add(description);
            Controls.Add(fileDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(randomExcuse);
            Controls.Add(open);
            Controls.Add(save);
            Controls.Add(folder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button folder;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button save;
        private Button open;
        private Button randomExcuse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label fileDate;
        private TextBox description;
        private TextBox results;
        private SaveFileDialog saveFileDialog1;
        private DateTimePicker lastUsed;
        private OpenFileDialog openFileDialog1;
    }
}