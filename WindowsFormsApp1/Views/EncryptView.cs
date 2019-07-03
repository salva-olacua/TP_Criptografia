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
using WindowsFormsApp1.Objects;
using System.Collections;

namespace EncryptView
{
    public partial class EncryptView : Form
    {
        private SelectiontPathView.SelectiontPathView spv;
        private Trivium trivium;
        private Encryptor encryptor = new Encryptor();
        
        public EncryptView(string _path,SelectiontPathView.SelectiontPathView _spv,string _key,string _initialVector)
        {
            InitializeComponent();
            this.InitialContext(_path,_spv,_key,_initialVector);
        }

        //Helpful Methods
        private void InitialContext(string _path,SelectiontPathView.SelectiontPathView _spv, string _key, string _initialVector)
        {
            spv = _spv;
            this.DisabledAndSetTextBox(textBoxPathToSave,_path);
            this.DisabledAndSetTextBox(textBoxKey, _key);
            this.DisabledAndSetTextBox(textBoxInitialVector, _initialVector);
            this.InitializeAndBuildTrivium(_key,_initialVector);
            this.DisableTextbox(textBoxEncrypt);
            this.DisableTextbox(textBoxDecrypt);
        }

        private void InitializeAndBuildTrivium(string key, string initialVector)
        {
            trivium = new Trivium(key, initialVector);
            trivium.BuildTriviumKey();
        }

        private void SetTextboxText(TextBox textBox, string text) => textBox.Text = text;
        
        private void DisableTextbox(TextBox textBox) => textBox.Enabled = false;

        private void DisabledAndSetTextBox(TextBox textBox,string text)
        {
            this.DisableTextbox(textBox);
            this.SetTextboxText(textBox,text);
        }
        
        private byte[] BitToByte(BitArray bitArray)
        {
            byte[] bytes = new byte[bitArray.Length / 8];
            bitArray.CopyTo(bytes, 0);
            return bytes;
        }

        private void EncryptToFile()
        {
            BitArray messageToEncrypt = new BitArray(File.ReadAllBytes(@openFileDialogFiles.FileName));
            BitArray encrypted = encryptor.Encrypt(messageToEncrypt, trivium.GetKeyStream());

            using (FileStream fileStream = new FileStream((@textBoxPathToSave.Text + @"\ArchivoEncriptado"), FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = this.BitToByte(encrypted);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
            }
        }

        private void DecryptToFile()
        {
            BitArray messageToDecrypt = new BitArray(File.ReadAllBytes(@textBoxDecrypt.Text));
            BitArray decrypted = encryptor.Decrypt(messageToDecrypt, trivium.GetKeyStream());
            
            using (FileStream filestream = new FileStream(@textBoxPathToSave.Text + @"\ArchivoDesencriptado", FileMode.Create))
            {
                byte[] bytes = this.BitToByte(decrypted);
                filestream.Write(bytes, 0, bytes.Length);
            }
        }

        private void VerifyPathOfFileToEncrypt()
        {
            if (String.IsNullOrEmpty(textBoxEncrypt.Text))
                throw new Exception("Debe seleccionar un archivo primero.");
        }


        //Events
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.DisabledAndSetTextBox(textBoxFile,@openFileDialogFiles.FileName);
                    this.SetTextboxText(textBoxEncrypt,@openFileDialogFiles.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void buttonBackToSelection_Click(object sender, EventArgs e)
        {
            this.Close();
            spv.Show();
        }
        
        private void buttonExit_Click(object sender, EventArgs e) => Application.Exit();
        
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                this.VerifyPathOfFileToEncrypt();
                this.EncryptToFile();
                this.SetTextboxText(textBoxDecrypt,(@textBoxPathToSave.Text + @"\ArchivoEncriptado"));
                MessageBox.Show("Encriptado Exitoso.","Encriptado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                this.DecryptToFile();
                MessageBox.Show("Desencriptado Exitoso.", "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        


        //obtengo la extension del archivo
        //Console.WriteLine(Path.GetExtension(openFileDialogFiles.FileName));

    }
}