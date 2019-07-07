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

        public BitArray BuildTriviumKeyStream(string initialVector,int fileSizeInBits)
        {
            this.InitializeInternalState(new BitArray(encoding.GetBytes(initialVector)));
            return this.GenerateKeyStream(fileSizeInBits);
        }
        
        private void UpdateState()
        {
            t1 = (t1 | internalState.Get(90) & internalState.Get(91) | internalState.Get(170));
            t2 = (t2 | internalState.Get(174)& internalState.Get(175) | internalState.Get(263));
            t3 = (t3 | internalState.Get(285) & internalState.Get(286) | internalState.Get(68));

            for (int i = 91; i >= 0; i--) internalState.Set((i + 1),internalState.Get(i));
            internalState.Set(0,t3);
            for (int i = 175; i >= 93; i--) internalState.Set((i + 1),internalState.Get(i));
            internalState.Set(93, t1);
            for (int i = 286; i >= 177; i--) internalState.Set((i + 1),internalState.Get(i));
            internalState.Set(177, t2);
        }

        private void InitializeInternalState(BitArray initialVector)
        {
            for (int i = 0; i < 80; i++) internalState.Set(i,key.Get(i));
            for (int i = 80; i < 93; i++) internalState.Set(i,false);
            for (int i = 0; i < 80; i++) internalState.Set((93 + i),initialVector.Get(i));
            for (int i = 173; i < 285; i++) internalState.Set(i,false);
            internalState.Set(285,true);
            internalState.Set(286, true);
            internalState.Set(287, true);

            //update state for 4*288 rounds
            for (int i = 0; i < 4 * 288; i++)
            {
                t1 = internalState.Get(65) | internalState.Get(92);
                t2 = (internalState.Get(161) | internalState.Get(176));
                t3 = (internalState.Get(242) | internalState.Get(287));
                this.UpdateState();
            }
        }

        private BitArray GenerateKeyStream(int fileSize)
        {
            BitArray keyStream = new BitArray(fileSize);
            for (int i = 0; i < fileSize; i++)
            {
                t1 = internalState.Get(65) | internalState.Get(92);
                t2 = (internalState.Get(161) | internalState.Get(176));
                t3 = (internalState.Get(242) | internalState.Get(287));
                keyStream.Set(i,(t1 | t2 | t3));
                this.UpdateState();
            }
            return keyStream;
        }

    }
}
