namespace Hospital2._0
{
    partial class txtSearch
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.txtApeliido = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.Especialidad = new System.Windows.Forms.Label();
            this.TableDoctor = new System.Windows.Forms.DataGridView();
            this.viewDoctors = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(218, 171);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(129, 22);
            this.TxtApellido.TabIndex = 17;
            // 
            // txtApeliido
            // 
            this.txtApeliido.AutoSize = true;
            this.txtApeliido.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeliido.Location = new System.Drawing.Point(146, 171);
            this.txtApeliido.Name = "txtApeliido";
            this.txtApeliido.Size = new System.Drawing.Size(66, 19);
            this.txtApeliido.TabIndex = 16;
            this.txtApeliido.Text = "Apeliido";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(492, 170);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(129, 22);
            this.TxtEdad.TabIndex = 15;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(420, 171);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(42, 19);
            this.Edad.TabIndex = 14;
            this.Edad.Text = "Edad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(218, 127);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(129, 22);
            this.TxtNombre.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(143, 127);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 19);
            this.Nombre.TabIndex = 12;
            this.Nombre.Text = "Nombre";
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(531, 123);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(129, 22);
            this.TxtEspecialidad.TabIndex = 20;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSize = true;
            this.Especialidad.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidad.Location = new System.Drawing.Point(420, 124);
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Size = new System.Drawing.Size(92, 19);
            this.Especialidad.TabIndex = 18;
            this.Especialidad.Text = "Especialidad";
            // 
            // TableDoctor
            // 
            this.TableDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDoctor.Location = new System.Drawing.Point(46, 236);
            this.TableDoctor.Name = "TableDoctor";
            this.TableDoctor.RowHeadersWidth = 51;
            this.TableDoctor.RowTemplate.Height = 24;
            this.TableDoctor.Size = new System.Drawing.Size(725, 361);
            this.TableDoctor.TabIndex = 21;
            // 
            // viewDoctors
            // 
            this.viewDoctors.Location = new System.Drawing.Point(777, 446);
            this.viewDoctors.Name = "viewDoctors";
            this.viewDoctors.Size = new System.Drawing.Size(111, 46);
            this.viewDoctors.TabIndex = 26;
            this.viewDoctors.Text = "Ver Pacientes";
            this.viewDoctors.UseVisualStyleBackColor = true;
            this.viewDoctors.Click += new System.EventHandler(this.viewDoctors_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(777, 394);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 46);
            this.Update.TabIndex = 25;
            this.Update.Text = "Actualizar Doctor";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(777, 498);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(111, 46);
            this.Close.TabIndex = 24;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(777, 342);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 46);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Eliminar Doctor";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(777, 290);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(111, 46);
            this.add.TabIndex = 22;
            this.add.Text = "Añadir Doctor";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(147, 52);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(578, 28);
            this.textSearch.TabIndex = 27;
            this.textSearch.Text = "Filtro por Nombre";
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 631);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.viewDoctors);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.TableDoctor);
            this.Controls.Add(this.TxtEspecialidad);
            this.Controls.Add(this.Especialidad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.txtApeliido);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Nombre);
            this.Name = "txtSearch";
            this.Text = "Filtro por Nombre";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label txtApeliido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.Label Especialidad;
        private System.Windows.Forms.DataGridView TableDoctor;
        private System.Windows.Forms.Button viewDoctors;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textSearch;
    }
}