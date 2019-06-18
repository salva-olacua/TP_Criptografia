using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;


namespace EncryptView
{
    public partial class EncryptView : Form
    {
        private SelectiontPathView.SelectiontPathView spv;
        private string path;
        
        public EncryptView(String _path,SelectiontPathView.SelectiontPathView _spv)
        {
            InitializeComponent();
            path = _path;
            spv = _spv;
        }

        //Helpful Methods
        private void SetTextBoxEncrypt(string path) => textBoxEncrypt.Text = path;

        private void SetTextBoxDecrypt(string path) => textBoxDecrypt.Text = path;

        private StreamReader OpenStreamReader(OpenFileDialog openFile) => new StreamReader(@openFile.FileName);

        private void CloseStreamReader(StreamReader stream) => stream.Close();

        
        //Events
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = OpenStreamReader(openFileDialogFiles);
                    this.SetTextBoxEncrypt(@openFileDialogFiles.FileName);
                    this.CloseStreamReader(sr);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Encryptado Exitoso.","Encriptado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            catch
            {

            }
        }

        //obtengo la extension del archivo
        //Console.WriteLine(Path.GetExtension(openFileDialogFiles.FileName));


    }
}