
namespace CapaVista
{
    partial class MantenimientoAlumnos
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
            this.navegador1 = new CapaVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_MantenimientoAlumno = new System.Windows.Forms.DataGridView();
            this.txt_carne = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_estatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MantenimientoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(344, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "MANTENIMIENTO ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(206, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Carné:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(192, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(179, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(514, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Teléfono Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(594, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(579, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Estatus:";
            // 
            // dgv_MantenimientoAlumno
            // 
            this.dgv_MantenimientoAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MantenimientoAlumno.Location = new System.Drawing.Point(95, 441);
            this.dgv_MantenimientoAlumno.Name = "dgv_MantenimientoAlumno";
            this.dgv_MantenimientoAlumno.RowHeadersWidth = 51;
            this.dgv_MantenimientoAlumno.RowTemplate.Height = 24;
            this.dgv_MantenimientoAlumno.Size = new System.Drawing.Size(868, 150);
            this.dgv_MantenimientoAlumno.TabIndex = 41;
            this.dgv_MantenimientoAlumno.Tag = "alumnos";
            // 
            // txt_carne
            // 
            this.txt_carne.Location = new System.Drawing.Point(291, 237);
            this.txt_carne.Name = "txt_carne";
            this.txt_carne.Size = new System.Drawing.Size(171, 22);
            this.txt_carne.TabIndex = 42;
            this.txt_carne.Tag = "carnet_alumno";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(291, 298);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 22);
            this.txt_nombre.TabIndex = 43;
            this.txt_nombre.Tag = "nombre_alumno";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(291, 360);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(171, 22);
            this.txt_direccion.TabIndex = 44;
            this.txt_direccion.Tag = "direccion_alumno";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(668, 235);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(171, 22);
            this.txt_celular.TabIndex = 45;
            this.txt_celular.Tag = "telefono_alumno";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(668, 298);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 22);
            this.txt_email.TabIndex = 46;
            this.txt_email.Tag = "email_alumno";
            // 
            // txt_estatus
            // 
            this.txt_estatus.Location = new System.Drawing.Point(668, 358);
            this.txt_estatus.Name = "txt_estatus";
            this.txt_estatus.Size = new System.Drawing.Size(171, 22);
            this.txt_estatus.TabIndex = 47;
            this.txt_estatus.Tag = "estatus_alumno";
            // 
            // MantenimientoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 603);
            this.Controls.Add(this.txt_estatus);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_carne);
            this.Controls.Add(this.dgv_MantenimientoAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "MantenimientoAlumnos";
            this.Text = "MantenimientoAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MantenimientoAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_MantenimientoAlumno;
        private System.Windows.Forms.TextBox txt_carne;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_estatus;
    }
}