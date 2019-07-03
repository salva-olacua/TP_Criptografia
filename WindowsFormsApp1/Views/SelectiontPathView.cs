using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Objects;

namespace SelectiontPathView
{
    public partial class SelectiontPathView : Form
    {
        public SelectiontPathView()
        {
            InitializeComponent();
            textBoxPath.Enabled = false;            
        }
        

        //Helpful Methods
        private void GoToEncrypt()
        {
            new EncryptView.EncryptView(textBoxPath.Text, this,textBoxKey.Text,textBoxInitialVector.Text).Show();
            this.Hide();
        }

        private void VerifyIntegrity()
        {
            this.VerifyFieldPath();
            this.VerifyFieldKey();
            this.VerifyFieldInitialVector();
        }

        private void VerifyFieldPath()
        {
            if (String.IsNullOrEmpty(textBoxPath.Text))
                throw new Exception("Elija una carpeta primero");
        }

        private void VerifyFieldKey()
        {
            if (String.IsNullOrEmpty(textBoxKey.Text)||textBoxKey.Text.Length!=10)
                throw new Exception("No completo la clave o esta es mayor a 10");
        }

        private void VerifyFieldInitialVector()
        {
            if (String.IsNullOrEmpty(textBoxInitialVector.Text) || textBoxInitialVector.Text.Length != 10)
                throw new Exception("No completo el vector inicial o este es mayor a 10");
        }

        //Events
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogFolders.ShowDialog() == DialogResult.OK)
                textBoxPath.Text = folderBrowserDialogFolders.SelectedPath;
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();

        private void buttonGoToEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                this.VerifyIntegrity();
                this.GoToEncrypt();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eleccion de carpeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
