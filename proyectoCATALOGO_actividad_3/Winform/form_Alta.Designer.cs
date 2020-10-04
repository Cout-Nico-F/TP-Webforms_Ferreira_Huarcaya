namespace Winform
{
  partial class form_Alta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.combob_Marca = new System.Windows.Forms.ComboBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.label_Categoria = new System.Windows.Forms.Label();
            this.combob_Categoria = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.errorAlta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImagenURL = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Alta = new System.Windows.Forms.DataGridView();
            this.btn_Volver_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alta)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Nombre.Location = new System.Drawing.Point(33, 81);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(59, 14);
            this.label_Nombre.TabIndex = 0;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Descripcion.Location = new System.Drawing.Point(33, 126);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(84, 14);
            this.label_Descripcion.TabIndex = 1;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lb_Marca.Location = new System.Drawing.Point(33, 215);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(47, 14);
            this.lb_Marca.TabIndex = 2;
            this.lb_Marca.Text = "Marca";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(146, 79);
            this.txt_Nombre.MaxLength = 50;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(187, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(146, 124);
            this.txt_Descripcion.MaxLength = 150;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(321, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // combob_Marca
            // 
            this.combob_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combob_Marca.FormattingEnabled = true;
            this.combob_Marca.Location = new System.Drawing.Point(146, 213);
            this.combob_Marca.Name = "combob_Marca";
            this.combob_Marca.Size = new System.Drawing.Size(161, 21);
            this.combob_Marca.TabIndex = 5;
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Codigo.Location = new System.Drawing.Point(33, 43);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(52, 14);
            this.label_Codigo.TabIndex = 6;
            this.label_Codigo.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(146, 41);
            this.txt_Codigo.MaxLength = 50;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 1;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(146, 170);
            this.txt_Precio.MaxLength = 15;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 4;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Precio.Location = new System.Drawing.Point(33, 172);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(49, 14);
            this.label_Precio.TabIndex = 9;
            this.label_Precio.Text = "Precio";
            // 
            // label_Categoria
            // 
            this.label_Categoria.AutoSize = true;
            this.label_Categoria.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Categoria.Location = new System.Drawing.Point(33, 252);
            this.label_Categoria.Name = "label_Categoria";
            this.label_Categoria.Size = new System.Drawing.Size(71, 14);
            this.label_Categoria.TabIndex = 10;
            this.label_Categoria.Text = "Categoria";
            // 
            // combob_Categoria
            // 
            this.combob_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combob_Categoria.FormattingEnabled = true;
            this.combob_Categoria.Location = new System.Drawing.Point(146, 250);
            this.combob_Categoria.Name = "combob_Categoria";
            this.combob_Categoria.Size = new System.Drawing.Size(161, 21);
            this.combob_Categoria.TabIndex = 6;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btAceptar.FlatAppearance.BorderSize = 3;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btAceptar.Location = new System.Drawing.Point(96, 329);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(131, 57);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            this.btAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAceptar_MouseMove);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btCancelar.FlatAppearance.BorderSize = 3;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btCancelar.Location = new System.Drawing.Point(326, 329);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(120, 57);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            this.btCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCancelar_MouseMove);
            // 
            // errorAlta
            // 
            this.errorAlta.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(33, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Imagen(URL)";
            // 
            // txt_ImagenURL
            // 
            this.txt_ImagenURL.Location = new System.Drawing.Point(146, 289);
            this.txt_ImagenURL.MaxLength = 1000;
            this.txt_ImagenURL.Name = "txt_ImagenURL";
            this.txt_ImagenURL.Size = new System.Drawing.Size(321, 20);
            this.txt_ImagenURL.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.btAceptar);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ImagenURL);
            this.panel1.Controls.Add(this.label_Codigo);
            this.panel1.Controls.Add(this.label_Precio);
            this.panel1.Controls.Add(this.label_Nombre);
            this.panel1.Controls.Add(this.label_Categoria);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.label_Descripcion);
            this.panel1.Controls.Add(this.lb_Marca);
            this.panel1.Controls.Add(this.txt_Descripcion);
            this.panel1.Controls.Add(this.txt_Precio);
            this.panel1.Controls.Add(this.combob_Marca);
            this.panel1.Controls.Add(this.combob_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(824, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 398);
            this.panel1.TabIndex = 16;
            // 
            // dgv_Alta
            // 
            this.dgv_Alta.AllowUserToAddRows = false;
            this.dgv_Alta.AllowUserToDeleteRows = false;
            this.dgv_Alta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Alta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Alta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Alta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Alta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Alta.ColumnHeadersHeight = 35;
            this.dgv_Alta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Alta.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Alta.EnableHeadersVisualStyles = false;
            this.dgv_Alta.GridColor = System.Drawing.Color.SlateGray;
            this.dgv_Alta.Location = new System.Drawing.Point(38, 55);
            this.dgv_Alta.MultiSelect = false;
            this.dgv_Alta.Name = "dgv_Alta";
            this.dgv_Alta.ReadOnly = true;
            this.dgv_Alta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alta.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Alta.RowHeadersVisible = false;
            this.dgv_Alta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Alta.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Alta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Alta.Size = new System.Drawing.Size(719, 276);
            this.dgv_Alta.TabIndex = 17;
            // 
            // btn_Volver_Agregar
            // 
            this.btn_Volver_Agregar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Volver_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Volver_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Volver_Agregar.FlatAppearance.BorderSize = 3;
            this.btn_Volver_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btn_Volver_Agregar.Location = new System.Drawing.Point(304, 347);
            this.btn_Volver_Agregar.Name = "btn_Volver_Agregar";
            this.btn_Volver_Agregar.Size = new System.Drawing.Size(120, 39);
            this.btn_Volver_Agregar.TabIndex = 16;
            this.btn_Volver_Agregar.Text = "Volver";
            this.btn_Volver_Agregar.UseVisualStyleBackColor = false;
            this.btn_Volver_Agregar.Click += new System.EventHandler(this.btn_Volver_Agregar_Click);
            // 
            // form_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1340, 398);
            this.Controls.Add(this.btn_Volver_Agregar);
            this.Controls.Add(this.dgv_Alta);
            this.Controls.Add(this.panel1);
            this.Name = "form_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Articulos";
            this.Load += new System.EventHandler(this.form_Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAlta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alta)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label_Nombre;
    private System.Windows.Forms.Label label_Descripcion;
    private System.Windows.Forms.Label lb_Marca;
    private System.Windows.Forms.TextBox txt_Nombre;
    private System.Windows.Forms.TextBox txt_Descripcion;
    private System.Windows.Forms.ComboBox combob_Marca;
    private System.Windows.Forms.Label label_Codigo;
    private System.Windows.Forms.TextBox txt_Codigo;
    private System.Windows.Forms.TextBox txt_Precio;
    private System.Windows.Forms.Label label_Precio;
    private System.Windows.Forms.Label label_Categoria;
    private System.Windows.Forms.ComboBox combob_Categoria;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ErrorProvider errorAlta;
        private System.Windows.Forms.TextBox txt_ImagenURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Alta;
        private System.Windows.Forms.Button btn_Volver_Agregar;
    }
}