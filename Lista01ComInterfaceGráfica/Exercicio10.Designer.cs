namespace Lista01ComInterfaceGráfica
{
    partial class Exercicio10
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
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataAtual = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataNascimento
            // 
            this.dataNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(75, 92);
            this.dataNascimento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dataNascimento.MinDate = new System.DateTime(1902, 1, 1, 0, 0, 0, 0);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dataNascimento.TabIndex = 1;
            this.dataNascimento.Value = new System.DateTime(2018, 5, 17, 14, 40, 3, 0);
            this.dataNascimento.ValueChanged += new System.EventHandler(this.dataNascimento_ValueChanged);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(72, 56);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(348, 25);
            this.labelDataNascimento.TabIndex = 3;
            this.labelDataNascimento.Text = "Selecione sua data de nascimento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 140);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataAtual
            // 
            this.DataAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataAtual.Location = new System.Drawing.Point(77, 243);
            this.DataAtual.Name = "DataAtual";
            this.DataAtual.Size = new System.Drawing.Size(200, 20);
            this.DataAtual.TabIndex = 5;
            this.DataAtual.ValueChanged += new System.EventHandler(this.dataAtual_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Atual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataAtual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dataNascimento);
            this.Name = "Exercicio10";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DataAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}