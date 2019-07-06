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
        
        public EncryptView(string _path,SelectiontPathView.SelectiontPathView _spv,string _key)
        {
            InitializeComponent();
            this.InitialContext(_path,_spv,_key);
        }

        //Helpful Methods
        private void InitialContext(string _path,SelectiontPathView.SelectiontPathView _spv, string _key)
        {
            spv = _spv;
            this.DisabledAndSetTextBox(textBoxPathToSave,_path);
            this.DisabledAndSetTextBox(textBoxKey, _key);
            this.DisableTextbox(textBoxEncrypt);
            this.DisableTextbox(textBoxDecrypt);
            InitializeTrivium(_key);
        }

        private void InitializeTrivium(string key)=> trivium = new Trivium(key);

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
            BitArray encrypted = encryptor.Encrypt(messageToEncrypt, trivium.BuildTriviumKeyStream(textBoxInitialVector.Text,messageToEncrypt.Length));

            using (FileStream fileStream = new FileStream((@textBoxPathToSave.Text + @"\ArchivoEncriptado"), FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = this.BitToByte(encrypted);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
            }
        }

        private void EncryptBMP()
        {
            byte[] data;
            byte[] data2;
            using (FileStream fs = new FileStream(@openFileDialogFiles.FileName, FileMode.Open, FileAccess.Read))
            {
                int fileSize = (int)fs.Length;
                data2 = new byte[fileSize];
                fs.Read(data2,0, fileSize);
                data = new byte[fileSize-54];
                for (int i = 0; i < data.Length; i++) data.SetValue(data2.GetValue(54+i),i);
            }
            
            BitArray messageToEncrypt = new BitArray(data);
            BitArray encrypted = encryptor.Encrypt(messageToEncrypt, trivium.BuildTriviumKeyStream(textBoxInitialVector.Text,messageToEncrypt.Length));

            using (FileStream fileStream = new FileStream((@textBoxPathToSave.Text + @"\ArchivoEncriptado.BMP"), FileMode.Create, FileAccess.Write))
            {
                byte[] encryptedBytes = this.BitToByte(encrypted);
                for (int i = 0; i < encryptedBytes.Length; i++) data2.SetValue(encryptedBytes.GetValue(i), (54 + i));
                fileStream.Write(data2,0,data2.Length);                
            }

        }

        private void DecryptToFile()
        {
            BitArray messageToDecrypt = new BitArray(File.ReadAllBytes(@textBoxDecrypt.Text));
            BitArray decrypted = encryptor.Decrypt(messageToDecrypt, trivium.BuildTriviumKeyStream(textBoxInitialVector.Text,messageToDecrypt.Length));
            
            using (FileStream filestream = new FileStream(@textBoxPathToSave.Text + @"\ArchivoDesencriptado", FileMode.Create))
            {
                byte[] bytes = this.BitToByte(decrypted);
                filestream.Write(bytes, 0, bytes.Length);
            }
        }

        private void DecryptBMP()
        {
            byte[] data;
            byte[] data2;
            int fileSize;
            using (FileStream fs = new FileStream(@textBoxDecrypt.Text, FileMode.Open, FileAccess.Read))
            {
                fileSize = (int)fs.Length;
                data2 = new byte[fileSize];
                fs.Read(data2, 0, fileSize);
                data = new byte[fileSize - 54];
                for (int i = 0; i < data.Length; i++) data[i] = data2[54+i];
            }

            BitArray messageToDecrypt = new BitArray(data);
            BitArray decrypted = encryptor.Decrypt(messageToDecrypt, trivium.BuildTriviumKeyStream(textBoxInitialVector.Text,messageToDecrypt.Length));

            using (FileStream fileStream = new FileStream((@textBoxPathToSave.Text + @"\ArchivoDesencriptado.BMP"), FileMode.Create, FileAccess.Write))
            {
                byte[] decryptedBytes = this.BitToByte(decrypted);
                for (int i = 0; i < decryptedBytes.Length; i++) data2[54 + i] = decryptedBytes[i];
                fileStream.Write(data2, 0, data2.Length);
            }
        }

        private void VerifyPathOfFileToEncrypt()
        {
            if (String.IsNullOrEmpty(textBoxEncrypt.Text))
                throw new Exception("Debe seleccionar un archivo primero.");
        }

        private void VerifyInitialVector()
        {
            if (String.IsNullOrEmpty(textBoxInitialVector.Text)|| textBoxInitialVector.Text.Length!=10)
                throw new Exception("Debe agregar un vector de inicializacion de 10 digitos.");
        }

        private void CleanInitialVector()
        {
            this.SetTextboxText(textBoxInitialVector,"");
            textBoxInitialVector.Enabled = true;
        }

        private void EncrypAccordingToTheFile()
        {
            if (Path.GetExtension(@openFileDialogFiles.FileName) == ".BMP")
            {
                this.EncryptBMP();
                this.SetTextboxText(textBoxDecrypt, (@textBoxPathToSave.Text + @"\ArchivoEncriptado.BMP"));
            }
            else
            {
                this.EncryptToFile();
                this.SetTextboxText(textBoxDecrypt, (@textBoxPathToSave.Text + @"\ArchivoEncriptado"));
            }
        }

        private void DecrypAccordingToTheFile()
        {
            if (Path.GetExtension(@textBoxDecrypt.Text) == ".BMP")
                this.DecryptBMP();
            else
                this.DecryptToFile();
        }

        
        //Events
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.VerifyInitialVector();
                    this.DisabledAndSetTextBox(textBoxFile,@openFileDialogFiles.FileName);
                    this.SetTextboxText(textBoxEncrypt,@openFileDialogFiles.FileName);
                    this.DisableTextbox(textBoxInitialVector);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Advertencia de clave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.VerifyInitialVector();
                this.VerifyPathOfFileToEncrypt();
                this.EncrypAccordingToTheFile();
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
                this.VerifyInitialVector();
                this.DecrypAccordingToTheFile();
                MessageBox.Show("Desencriptado Exitoso.", "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CleanInitialVector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}