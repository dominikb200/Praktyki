namespace DlugieCwiczenie368
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
            description = new TextBox();
            goHere = new Button();
            exits = new ComboBox();
            goThroughTheDoor = new Button();
            check = new Button();
            hide = new Button();
            SuspendLayout();
            // 
            // description
            // 
            description.Location = new Point(30, 16);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(304, 145);
            description.TabIndex = 0;
            // 
            // goHere
            // 
            goHere.Location = new Point(30, 167);
            goHere.Name = "goHere";
            goHere.Size = new Size(75, 23);
            goHere.TabIndex = 1;
            goHere.Text = "Idź tutaj:";
            goHere.UseVisualStyleBackColor = true;
            goHere.Click += goHere_Click;
            // 
            // exits
            // 
            exits.DropDownStyle = ComboBoxStyle.DropDownList;
            exits.FormattingEnabled = true;
            exits.Location = new Point(111, 167);
            exits.Name = "exits";
            exits.Size = new Size(223, 23);
            exits.TabIndex = 2;
            // 
            // goThroughTheDoor
            // 
            goThroughTheDoor.Location = new Point(30, 196);
            goThroughTheDoor.Name = "goThroughTheDoor";
            goThroughTheDoor.Size = new Size(304, 23);
            goThroughTheDoor.TabIndex = 3;
            goThroughTheDoor.Text = "Przejdź przez drzwi";
            goThroughTheDoor.UseVisualStyleBackColor = true;
            goThroughTheDoor.Visible = false;
            goThroughTheDoor.Click += goThroughTheDoor_Click;
            // 
            // check
            // 
            check.Location = new Point(30, 225);
            check.Name = "check";
            check.Size = new Size(304, 23);
            check.TabIndex = 4;
            check.Text = "sprawdź";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // hide
            // 
            hide.Location = new Point(30, 254);
            hide.Name = "hide";
            hide.Size = new Size(304, 23);
            hide.TabIndex = 5;
            hide.Text = "Kryj się!";
            hide.UseVisualStyleBackColor = true;
            hide.Click += hide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hide);
            Controls.Add(check);
            Controls.Add(goThroughTheDoor);
            Controls.Add(exits);
            Controls.Add(goHere);
            Controls.Add(description);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private Button goHere;
        private ComboBox exits;
        private Button goThroughTheDoor;
        private Button check;
        private Button hide;
    }
}