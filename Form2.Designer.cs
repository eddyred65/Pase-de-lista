namespace Pantalla_1_Login
{
    partial class Form2
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.textConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(504, 97);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(579, 41);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textNombreCompleto.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreCompleto.ForeColor = System.Drawing.Color.Black;
            this.textNombreCompleto.Location = new System.Drawing.Point(504, 186);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(579, 41);
            this.textNombreCompleto.TabIndex = 6;
            this.textNombreCompleto.Text = "Nombre Completo";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(504, 273);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '#';
            this.txtContraseña.Size = new System.Drawing.Size(579, 41);
            this.txtContraseña.TabIndex = 7;
            // 
            // textConfirmarContraseña
            // 
            this.textConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmarContraseña.ForeColor = System.Drawing.Color.Black;
            this.textConfirmarContraseña.Location = new System.Drawing.Point(504, 359);
            this.textConfirmarContraseña.Name = "textConfirmarContraseña";
            this.textConfirmarContraseña.PasswordChar = '#';
            this.textConfirmarContraseña.Size = new System.Drawing.Size(579, 41);
            this.textConfirmarContraseña.TabIndex = 8;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Green;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(305, 536);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(974, 81);
            this.btnCrearCuenta.TabIndex = 9;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Intoduce una Contraseña Alfanumérico, sin espacios, 8-12 caracteres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Confirma tu contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 864);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.textConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.txtCorreo);
            this.Name = "Form2";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox textConfirmarContraseña;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}