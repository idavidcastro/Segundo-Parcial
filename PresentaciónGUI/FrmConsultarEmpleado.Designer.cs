
namespace PresentaciónGUI
{
    partial class FrmConsultarEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.CmbConsultaEstado = new System.Windows.Forms.ComboBox();
            this.TxtConsultaNombre = new System.Windows.Forms.TextBox();
            this.BtnConsultarEstado = new System.Windows.Forms.Button();
            this.BtnConsultarNombre = new System.Windows.Forms.Button();
            this.dgtEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgtEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar por Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultar por Nombre:";
            // 
            // CmbConsultaEstado
            // 
            this.CmbConsultaEstado.FormattingEnabled = true;
            this.CmbConsultaEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Todos"});
            this.CmbConsultaEstado.Location = new System.Drawing.Point(346, 52);
            this.CmbConsultaEstado.Name = "CmbConsultaEstado";
            this.CmbConsultaEstado.Size = new System.Drawing.Size(151, 28);
            this.CmbConsultaEstado.TabIndex = 2;
            // 
            // TxtConsultaNombre
            // 
            this.TxtConsultaNombre.Location = new System.Drawing.Point(346, 88);
            this.TxtConsultaNombre.Name = "TxtConsultaNombre";
            this.TxtConsultaNombre.Size = new System.Drawing.Size(151, 27);
            this.TxtConsultaNombre.TabIndex = 3;
            // 
            // BtnConsultarEstado
            // 
            this.BtnConsultarEstado.Location = new System.Drawing.Point(535, 55);
            this.BtnConsultarEstado.Name = "BtnConsultarEstado";
            this.BtnConsultarEstado.Size = new System.Drawing.Size(109, 29);
            this.BtnConsultarEstado.TabIndex = 4;
            this.BtnConsultarEstado.Text = "Consultar";
            this.BtnConsultarEstado.UseVisualStyleBackColor = true;
            this.BtnConsultarEstado.Click += new System.EventHandler(this.BtnConsultarEstado_Click);
            // 
            // BtnConsultarNombre
            // 
            this.BtnConsultarNombre.Location = new System.Drawing.Point(535, 90);
            this.BtnConsultarNombre.Name = "BtnConsultarNombre";
            this.BtnConsultarNombre.Size = new System.Drawing.Size(109, 29);
            this.BtnConsultarNombre.TabIndex = 5;
            this.BtnConsultarNombre.Text = "Consultar";
            this.BtnConsultarNombre.UseVisualStyleBackColor = true;
            this.BtnConsultarNombre.Click += new System.EventHandler(this.BtnConsultarNombre_Click);
            // 
            // dgtEmpleados
            // 
            this.dgtEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtEmpleados.Location = new System.Drawing.Point(108, 146);
            this.dgtEmpleados.Name = "dgtEmpleados";
            this.dgtEmpleados.RowHeadersWidth = 51;
            this.dgtEmpleados.RowTemplate.Height = 29;
            this.dgtEmpleados.Size = new System.Drawing.Size(552, 372);
            this.dgtEmpleados.TabIndex = 6;
            // 
            // FrmConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.dgtEmpleados);
            this.Controls.Add(this.BtnConsultarNombre);
            this.Controls.Add(this.BtnConsultarEstado);
            this.Controls.Add(this.TxtConsultaNombre);
            this.Controls.Add(this.CmbConsultaEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultarEmpleado";
            this.Text = "Consultar Empleado";
            this.Load += new System.EventHandler(this.FrmConsultarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbConsultaEstado;
        private System.Windows.Forms.TextBox TxtConsultaNombre;
        private System.Windows.Forms.Button BtnConsultarEstado;
        private System.Windows.Forms.Button BtnConsultarNombre;
        private System.Windows.Forms.DataGridView dgtEmpleados;
    }
}