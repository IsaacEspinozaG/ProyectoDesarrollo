namespace Rohtson
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_inicio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_salidas = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_gastos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.inicio1 = new Rohtson.Inicio();
            this.uc_cliente1 = new Rohtson.Uc_cliente();
            this.uc_pedidos1 = new Rohtson.uc_pedidos();
            this.uc_gastos1 = new Rohtson.uc_gastos();
            this.uc_salidas1 = new Rohtson.uc_salidas();
            this.Hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Fecha_hora = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btn_inicio);
            this.guna2Panel1.Controls.Add(this.guna2Separator4);
            this.guna2Panel1.Controls.Add(this.guna2Separator3);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.btn_salidas);
            this.guna2Panel1.Controls.Add(this.btn_gastos);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(29, 112);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(77, 384);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inicio.BackgroundImage")));
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.CheckedState.Parent = this.btn_inicio;
            this.btn_inicio.HoverState.Parent = this.btn_inicio;
            this.btn_inicio.Location = new System.Drawing.Point(12, 15);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.PressedState.Parent = this.btn_inicio;
            this.btn_inicio.Size = new System.Drawing.Size(53, 52);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Location = new System.Drawing.Point(12, 303);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(53, 10);
            this.guna2Separator4.TabIndex = 10;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(12, 229);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(53, 10);
            this.guna2Separator3.TabIndex = 9;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(12, 148);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(53, 10);
            this.guna2Separator2.TabIndex = 8;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 73);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(53, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // btn_salidas
            // 
            this.btn_salidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salidas.BackgroundImage")));
            this.btn_salidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salidas.CheckedState.Parent = this.btn_salidas;
            this.btn_salidas.HoverState.Parent = this.btn_salidas;
            this.btn_salidas.Location = new System.Drawing.Point(12, 319);
            this.btn_salidas.Name = "btn_salidas";
            this.btn_salidas.PressedState.Parent = this.btn_salidas;
            this.btn_salidas.Size = new System.Drawing.Size(53, 52);
            this.btn_salidas.TabIndex = 5;
            this.btn_salidas.Click += new System.EventHandler(this.btn_salidas_Click);
            // 
            // btn_gastos
            // 
            this.btn_gastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gastos.BackgroundImage")));
            this.btn_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gastos.CheckedState.Parent = this.btn_gastos;
            this.btn_gastos.HoverState.Parent = this.btn_gastos;
            this.btn_gastos.Location = new System.Drawing.Point(12, 245);
            this.btn_gastos.Name = "btn_gastos";
            this.btn_gastos.PressedState.Parent = this.btn_gastos;
            this.btn_gastos.Size = new System.Drawing.Size(53, 52);
            this.btn_gastos.TabIndex = 5;
            this.btn_gastos.Click += new System.EventHandler(this.btn_gastos_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.BackgroundImage")));
            this.guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 171);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(53, 52);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 89);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(53, 50);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1519, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(53, 50);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.inicio1);
            this.guna2Panel2.Controls.Add(this.uc_cliente1);
            this.guna2Panel2.Controls.Add(this.uc_pedidos1);
            this.guna2Panel2.Controls.Add(this.uc_gastos1);
            this.guna2Panel2.Controls.Add(this.uc_salidas1);
            this.guna2Panel2.Location = new System.Drawing.Point(156, 87);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1416, 718);
            this.guna2Panel2.TabIndex = 2;
            // 
            // inicio1
            // 
            this.inicio1.BackColor = System.Drawing.Color.Orange;
            this.inicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicio1.Location = new System.Drawing.Point(0, 0);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(1416, 718);
            this.inicio1.TabIndex = 2;
            // 
            // uc_cliente1
            // 
            this.uc_cliente1.BackColor = System.Drawing.Color.Orange;
            this.uc_cliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_cliente1.Location = new System.Drawing.Point(0, 0);
            this.uc_cliente1.Name = "uc_cliente1";
            this.uc_cliente1.Size = new System.Drawing.Size(1416, 718);
            this.uc_cliente1.TabIndex = 0;
            // 
            // uc_pedidos1
            // 
            this.uc_pedidos1.BackColor = System.Drawing.Color.Orange;
            this.uc_pedidos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_pedidos1.Location = new System.Drawing.Point(0, 0);
            this.uc_pedidos1.Name = "uc_pedidos1";
            this.uc_pedidos1.Size = new System.Drawing.Size(1416, 718);
            this.uc_pedidos1.TabIndex = 1;
            // 
            // uc_gastos1
            // 
            this.uc_gastos1.BackColor = System.Drawing.Color.Orange;
            this.uc_gastos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_gastos1.ForeColor = System.Drawing.Color.Black;
            this.uc_gastos1.Location = new System.Drawing.Point(0, 0);
            this.uc_gastos1.Name = "uc_gastos1";
            this.uc_gastos1.Size = new System.Drawing.Size(1416, 718);
            this.uc_gastos1.TabIndex = 3;
            // 
            // uc_salidas1
            // 
            this.uc_salidas1.BackColor = System.Drawing.Color.Orange;
            this.uc_salidas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_salidas1.Location = new System.Drawing.Point(0, 0);
            this.uc_salidas1.Name = "uc_salidas1";
            this.uc_salidas1.Size = new System.Drawing.Size(1416, 718);
            this.uc_salidas1.TabIndex = 4;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.White;
            this.Hora.Location = new System.Drawing.Point(515, 9);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(102, 50);
            this.Hora.TabIndex = 3;
            this.Hora.Text = "Hora";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(759, 12);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(116, 50);
            this.fecha.TabIndex = 4;
            this.fecha.Text = "Fecha";
            // 
            // Fecha_hora
            // 
            this.Fecha_hora.Enabled = true;
            this.Fecha_hora.Tick += new System.EventHandler(this.Fecha_hora_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(1, -26);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 147);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn_close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer Fecha_hora;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_salidas;
        private Guna.UI2.WinForms.Guna2ImageButton btn_gastos;
        private Guna.UI2.WinForms.Guna2ImageButton btn_inicio;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Inicio inicio1;
        private Uc_cliente uc_cliente1;
        private uc_pedidos uc_pedidos1;
        private uc_gastos uc_gastos1;
        private uc_salidas uc_salidas1;
    }
}

