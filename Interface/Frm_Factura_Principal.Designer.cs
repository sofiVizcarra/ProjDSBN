﻿namespace Interface
{
    partial class Frm_Factura_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttot_boleta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnagregarcliente = new System.Windows.Forms.Button();
            this.DataGVProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscarprod = new System.Windows.Forms.Button();
            this.btnquitarprod = new System.Windows.Forms.Button();
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnBuscarGuia";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(601, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 200;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 199;
            this.label6.Text = "Guia Remision:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(515, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 33);
            this.textBox1.TabIndex = 198;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsubtotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(694, 440);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(132, 33);
            this.txtsubtotal.TabIndex = 197;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(572, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 196;
            this.label5.Text = "SUB TOTAL:";
            // 
            // txtIGV
            // 
            this.txtIGV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIGV.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(694, 479);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(132, 33);
            this.txtIGV.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(631, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 194;
            this.label4.Text = "IGV:";
            // 
            // txttot_boleta
            // 
            this.txttot_boleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttot_boleta.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot_boleta.Location = new System.Drawing.Point(694, 518);
            this.txttot_boleta.Name = "txttot_boleta";
            this.txttot_boleta.Size = new System.Drawing.Size(132, 33);
            this.txttot_boleta.TabIndex = 193;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(608, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 192;
            this.label2.Text = "TOTAL:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(739, 564);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 39);
            this.btnClear.TabIndex = 190;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(847, 564);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(165, 39);
            this.btnGrabar.TabIndex = 191;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // btnagregarcliente
            // 
            this.btnagregarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnagregarcliente.FlatAppearance.BorderSize = 0;
            this.btnagregarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarcliente.ForeColor = System.Drawing.Color.White;
            this.btnagregarcliente.Location = new System.Drawing.Point(643, 78);
            this.btnagregarcliente.Name = "btnagregarcliente";
            this.btnagregarcliente.Size = new System.Drawing.Size(50, 39);
            this.btnagregarcliente.TabIndex = 189;
            this.btnagregarcliente.Text = "+";
            this.btnagregarcliente.UseVisualStyleBackColor = false;
            // 
            // DataGVProductos
            // 
            this.DataGVProductos.AllowUserToAddRows = false;
            this.DataGVProductos.BackgroundColor = System.Drawing.Color.Olive;
            this.DataGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Nombre,
            this.Unidad,
            this.PrecioUnitario,
            this.Precio});
            this.DataGVProductos.Location = new System.Drawing.Point(133, 216);
            this.DataGVProductos.Name = "DataGVProductos";
            this.DataGVProductos.Size = new System.Drawing.Size(693, 217);
            this.DataGVProductos.TabIndex = 188;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 65;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // btnbuscarprod
            // 
            this.btnbuscarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnbuscarprod.FlatAppearance.BorderSize = 0;
            this.btnbuscarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarprod.ForeColor = System.Drawing.Color.White;
            this.btnbuscarprod.Location = new System.Drawing.Point(925, 279);
            this.btnbuscarprod.Name = "btnbuscarprod";
            this.btnbuscarprod.Size = new System.Drawing.Size(87, 39);
            this.btnbuscarprod.TabIndex = 187;
            this.btnbuscarprod.Text = "Buscar";
            this.btnbuscarprod.UseVisualStyleBackColor = false;
            // 
            // btnquitarprod
            // 
            this.btnquitarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnquitarprod.FlatAppearance.BorderSize = 0;
            this.btnquitarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitarprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitarprod.ForeColor = System.Drawing.Color.White;
            this.btnquitarprod.Location = new System.Drawing.Point(925, 434);
            this.btnquitarprod.Name = "btnquitarprod";
            this.btnquitarprod.Size = new System.Drawing.Size(87, 39);
            this.btnquitarprod.TabIndex = 186;
            this.btnquitarprod.Text = "Quitar";
            this.btnquitarprod.UseVisualStyleBackColor = false;
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAgregarproducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarproducto.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarproducto.Location = new System.Drawing.Point(925, 356);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(87, 39);
            this.btnAgregarproducto.TabIndex = 185;
            this.btnAgregarproducto.Text = "Agregar";
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(133, 82);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(490, 33);
            this.cmbcliente.TabIndex = 184;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnbuscarcliente.FlatAppearance.BorderSize = 0;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.Location = new System.Drawing.Point(702, 78);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(87, 39);
            this.btnbuscarcliente.TabIndex = 183;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(652, 15);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(342, 33);
            this.txtfecha.TabIndex = 182;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(572, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 181;
            this.label7.Text = "Fecha:";
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(95, 12);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(139, 33);
            this.txtcod.TabIndex = 179;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 180;
            this.label11.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(76, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 178;
            this.label10.Text = "RUC:";
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(133, 177);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(220, 33);
            this.txtRUC.TabIndex = 177;
            // 
            // txtDir
            // 
            this.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDir.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(133, 132);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(631, 33);
            this.txtDir.TabIndex = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 175;
            this.label3.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 174;
            this.label1.Text = "Razon Social:";
            // 
            // Frm_Factura_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1021, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttot_boleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnagregarcliente);
            this.Controls.Add(this.DataGVProductos);
            this.Controls.Add(this.btnbuscarprod);
            this.Controls.Add(this.btnquitarprod);
            this.Controls.Add(this.btnAgregarproducto);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Factura_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DataGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttot_boleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnagregarcliente;
        private System.Windows.Forms.DataGridView DataGVProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnbuscarprod;
        private System.Windows.Forms.Button btnquitarprod;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}