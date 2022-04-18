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
            this.cmb_Operar = new System.Windows.Forms.ComboBox();
            this.txt_OperandoDos = new System.Windows.Forms.TextBox();
            this.txt_OperandoUno = new System.Windows.Forms.TextBox();
            this.btn_Operar = new System.Windows.Forms.Button();
            this.btn_LimpiarFormulario = new System.Windows.Forms.Button();
            this.btn_CerrarFormulario = new System.Windows.Forms.Button();
            this.btn_ConvertiraBinario = new System.Windows.Forms.Button();
            this.btn_ConvertiraDecimal = new System.Windows.Forms.Button();
            this.lst_Resultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_Operar
            // 
            this.cmb_Operar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Operar.FormattingEnabled = true;
            this.cmb_Operar.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.cmb_Operar.Location = new System.Drawing.Point(307, 47);
            this.cmb_Operar.Name = "cmb_Operar";
            this.cmb_Operar.Size = new System.Drawing.Size(121, 25);
            this.cmb_Operar.TabIndex = 1;
            // 
            // txt_OperandoDos
            // 
            this.txt_OperandoDos.Location = new System.Drawing.Point(482, 47);
            this.txt_OperandoDos.Multiline = true;
            this.txt_OperandoDos.Name = "txt_OperandoDos";
            this.txt_OperandoDos.PlaceholderText = "Ingrese Número";
            this.txt_OperandoDos.Size = new System.Drawing.Size(100, 68);
            this.txt_OperandoDos.TabIndex = 2;
            // 
            // txt_OperandoUno
            // 
            this.txt_OperandoUno.Location = new System.Drawing.Point(134, 47);
            this.txt_OperandoUno.Multiline = true;
            this.txt_OperandoUno.Name = "txt_OperandoUno";
            this.txt_OperandoUno.PlaceholderText = "Ingrese Número";
            this.txt_OperandoUno.Size = new System.Drawing.Size(100, 68);
            this.txt_OperandoUno.TabIndex = 0;
            // 
            // btn_Operar
            // 
            this.btn_Operar.Location = new System.Drawing.Point(134, 138);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(100, 51);
            this.btn_Operar.TabIndex = 3;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btn_LimpiarFormulario
            // 
            this.btn_LimpiarFormulario.Location = new System.Drawing.Point(318, 138);
            this.btn_LimpiarFormulario.Name = "btn_LimpiarFormulario";
            this.btn_LimpiarFormulario.Size = new System.Drawing.Size(100, 51);
            this.btn_LimpiarFormulario.TabIndex = 4;
            this.btn_LimpiarFormulario.Text = "Limpiar";
            this.btn_LimpiarFormulario.UseVisualStyleBackColor = true;
            this.btn_LimpiarFormulario.Click += new System.EventHandler(this.btn_LimpiarFormulario_Click);
            // 
            // btn_CerrarFormulario
            // 
            this.btn_CerrarFormulario.Location = new System.Drawing.Point(482, 138);
            this.btn_CerrarFormulario.Name = "btn_CerrarFormulario";
            this.btn_CerrarFormulario.Size = new System.Drawing.Size(100, 51);
            this.btn_CerrarFormulario.TabIndex = 5;
            this.btn_CerrarFormulario.Text = "Cerrar";
            this.btn_CerrarFormulario.UseVisualStyleBackColor = true;
            this.btn_CerrarFormulario.Click += new System.EventHandler(this.CerrarFormulario_Click);
            // 
            // btn_ConvertiraBinario
            // 
            this.btn_ConvertiraBinario.Location = new System.Drawing.Point(197, 267);
            this.btn_ConvertiraBinario.Name = "btn_ConvertiraBinario";
            this.btn_ConvertiraBinario.Size = new System.Drawing.Size(143, 51);
            this.btn_ConvertiraBinario.TabIndex = 7;
            this.btn_ConvertiraBinario.Text = "Convertir a Binario";
            this.btn_ConvertiraBinario.UseVisualStyleBackColor = true;
            this.btn_ConvertiraBinario.Click += new System.EventHandler(this.btn_ConvertiraBinario_Click);
            // 
            // btn_ConvertiraDecimal
            // 
            this.btn_ConvertiraDecimal.Location = new System.Drawing.Point(392, 267);
            this.btn_ConvertiraDecimal.Name = "btn_ConvertiraDecimal";
            this.btn_ConvertiraDecimal.Size = new System.Drawing.Size(143, 51);
            this.btn_ConvertiraDecimal.TabIndex = 8;
            this.btn_ConvertiraDecimal.Text = "Convertir a Decimal";
            this.btn_ConvertiraDecimal.UseVisualStyleBackColor = true;
            this.btn_ConvertiraDecimal.Click += new System.EventHandler(this.btn_ConvertiraDecimal_Click);
            // 
            // lst_Resultado
            // 
            this.lst_Resultado.FormattingEnabled = true;
            this.lst_Resultado.ItemHeight = 17;
            this.lst_Resultado.Location = new System.Drawing.Point(602, 12);
            this.lst_Resultado.Name = "lst_Resultado";
            this.lst_Resultado.Size = new System.Drawing.Size(186, 310);
            this.lst_Resultado.TabIndex = 6;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Resultado);
            this.Controls.Add(this.btn_ConvertiraDecimal);
            this.Controls.Add(this.btn_ConvertiraBinario);
            this.Controls.Add(this.btn_CerrarFormulario);
            this.Controls.Add(this.btn_LimpiarFormulario);
            this.Controls.Add(this.btn_Operar);
            this.Controls.Add(this.txt_OperandoUno);
            this.Controls.Add(this.txt_OperandoDos);
            this.Controls.Add(this.cmb_Operar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Maxi Ruiz del curso 2°C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Operar;
        private System.Windows.Forms.TextBox txt_OperandoDos;
        private System.Windows.Forms.TextBox txt_OperandoUno;
        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Button btn_LimpiarFormulario;
        private System.Windows.Forms.Button btn_CerrarFormulario;
        private System.Windows.Forms.Button btn_ConvertiraBinario;
        private System.Windows.Forms.Button btn_ConvertiraDecimal;
        private System.Windows.Forms.ListBox lst_Resultado;
    }
}
