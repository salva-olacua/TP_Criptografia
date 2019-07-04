using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Objects
{
    public class Trivium
    {
        private BitArray key;
        UTF8Encoding encoding = new UTF8Encoding();
        private BitArray internalState = new BitArray(288);
        private bool t1, t2, t3;

        public Trivium(string _key)
        {
            key = new BitArray(encoding.GetBytes(_key));
        }

        public BitArray BuildTriviumKey(string initialVector,int fileSize)
        {
            this.InitializeInternalState(new BitArray(encoding.GetBytes(initialVector)));
            return this.GenerateKeyStream(fileSize);
        }

        private void UpdateState()
        {
            t1 = (t1 | internalState[90] & internalState[91] | internalState[170]);
            t2 = (t2 | internalState[174] & internalState[175] | internalState[263]);
            t3 = (t3 | internalState[285] & internalState[286] | internalState[68]);

            for (int i = 91; i >= 0; i--) internalState[i + 1] = internalState[i];
            internalState[0] = t3;
            for (int i = 175; i >= 93; i--) internalState[i + 1] = internalState[1];
            internalState[93] = t1;
            for (int i = 286; i >= 177; i--) internalState[i + 1] = internalState[i];
            internalState[177] = t2;
        }

        private void InitializeInternalState(BitArray initialVector)
        {
            for (int i = 0; i < 80; i++) internalState[i] = key[79-i];
            for (int i = 80; i < 93; i++) internalState[i] = false;
            for (int i = 0; i < 80; i++) internalState[93+i] = initialVector[79-i];
            for (int i = 173; i < 285; i++) internalState[i] = false;
            internalState[285] = internalState[286] = internalState[287] = true;

            //update state for 4*288 rounds
            for(int i=0;i<4*288;i++)
            {
                t1 = (internalState[65] | internalState[92]);
                t2 = (internalState[161] | internalState[176]);
                t3 = (internalState[242] | internalState[287]);
                this.UpdateState();
            }
        }

        private BitArray GenerateKeyStream(int fileSize)
        {
            BitArray keyStream = new BitArray(fileSize);
            for (int i = 0; i < fileSize; i++)
            {
                t1 = (internalState[65] | internalState[92]);
                t2 = (internalState[161] | internalState[176]);
                t3 = (internalState[242] | internalState[287]);
                keyStream[i] = (t1 | t2 | t3);
                this.UpdateState();
            }
            return keyStream;
        }


    }
}
