using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Objects
{
    public class Encryptor
    {
        private BitArray XORByElements(BitArray bitArrayGuide, BitArray bitArrayToOperate) => bitArrayGuide.Xor(bitArrayToOperate);

        public BitArray Encrypt(BitArray message, BitArray key) => this.XORByElements(message, key);

        public BitArray Decrypt(BitArray encrypted, BitArray key) => this.XORByElements(encrypted, key);
        
    }
}
