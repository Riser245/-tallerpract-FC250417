namespace TallerPractico_FC250417
{
    partial class Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiantes));
            this.txtnombape = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btndest = new System.Windows.Forms.Button();
            this.btnpromgen = new System.Windows.Forms.Button();
            this.dgbestudiantes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbestudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombape
            // 
            this.txtnombape.BackColor = System.Drawing.Color.White;
            this.txtnombape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombape.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnombape.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtnombape.Location = new System.Drawing.Point(25, 12);
            this.txtnombape.Name = "txtnombape";
            this.txtnombape.PlaceholderText = "Nombre y apellido";
            this.txtnombape.Size = new System.Drawing.Size(638, 20);
            this.txtnombape.TabIndex = 0;
            this.txtnombape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcarrera
            // 
            this.txtcarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarrera.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcarrera.Location = new System.Drawing.Point(25, 86);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.PlaceholderText = "Carrera Estudiante";
            this.txtcarrera.Size = new System.Drawing.Size(638, 20);
            this.txtcarrera.TabIndex = 1;
            this.txtcarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcarrera.TextChanged += new System.EventHandler(this.txtcarrera_TextChanged);
            // 
            // txtnota
            // 
            this.txtnota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnota.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnota.Location = new System.Drawing.Point(25, 237);
            this.txtnota.Name = "txtnota";
            this.txtnota.PlaceholderText = "Calificacion";
            this.txtnota.Size = new System.Drawing.Size(638, 20);
            this.txtnota.TabIndex = 2;
            this.txtnota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmateria
            // 
            this.txtmateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmateria.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmateria.Location = new System.Drawing.Point(25, 161);
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.PlaceholderText = "Materia";
            this.txtmateria.Size = new System.Drawing.Size(638, 20);
            this.txtmateria.TabIndex = 3;
            this.txtmateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagregar.Location = new System.Drawing.Point(732, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(331, 56);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar estudiante";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmostrar.Location = new System.Drawing.Point(732, 72);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(331, 56);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar estudiantes ";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btndest
            // 
            this.btndest.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndest.Location = new System.Drawing.Point(732, 147);
            this.btndest.Name = "btndest";
            this.btndest.Size = new System.Drawing.Size(331, 56);
            this.btndest.TabIndex = 6;
            this.btndest.Text = "Mostrar estudiantes destacados";
            this.btndest.UseVisualStyleBackColor = true;
            this.btndest.Click += new System.EventHandler(this.btndest_Click);
            // 
            // btnpromgen
            // 
            this.btnpromgen.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpromgen.Location = new System.Drawing.Point(732, 223);
            this.btnpromgen.Name = "btnpromgen";
            this.btnpromgen.Size = new System.Drawing.Size(331, 56);
            this.btnpromgen.TabIndex = 7;
            this.btnpromgen.Text = "Mostrar promedio general";
            this.btnpromgen.UseVisualStyleBackColor = true;
            this.btnpromgen.Click += new System.EventHandler(this.btnpromgen_Click);
            // 
            // dgbestudiantes
            // 
            this.dgbestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbestudiantes.Location = new System.Drawing.Point(12, 285);
            this.dgbestudiantes.Name = "dgbestudiantes";
            this.dgbestudiantes.RowTemplate.Height = 25;
            this.dgbestudiantes.Size = new System.Drawing.Size(672, 279);
            this.dgbestudiantes.TabIndex = 8;
            this.dgbestudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbestudiantes_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(673, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(673, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(673, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(763, 320);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(251, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Promedio General=";
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblpromedio.Location = new System.Drawing.Point(853, 379);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 24);
            this.lblpromedio.TabIndex = 14;
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 576);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbestudiantes);
            this.Controls.Add(this.btnpromgen);
            this.Controls.Add(this.btndest);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtmateria);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtnombape);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Estudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbestudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtnombape;
        private TextBox txtcarrera;
        private TextBox txtnota;
        private TextBox txtmateria;
        private Button btnagregar;
        private Button btnmostrar;
        private Button btndest;
        private Button btnpromgen;
        private DataGridView dgbestudiantes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label lblpromedio;
    }
}