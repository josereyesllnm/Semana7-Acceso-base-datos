
namespace Semana7_Acceso_base_datos
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bentrar_access_Click = new System.Windows.Forms.Button();
            this.bentrar_mysql_Click = new System.Windows.Forms.Button();
            this.bentrar_sqlserver_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLAVE:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(180, 95);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(207, 20);
            this.txtusuario.TabIndex = 2;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(180, 139);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(207, 20);
            this.txtclave.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "INICIAR SESIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bentrar_access_Click
            // 
            this.bentrar_access_Click.BackColor = System.Drawing.Color.Coral;
            this.bentrar_access_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bentrar_access_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar_access_Click.Location = new System.Drawing.Point(49, 208);
            this.bentrar_access_Click.Name = "bentrar_access_Click";
            this.bentrar_access_Click.Size = new System.Drawing.Size(85, 34);
            this.bentrar_access_Click.TabIndex = 6;
            this.bentrar_access_Click.Text = "ACCESS";
            this.bentrar_access_Click.UseVisualStyleBackColor = false;
            this.bentrar_access_Click.Click += new System.EventHandler(this.bentrar_access_Click_Click);
            // 
            // bentrar_mysql_Click
            // 
            this.bentrar_mysql_Click.BackColor = System.Drawing.Color.Coral;
            this.bentrar_mysql_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bentrar_mysql_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar_mysql_Click.Location = new System.Drawing.Point(219, 207);
            this.bentrar_mysql_Click.Name = "bentrar_mysql_Click";
            this.bentrar_mysql_Click.Size = new System.Drawing.Size(85, 35);
            this.bentrar_mysql_Click.TabIndex = 7;
            this.bentrar_mysql_Click.Text = "MySQL";
            this.bentrar_mysql_Click.UseVisualStyleBackColor = false;
            this.bentrar_mysql_Click.Click += new System.EventHandler(this.bentrar_mysql_Click_Click);
            // 
            // bentrar_sqlserver_Click
            // 
            this.bentrar_sqlserver_Click.BackColor = System.Drawing.Color.Coral;
            this.bentrar_sqlserver_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bentrar_sqlserver_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar_sqlserver_Click.Location = new System.Drawing.Point(395, 207);
            this.bentrar_sqlserver_Click.Name = "bentrar_sqlserver_Click";
            this.bentrar_sqlserver_Click.Size = new System.Drawing.Size(98, 35);
            this.bentrar_sqlserver_Click.TabIndex = 8;
            this.bentrar_sqlserver_Click.Text = "SQL SERVER";
            this.bentrar_sqlserver_Click.UseVisualStyleBackColor = false;
            this.bentrar_sqlserver_Click.Click += new System.EventHandler(this.bentrar_sqlserver_Click_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(537, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bentrar_sqlserver_Click);
            this.Controls.Add(this.bentrar_mysql_Click);
            this.Controls.Add(this.bentrar_access_Click);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bentrar_access_Click;
        private System.Windows.Forms.Button bentrar_mysql_Click;
        private System.Windows.Forms.Button bentrar_sqlserver_Click;
        private System.Windows.Forms.Button button1;
    }
}

