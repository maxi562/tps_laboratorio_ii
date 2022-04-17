namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.ComboOperar = new System.Windows.Forms.ComboBox();
            this.OperandoDos = new System.Windows.Forms.TextBox();
            this.OperandoUno = new System.Windows.Forms.TextBox();
            this.Operar = new System.Windows.Forms.Button();
            this.LimpiarFormulario = new System.Windows.Forms.Button();
            this.CerrarFormulario = new System.Windows.Forms.Button();
            this.ConvertiraBinario = new System.Windows.Forms.Button();
            this.ConvertiraDecimal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComboOperar
            // 
            this.ComboOperar.FormattingEnabled = true;
            this.ComboOperar.Location = new System.Drawing.Point(307, 47);
            this.ComboOperar.Name = "ComboOperar";
            this.ComboOperar.Size = new System.Drawing.Size(121, 25);
            this.ComboOperar.TabIndex = 0;
            // 
            // OperandoDos
            // 
            this.OperandoDos.Location = new System.Drawing.Point(482, 47);
            this.OperandoDos.Name = "OperandoDos";
            this.OperandoDos.Size = new System.Drawing.Size(100, 25);
            this.OperandoDos.TabIndex = 1;
            // 
            // OperandoUno
            // 
            this.OperandoUno.Location = new System.Drawing.Point(134, 47);
            this.OperandoUno.Name = "OperandoUno";
            this.OperandoUno.Size = new System.Drawing.Size(100, 25);
            this.OperandoUno.TabIndex = 2;
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(134, 138);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(100, 51);
            this.Operar.TabIndex = 3;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // LimpiarFormulario
            // 
            this.LimpiarFormulario.Location = new System.Drawing.Point(318, 138);
            this.LimpiarFormulario.Name = "LimpiarFormulario";
            this.LimpiarFormulario.Size = new System.Drawing.Size(100, 51);
            this.LimpiarFormulario.TabIndex = 4;
            this.LimpiarFormulario.Text = "Limpiar";
            this.LimpiarFormulario.UseVisualStyleBackColor = true;
            // 
            // CerrarFormulario
            // 
            this.CerrarFormulario.Location = new System.Drawing.Point(482, 138);
            this.CerrarFormulario.Name = "CerrarFormulario";
            this.CerrarFormulario.Size = new System.Drawing.Size(100, 51);
            this.CerrarFormulario.TabIndex = 5;
            this.CerrarFormulario.Text = "Cerrar";
            this.CerrarFormulario.UseVisualStyleBackColor = true;
            // 
            // ConvertiraBinario
            // 
            this.ConvertiraBinario.Location = new System.Drawing.Point(197, 267);
            this.ConvertiraBinario.Name = "ConvertiraBinario";
            this.ConvertiraBinario.Size = new System.Drawing.Size(143, 51);
            this.ConvertiraBinario.TabIndex = 6;
            this.ConvertiraBinario.Text = "Convertir a Binario";
            this.ConvertiraBinario.UseVisualStyleBackColor = true;
            // 
            // ConvertiraDecimal
            // 
            this.ConvertiraDecimal.Location = new System.Drawing.Point(392, 267);
            this.ConvertiraDecimal.Name = "ConvertiraDecimal";
            this.ConvertiraDecimal.Size = new System.Drawing.Size(143, 51);
            this.ConvertiraDecimal.TabIndex = 7;
            this.ConvertiraDecimal.Text = "Convertir a Decimal";
            this.ConvertiraDecimal.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(602, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 310);
            this.listBox1.TabIndex = 8;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ConvertiraDecimal);
            this.Controls.Add(this.ConvertiraBinario);
            this.Controls.Add(this.CerrarFormulario);
            this.Controls.Add(this.LimpiarFormulario);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.OperandoUno);
            this.Controls.Add(this.OperandoDos);
            this.Controls.Add(this.ComboOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Maxi Ruiz del curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboOperar;
        private System.Windows.Forms.TextBox OperandoDos;
        private System.Windows.Forms.TextBox OperandoUno;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button LimpiarFormulario;
        private System.Windows.Forms.Button CerrarFormulario;
        private System.Windows.Forms.Button ConvertiraBinario;
        private System.Windows.Forms.Button ConvertiraDecimal;
        private System.Windows.Forms.ListBox listBox1;
    }
}
