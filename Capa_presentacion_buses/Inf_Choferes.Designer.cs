using System;

namespace Capa_presentacion_buses
{
    partial class Inf_Choferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inf_Choferes));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcedula = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtapellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Atras1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de chofer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateNacimiento);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.txtcedula);
            this.panel2.Controls.Add(this.txtapellido);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(51, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 438);
            this.panel2.TabIndex = 3;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.CustomFormat = "short";
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(247, 243);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(166, 34);
            this.dateNacimiento.TabIndex = 3;
            this.dateNacimiento.Value = new System.DateTime(2022, 8, 7, 0, 0, 0, 0);
            this.dateNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateNacimiento_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtnombre.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtnombre.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtnombre.BorderThickness = 2;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.Silver;
            this.txtnombre.isPassword = false;
            this.txtnombre.Location = new System.Drawing.Point(42, 99);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(209, 58);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.OnValueChanged += new System.EventHandler(this.txtnombre_OnValueChanged_1);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox3_KeyPress);
            // 
            // txtcedula
            // 
            this.txtcedula.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcedula.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtcedula.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtcedula.BorderThickness = 2;
            this.txtcedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcedula.ForeColor = System.Drawing.Color.Silver;
            this.txtcedula.isPassword = false;
            this.txtcedula.Location = new System.Drawing.Point(199, 340);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(313, 55);
            this.txtcedula.TabIndex = 2;
            this.txtcedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcedula.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox4_OnValueChanged);
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox5_KeyPress);
            // 
            // txtapellido
            // 
            this.txtapellido.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtapellido.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtapellido.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtapellido.BorderThickness = 2;
            this.txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtapellido.ForeColor = System.Drawing.Color.Silver;
            this.txtapellido.isPassword = false;
            this.txtapellido.Location = new System.Drawing.Point(342, 99);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(209, 50);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtapellido.OnValueChanged += new System.EventHandler(this.txtnombre_OnValueChanged);
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(61, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(93, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cédula:";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(427, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(56, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha de nacimiento:";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 20;
            this.ingresar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ingresar.ActiveForecolor = System.Drawing.Color.White;
            this.ingresar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "ingresar";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.SeaGreen;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 20;
            this.ingresar.IdleFillColor = System.Drawing.Color.White;
            this.ingresar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ingresar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ingresar.Location = new System.Drawing.Point(134, 555);
            this.ingresar.Margin = new System.Windows.Forms.Padding(5);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(128, 53);
            this.ingresar.TabIndex = 4;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Atras1
            // 
            this.Atras1.BackColor = System.Drawing.Color.Transparent;
            this.Atras1.Image = ((System.Drawing.Image)(resources.GetObject("Atras1.Image")));
            this.Atras1.ImageActive = null;
            this.Atras1.Location = new System.Drawing.Point(1253, 24);
            this.Atras1.Name = "Atras1";
            this.Atras1.Size = new System.Drawing.Size(45, 37);
            this.Atras1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Atras1.TabIndex = 5;
            this.Atras1.TabStop = false;
            this.Atras1.Zoom = 10;
            this.Atras1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(815, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(593, 355);
            this.dataGridView1.TabIndex = 6;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Editar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(336, 555);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(128, 53);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Eliminar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(506, 555);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(128, 53);
            this.bunifuThinButton22.TabIndex = 4;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Mostrar";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(944, 555);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(128, 53);
            this.bunifuThinButton23.TabIndex = 4;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Inf_Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1575, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Atras1);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inf_Choferes";
            this.Text = "Inf_Choferes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Atras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtnombre_OnValueChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtapellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcedula;
        private Bunifu.Framework.UI.BunifuThinButton2 ingresar;
        private Bunifu.Framework.UI.BunifuImageButton Atras1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
    }
}