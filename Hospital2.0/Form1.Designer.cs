namespace Hospital2._0
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
            this.TableHospital = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.Label();
            this.Diagnosis = new System.Windows.Forms.Label();
            this.TxtAsignado = new System.Windows.Forms.TextBox();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.DoctorAsignado = new System.Windows.Forms.Label();
            this.TxtAdresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.viewDoctors = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // TableHospital
            // 
            this.TableHospital.AllowUserToOrderColumns = true;
            this.TableHospital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableHospital.Location = new System.Drawing.Point(40, 289);
            this.TableHospital.Name = "TableHospital";
            this.TableHospital.RowHeadersWidth = 51;
            this.TableHospital.RowTemplate.Height = 24;
            this.TableHospital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableHospital.Size = new System.Drawing.Size(705, 342);
            this.TableHospital.TabIndex = 1;
            this.TableHospital.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableHospital_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(117, 155);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 19);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(192, 155);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(129, 22);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(120, 239);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(42, 19);
            this.Edad.TabIndex = 4;
            this.Edad.Text = "Edad";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(192, 238);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(129, 22);
            this.TxtEdad.TabIndex = 5;
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresa.Location = new System.Drawing.Point(120, 199);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(56, 19);
            this.Adresa.TabIndex = 6;
            this.Adresa.Text = "Adresa";
            this.Adresa.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Diagnosis
            // 
            this.Diagnosis.AutoSize = true;
            this.Diagnosis.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis.Location = new System.Drawing.Point(432, 158);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(73, 19);
            this.Diagnosis.TabIndex = 7;
            this.Diagnosis.Text = "Diagnosis";
            // 
            // TxtAsignado
            // 
            this.TxtAsignado.Location = new System.Drawing.Point(576, 202);
            this.TxtAsignado.Name = "TxtAsignado";
            this.TxtAsignado.Size = new System.Drawing.Size(129, 22);
            this.TxtAsignado.TabIndex = 8;
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Location = new System.Drawing.Point(535, 154);
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.Size = new System.Drawing.Size(129, 22);
            this.TxtDiagnosis.TabIndex = 9;
            // 
            // DoctorAsignado
            // 
            this.DoctorAsignado.AutoSize = true;
            this.DoctorAsignado.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorAsignado.Location = new System.Drawing.Point(432, 202);
            this.DoctorAsignado.Name = "DoctorAsignado";
            this.DoctorAsignado.Size = new System.Drawing.Size(122, 19);
            this.DoctorAsignado.TabIndex = 10;
            this.DoctorAsignado.Text = "Doctor Asignado";
            // 
            // TxtAdresa
            // 
            this.TxtAdresa.Location = new System.Drawing.Point(192, 199);
            this.TxtAdresa.Name = "TxtAdresa";
            this.TxtAdresa.Size = new System.Drawing.Size(129, 22);
            this.TxtAdresa.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Añadir Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(751, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 46);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Eliminar Paciente";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(751, 544);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(111, 46);
            this.Close.TabIndex = 15;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(751, 440);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 46);
            this.Update.TabIndex = 17;
            this.Update.Text = "Actualizar Paciente";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // viewDoctors
            // 
            this.viewDoctors.Location = new System.Drawing.Point(751, 492);
            this.viewDoctors.Name = "viewDoctors";
            this.viewDoctors.Size = new System.Drawing.Size(111, 46);
            this.viewDoctors.TabIndex = 18;
            this.viewDoctors.Text = "Ver Doctores";
            this.viewDoctors.UseVisualStyleBackColor = true;
            this.viewDoctors.Click += new System.EventHandler(this.viewDoctors_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Location = new System.Drawing.Point(307, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(226, 45);
            this.Title.TabIndex = 19;
            this.Title.Text = "Hospital 2.0";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(79, 96);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(741, 32);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Filtro de nombres";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(874, 684);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.viewDoctors);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAdresa);
            this.Controls.Add(this.DoctorAsignado);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.TxtAsignado);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TableHospital);
            this.Name = "Form1";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TableHospital;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.Label Diagnosis;
        private System.Windows.Forms.TextBox TxtAsignado;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.Label DoctorAsignado;
        private System.Windows.Forms.TextBox TxtAdresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button viewDoctors;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

