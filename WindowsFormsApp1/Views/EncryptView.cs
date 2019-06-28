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
        
        public EncryptView(string _path,SelectiontPathView.SelectiontPathView _spv)
        {
            InitializeComponent();
            this.InitialContext(_path,_spv);
        }

        //Helpful Methods
        private void InitialContext(string _path,SelectiontPathView.SelectiontPathView _spv)
        {
            spv = _spv;
            this.DisabledAndSetTextBox(textBoxPathToSave,_path);
            this.FormClosing += (sender,e) => Application.Exit();
            //this.FormClosing += CloseApp;
        }

        private void SetTextboxText(TextBox textBox, string text) => textBox.Text = text;
        
        private void DisableTextbox(TextBox textBox) => textBox.Enabled = false;

        private void DisabledAndSetTextBox(TextBox textBox,string text)
        {
            this.DisableTextbox(textBox);
            this.SetTextboxText(textBox,text);
        }

        private StreamReader OpenStreamReader(OpenFileDialog openFile) => new StreamReader(@openFile.FileName);

        private void CloseStreamReader(StreamReader reader) => reader.Close();


        //Events
        //private void CloseApp(object sender, EventArgs e) => Application.Exit();

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = OpenStreamReader(openFileDialogFiles);
                    this.DisabledAndSetTextBox(textBoxFile,@openFileDialogFiles.FileName);
                    this.SetTextboxText(textBoxEncrypt,@openFileDialogFiles.FileName);
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