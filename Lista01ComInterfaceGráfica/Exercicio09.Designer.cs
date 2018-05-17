namespace Lista01ComInterfaceGráfica
{
    partial class Exercicio09
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumero01 = new System.Windows.Forms.NumericUpDown();
            this.txtNumero02 = new System.Windows.Forms.NumericUpDown();
            this.ResultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero02)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite 2 números para que se troquem";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(226, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero01
            // 
            this.txtNumero01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero01.Location = new System.Drawing.Point(70, 91);
            this.txtNumero01.Name = "txtNumero01";
            this.txtNumero01.Size = new System.Drawing.Size(225, 31);
            this.txtNumero01.TabIndex = 1;
            this.txtNumero01.ValueChanged += new System.EventHandler(this.txtNumero01_ValueChanged);
            // 
            // txtNumero02
            // 
            this.txtNumero02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero02.Location = new System.Drawing.Point(70, 160);
            this.txtNumero02.Name = "txtNumero02";
            this.txtNumero02.Size = new System.Drawing.Size(225, 31);
            this.txtNumero02.TabIndex = 2;
            this.txtNumero02.ValueChanged += new System.EventHandler(this.txtNumero02_ValueChanged);
            this.txtNumero02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero02_KeyDown);
            // 
            // ResultBox
            // 
            this.ResultBox.Enabled = false;
            this.ResultBox.Location = new System.Drawing.Point(12, 214);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(114, 78);
            this.ResultBox.TabIndex = 7;
            this.ResultBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Exercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 304);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.txtNumero02);
            this.Controls.Add(this.txtNumero01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio09";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtNumero01;
        private System.Windows.Forms.NumericUpDown txtNumero02;
        private System.Windows.Forms.TextBox ResultBox;
    }
}