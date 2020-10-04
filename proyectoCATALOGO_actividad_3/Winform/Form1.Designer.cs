namespace Winform
{
  partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Articulos = new System.Windows.Forms.Panel();
            this.panel_Opciones = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btn_Opciones = new System.Windows.Forms.Button();
            this.panel_Productos = new System.Windows.Forms.Panel();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Articulos = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.tm_timer = new System.Windows.Forms.Timer(this.components);
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Articulos.SuspendLayout();
            this.panel_Opciones.SuspendLayout();
            this.panel_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Articulos
            // 
            this.panel_Articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.panel_Articulos.Controls.Add(this.panel_Opciones);
            this.panel_Articulos.Controls.Add(this.btn_Opciones);
            this.panel_Articulos.Controls.Add(this.panel_Productos);
            this.panel_Articulos.Controls.Add(this.btn_Articulos);
            this.panel_Articulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Articulos.Location = new System.Drawing.Point(0, 0);
            this.panel_Articulos.Name = "panel_Articulos";
            this.panel_Articulos.Size = new System.Drawing.Size(172, 421);
            this.panel_Articulos.TabIndex = 6;
            // 
            // panel_Opciones
            // 
            this.panel_Opciones.Controls.Add(this.btn_Eliminar);
            this.panel_Opciones.Controls.Add(this.btn_Modificar);
            this.panel_Opciones.Controls.Add(this.btnAgrega);
            this.panel_Opciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Opciones.Location = new System.Drawing.Point(0, 182);
            this.panel_Opciones.Name = "panel_Opciones";
            this.panel_Opciones.Size = new System.Drawing.Size(172, 130);
            this.panel_Opciones.TabIndex = 13;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 80);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(172, 39);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.White;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Modificar.FlatAppearance.BorderSize = 2;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Modificar.Location = new System.Drawing.Point(0, 40);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(172, 40);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btnAgrega
            // 
            this.btnAgrega.BackColor = System.Drawing.Color.White;
            this.btnAgrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgrega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgrega.FlatAppearance.BorderSize = 2;
            this.btnAgrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrega.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAgrega.Location = new System.Drawing.Point(0, 0);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(172, 40);
            this.btnAgrega.TabIndex = 0;
            this.btnAgrega.Text = "AGREGAR";
            this.btnAgrega.UseVisualStyleBackColor = false;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btn_Opciones
            // 
            this.btn_Opciones.BackColor = System.Drawing.Color.White;
            this.btn_Opciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Opciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Opciones.FlatAppearance.BorderSize = 2;
            this.btn_Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Opciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Opciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Opciones.Location = new System.Drawing.Point(0, 118);
            this.btn_Opciones.Name = "btn_Opciones";
            this.btn_Opciones.Size = new System.Drawing.Size(172, 64);
            this.btn_Opciones.TabIndex = 11;
            this.btn_Opciones.Text = "OPCIONES";
            this.btn_Opciones.UseVisualStyleBackColor = false;
            this.btn_Opciones.Click += new System.EventHandler(this.btn_Opciones_Click);
            // 
            // panel_Productos
            // 
            this.panel_Productos.Controls.Add(this.btn_Listar);
            this.panel_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Productos.Location = new System.Drawing.Point(0, 57);
            this.panel_Productos.Name = "panel_Productos";
            this.panel_Productos.Size = new System.Drawing.Size(172, 61);
            this.panel_Productos.TabIndex = 12;
            // 
            // btn_Listar
            // 
            this.btn_Listar.BackColor = System.Drawing.Color.White;
            this.btn_Listar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Listar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Listar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Listar.FlatAppearance.BorderSize = 2;
            this.btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Listar.Location = new System.Drawing.Point(0, 0);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(172, 55);
            this.btn_Listar.TabIndex = 0;
            this.btn_Listar.Text = "DETALLES ARTICULOS";
            this.btn_Listar.UseVisualStyleBackColor = false;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Articulos
            // 
            this.btn_Articulos.BackColor = System.Drawing.Color.White;
            this.btn_Articulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Articulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Articulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Articulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Articulos.FlatAppearance.BorderSize = 2;
            this.btn_Articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Articulos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Articulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Articulos.Location = new System.Drawing.Point(0, 0);
            this.btn_Articulos.Name = "btn_Articulos";
            this.btn_Articulos.Size = new System.Drawing.Size(172, 57);
            this.btn_Articulos.TabIndex = 9;
            this.btn_Articulos.Text = "ARTICULOS";
            this.btn_Articulos.UseVisualStyleBackColor = false;
            this.btn_Articulos.Click += new System.EventHandler(this.btn_Articulos_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToAddRows = false;
            this.dgvListar.AllowUserToDeleteRows = false;
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvListar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvListar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListar.ColumnHeadersHeight = 35;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListar.EnableHeadersVisualStyles = false;
            this.dgvListar.GridColor = System.Drawing.Color.SlateGray;
            this.dgvListar.Location = new System.Drawing.Point(201, 68);
            this.dgvListar.MultiSelect = false;
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListar.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListar.Size = new System.Drawing.Size(650, 229);
            this.dgvListar.TabIndex = 9;
            this.dgvListar.SelectionChanged += new System.EventHandler(this.dgvListar_SelectionChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(874, 68);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(202, 229);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_Hora.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Hora.Location = new System.Drawing.Point(286, 324);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(95, 39);
            this.lbl_Hora.TabIndex = 11;
            this.lbl_Hora.Text = "Hora";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_Fecha.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha.Location = new System.Drawing.Point(598, 324);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(127, 39);
            this.lbl_Fecha.TabIndex = 12;
            this.lbl_Fecha.Text = "Fecha ";
            // 
            // tm_timer
            // 
            this.tm_timer.Enabled = true;
            this.tm_timer.Tick += new System.EventHandler(this.tm_timer_Tick);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(377, 28);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(332, 20);
            this.txt_Filtro.TabIndex = 14;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1098, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.panel_Articulos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(256, 187);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Articulos.ResumeLayout(false);
            this.panel_Opciones.ResumeLayout(false);
            this.panel_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Panel panel_Articulos;
        private System.Windows.Forms.Button btn_Opciones;
        private System.Windows.Forms.Panel panel_Productos;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Articulos;
        private System.Windows.Forms.Panel panel_Opciones;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Timer tm_timer;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.Label label1;
    }
}

