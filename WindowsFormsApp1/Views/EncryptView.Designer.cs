namespace EncryptView
{
    partial class EncryptView
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.openFileDialogFiles = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPathToSave = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBackToSelection = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxInitialVector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(727, 234);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(238, 35);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Seleccionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // openFileDialogFiles
            // 
            this.openFileDialogFiles.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primero seleccione el archivo a Encriptar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 620);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivo a desencriptar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encriptacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Archivo a encriptar";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(1375, 429);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(156, 35);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Encriptar";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(725, 432);
            this.textBoxEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.Size = new System.Drawing.Size(595, 26);
            this.textBoxEncrypt.TabIndex = 7;
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(727, 645);
            this.textBoxDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.Size = new System.Drawing.Size(595, 26);
            this.textBoxDecrypt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(721, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Desencriptacion";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(1375, 642);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(156, 35);
            this.buttonDecrypt.TabIndex = 10;
            this.buttonDecrypt.Text = "Desencriptar";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(560, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Los archivos generados se guardaran en :";
            // 
            // textBoxPathToSave
            // 
            this.textBoxPathToSave.Location = new System.Drawing.Point(48, 238);
            this.textBoxPathToSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToSave.Name = "textBoxPathToSave";
            this.textBoxPathToSave.Size = new System.Drawing.Size(535, 26);
            this.textBoxPathToSave.TabIndex = 12;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(1017, 238);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(512, 26);
            this.textBoxFile.TabIndex = 13;
            // 
            // buttonBackToSelection
            // 
            this.buttonBackToSelection.Location = new System.Drawing.Point(300, 800);
            this.buttonBackToSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackToSelection.Name = "buttonBackToSelection";
            this.buttonBackToSelection.Size = new System.Drawing.Size(254, 60);
            this.buttonBackToSelection.TabIndex = 14;
            this.buttonBackToSelection.Text = "Cambiar la configuracion inicial";
            this.buttonBackToSelection.UseVisualStyleBackColor = true;
            this.buttonBackToSelection.Click += new System.EventHandler(this.buttonBackToSelection_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 395);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "La clave actual es:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(26, 438);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(557, 26);
            this.textBoxKey.TabIndex = 17;
            // 
            // textBoxInitialVector
            // 
            this.textBoxInitialVector.Location = new System.Drawing.Point(26, 645);
            this.textBoxInitialVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInitialVector.Name = "textBoxInitialVector";
            this.textBoxInitialVector.Size = new System.Drawing.Size(557, 26);
            this.textBoxInitialVector.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 607);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(574, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ingrese el vector de iniciacion de 10 digitos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 71);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(58, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(538, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Encriptado con AlgoritmoTRIVIUM";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(706, 800);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(254, 60);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // EncryptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1552, 905);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxInitialVector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonBackToSelection);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxPathToSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EncryptView";
            this.Text = "TP Criptografia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialogFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPathToSave;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBackToSelection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxInitialVector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
    }
}

