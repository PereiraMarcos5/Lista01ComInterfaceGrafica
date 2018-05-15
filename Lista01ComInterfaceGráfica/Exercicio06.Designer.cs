namespace Lista01ComInterfaceGráfica
{
    partial class Exercicio06
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
            this.txtNota1 = new System.Windows.Forms.NumericUpDown();
            this.txtNota2 = new System.Windows.Forms.NumericUpDown();
            this.txtNota3 = new System.Windows.Forms.NumericUpDown();
            this.txtNota4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(12, 27);
            this.txtNota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(156, 22);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.ValueChanged += new System.EventHandler(this.txtNota1_ValueChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(12, 64);
            this.txtNota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(156, 22);
            this.txtNota2.TabIndex = 1;
            this.txtNota2.ValueChanged += new System.EventHandler(this.txtNota2_ValueChanged);
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(12, 101);
            this.txtNota3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(156, 22);
            this.txtNota3.TabIndex = 2;
            this.txtNota3.ValueChanged += new System.EventHandler(this.txtNota3_ValueChanged);
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(12, 138);
            this.txtNota4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(156, 22);
            this.txtNota4.TabIndex = 3;
            this.txtNota4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            this.txtNota4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNota4_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 132);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Name = "Exercicio06";
            this.Text = "Exercicio06";
            this.Load += new System.EventHandler(this.Exercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNota1;
        private System.Windows.Forms.NumericUpDown txtNota2;
        private System.Windows.Forms.NumericUpDown txtNota3;
        private System.Windows.Forms.NumericUpDown txtNota4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}