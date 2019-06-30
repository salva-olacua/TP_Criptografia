namespace SelectiontPathView
{
    partial class SelectiontPathView
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
            this.folderBrowserDialogFolders = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonGoToEncrypt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxInitialVector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija donde guardar los archivos a encriptar y descencriptar";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(18, 138);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(137, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Seleccionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "La ruta selecionada es:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(192, 141);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(501, 20);
            this.textBoxPath.TabIndex = 3;
            // 
            // buttonGoToEncrypt
            // 
            this.buttonGoToEncrypt.Location = new System.Drawing.Point(430, 442);
            this.buttonGoToEncrypt.Name = "buttonGoToEncrypt";
            this.buttonGoToEncrypt.Size = new System.Drawing.Size(137, 23);
            this.buttonGoToEncrypt.TabIndex = 4;
            this.buttonGoToEncrypt.Text = "Ir a encriptacion";
            this.buttonGoToEncrypt.UseVisualStyleBackColor = true;
            this.buttonGoToEncrypt.Click += new System.EventHandler(this.buttonGoToEncrypt_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(95, 442);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(137, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 46);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Encriptado con AlgoritmoTRIVIUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escriba la clave de 10 digitos deseada";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(18, 245);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(501, 20);
            this.textBoxKey.TabIndex = 9;
            // 
            // textBoxInitialVector
            // 
            this.textBoxInitialVector.Location = new System.Drawing.Point(18, 361);
            this.textBoxInitialVector.Name = "textBoxInitialVector";
            this.textBoxInitialVector.Size = new System.Drawing.Size(501, 20);
            this.textBoxInitialVector.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Escriba el vector inicial de 10 digitos deseada";
            // 
            // SelectiontPathView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(699, 477);
            this.Controls.Add(this.textBoxInitialVector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGoToEncrypt);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label1);
            this.Name = "SelectiontPathView";
            this.Text = "Seleccion de almacenamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonGoToEncrypt;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxInitialVector;
        private System.Windows.Forms.Label label5;
    }
}