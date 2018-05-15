namespace Lista01ComInterfaceGráfica
{
    partial class Exercicio02
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
            this.quantLitros = new System.Windows.Forms.Label();
            this.quantAnos = new System.Windows.Forms.Label();
            this.NupQuantLitros = new System.Windows.Forms.NumericUpDown();
            this.NUPAnos = new System.Windows.Forms.NumericUpDown();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.valueLitro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NupQuantLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPAnos)).BeginInit();
            this.SuspendLayout();
            // 
            // quantLitros
            // 
            this.quantLitros.AutoSize = true;
            this.quantLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantLitros.Location = new System.Drawing.Point(15, 32);
            this.quantLitros.Name = "quantLitros";
            this.quantLitros.Size = new System.Drawing.Size(470, 25);
            this.quantLitros.TabIndex = 0;
            this.quantLitros.Text = "Quantidade de Litros de Água ingeridos por dia:";
            this.quantLitros.Click += new System.EventHandler(this.quantLitros_Click);
            // 
            // quantAnos
            // 
            this.quantAnos.AutoSize = true;
            this.quantAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantAnos.Location = new System.Drawing.Point(15, 103);
            this.quantAnos.Name = "quantAnos";
            this.quantAnos.Size = new System.Drawing.Size(214, 25);
            this.quantAnos.TabIndex = 3;
            this.quantAnos.Text = "Quantidade de Anos:\r\n";
            // 
            // NupQuantLitros
            // 
            this.NupQuantLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupQuantLitros.Location = new System.Drawing.Point(20, 60);
            this.NupQuantLitros.Name = "NupQuantLitros";
            this.NupQuantLitros.Size = new System.Drawing.Size(120, 31);
            this.NupQuantLitros.TabIndex = 4;
            this.NupQuantLitros.ValueChanged += new System.EventHandler(this.NupQuantLitros_ValueChanged);
            // 
            // NUPAnos
            // 
            this.NUPAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPAnos.Location = new System.Drawing.Point(20, 131);
            this.NUPAnos.Name = "NUPAnos";
            this.NUPAnos.Size = new System.Drawing.Size(120, 31);
            this.NUPAnos.TabIndex = 5;
            this.NUPAnos.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(20, 198);
            this.txtValor.Mask = "00C00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 31);
            this.txtValor.TabIndex = 6;
            this.txtValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // valueLitro
            // 
            this.valueLitro.AutoSize = true;
            this.valueLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLitro.Location = new System.Drawing.Point(15, 170);
            this.valueLitro.Name = "valueLitro";
            this.valueLitro.Size = new System.Drawing.Size(153, 25);
            this.valueLitro.TabIndex = 7;
            this.valueLitro.Text = "Valor por Litro:\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(20, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(309, 170);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(303, 209);
            this.txtResultado.TabIndex = 11;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 407);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueLitro);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.NUPAnos);
            this.Controls.Add(this.NupQuantLitros);
            this.Controls.Add(this.quantAnos);
            this.Controls.Add(this.quantLitros);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            ((System.ComponentModel.ISupportInitialize)(this.NupQuantLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPAnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quantLitros;
        private System.Windows.Forms.Label quantAnos;
        private System.Windows.Forms.NumericUpDown NupQuantLitros;
        private System.Windows.Forms.NumericUpDown NUPAnos;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label valueLitro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultado;

    }
}