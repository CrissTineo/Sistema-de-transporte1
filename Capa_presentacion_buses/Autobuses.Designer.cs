namespace Capa_presentacion_buses
{
    partial class Autobuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autobuses));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmarca = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtmodelo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtplaca = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtaño = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcolor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(392, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de Autobus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(112, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(103, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modelo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(103, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Placa:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(506, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Año:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(506, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Color:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtmarca
            // 
            this.txtmarca.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmarca.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtmarca.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtmarca.BorderThickness = 1;
            this.txtmarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmarca.ForeColor = System.Drawing.Color.Silver;
            this.txtmarca.isPassword = false;
            this.txtmarca.Location = new System.Drawing.Point(179, 157);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(250, 44);
            this.txtmarca.TabIndex = 2;
            this.txtmarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmarca_KeyPress);
            // 
            // txtmodelo
            // 
            this.txtmodelo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmodelo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtmodelo.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtmodelo.BorderThickness = 1;
            this.txtmodelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodelo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmodelo.ForeColor = System.Drawing.Color.Silver;
            this.txtmodelo.isPassword = false;
            this.txtmodelo.Location = new System.Drawing.Point(179, 218);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(250, 44);
            this.txtmodelo.TabIndex = 2;
            this.txtmodelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmodelo_KeyPress);
            // 
            // txtplaca
            // 
            this.txtplaca.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtplaca.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtplaca.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtplaca.BorderThickness = 1;
            this.txtplaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtplaca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtplaca.ForeColor = System.Drawing.Color.Silver;
            this.txtplaca.isPassword = false;
            this.txtplaca.Location = new System.Drawing.Point(179, 297);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(250, 44);
            this.txtplaca.TabIndex = 2;
            this.txtplaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtplaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtplaca_KeyPress);
            // 
            // txtaño
            // 
            this.txtaño.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtaño.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtaño.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtaño.BorderThickness = 1;
            this.txtaño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaño.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtaño.ForeColor = System.Drawing.Color.Silver;
            this.txtaño.isPassword = false;
            this.txtaño.Location = new System.Drawing.Point(573, 177);
            this.txtaño.Margin = new System.Windows.Forms.Padding(4);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(250, 44);
            this.txtaño.TabIndex = 2;
            this.txtaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaño.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox4_OnValueChanged);
            this.txtaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox4_KeyPress);
            // 
            // txtcolor
            // 
            this.txtcolor.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcolor.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtcolor.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtcolor.BorderThickness = 1;
            this.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcolor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcolor.ForeColor = System.Drawing.Color.Silver;
            this.txtcolor.isPassword = false;
            this.txtcolor.Location = new System.Drawing.Point(573, 262);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(250, 44);
            this.txtcolor.TabIndex = 2;
            this.txtcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox5_KeyPress);
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
            this.bunifuThinButton21.ButtonText = "ThinButton";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(869, 157);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(156, 48);
            this.bunifuThinButton21.TabIndex = 3;
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
            this.bunifuThinButton22.ButtonText = "ThinButton";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(869, 215);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(156, 48);
            this.bunifuThinButton22.TabIndex = 3;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuThinButton23.ButtonText = "ThinButton";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(869, 284);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(156, 48);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1023, 33);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Autobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1183, 710);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autobuses";
            this.Text = "Autobuses";
            this.Load += new System.EventHandler(this.Autobuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmarca;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmodelo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtplaca;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtaño;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcolor;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}