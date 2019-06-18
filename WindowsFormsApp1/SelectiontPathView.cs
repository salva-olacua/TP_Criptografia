using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            new EncryptView.EncryptView(textBoxPath.Text, this).Show();
            this.Hide();
        }

        private void VerifyIntegrity()
        {
            if (String.IsNullOrEmpty(textBoxPath.Text))
                throw new Exception("Elija una carpeta primero");
        }

        //Events
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogFolders.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialogFolders.SelectedPath;
            }
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
