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
        // perfom xor to both member of the collections, if the length of bitArrayToOperate is smaller,
        //it repeat the collection
        private BitArray XORByElements(BitArray bitArrayGuide, BitArray bitArrayToOperate)
        {
            int j = 0,tamGuide=bitArrayGuide.Length;
            BitArray result = new BitArray(tamGuide);
            for (int i = 0; i < tamGuide; i++)
            {
                if (j < bitArrayToOperate.Length) j = 0;
                result[i] = (bitArrayGuide[i] ^ bitArrayToOperate[j]);
                j++;
            }
            return result;
        }

        public BitArray Encrypt(BitArray message, BitArray key) => this.XORByElements(message, key);

        public BitArray Decrypt(BitArray encrypted, BitArray key) => this.Encrypt(encrypted, key);
        
    }
}
