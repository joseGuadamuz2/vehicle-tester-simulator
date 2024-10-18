namespace VehicleTesterSimulator
{
    partial class frmLogin
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            rdbLanguajeEN = new RadioButton();
            rdbLanguajeES = new RadioButton();
            btnLoggin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "lblUsername";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "lblPassword";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 3;
            // 
            // rdbLanguajeEN
            // 
            rdbLanguajeEN.AutoSize = true;
            rdbLanguajeEN.Checked = true;
            rdbLanguajeEN.Location = new Point(251, 29);
            rdbLanguajeEN.Name = "rdbLanguajeEN";
            rdbLanguajeEN.Size = new Size(40, 19);
            rdbLanguajeEN.TabIndex = 4;
            rdbLanguajeEN.TabStop = true;
            rdbLanguajeEN.Text = "EN";
            rdbLanguajeEN.UseVisualStyleBackColor = true;
            // 
            // rdbLanguajeES
            // 
            rdbLanguajeES.AutoSize = true;
            rdbLanguajeES.Location = new Point(251, 54);
            rdbLanguajeES.Name = "rdbLanguajeES";
            rdbLanguajeES.Size = new Size(37, 19);
            rdbLanguajeES.TabIndex = 5;
            rdbLanguajeES.TabStop = true;
            rdbLanguajeES.Text = "ES";
            rdbLanguajeES.UseVisualStyleBackColor = true;
            // 
            // btnLoggin
            // 
            btnLoggin.Location = new Point(49, 123);
            btnLoggin.Name = "btnLoggin";
            btnLoggin.Size = new Size(75, 23);
            btnLoggin.TabIndex = 6;
            btnLoggin.Text = "LOGGIN";
            btnLoggin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(164, 123);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 180);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnLoggin);
            Controls.Add(rdbLanguajeES);
            Controls.Add(rdbLanguajeEN);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private RadioButton rdbLanguajeEN;
        private RadioButton rdbLanguajeES;
        private Button btnLoggin;
        private Button btnCancel;
    }
}
