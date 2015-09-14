using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Persistence.Security
{
    public class Cryptography : ICryptoTransform
    {
        public bool CanReuseTransform {get { throw new NotImplementedException(); } }
        public bool CanTransformMultipleBlocks{get { throw new NotImplementedException(); } }
        public int InputBlockSize{get { throw new NotImplementedException(); } }
        public int OutputBlockSize{get { throw new NotImplementedException(); } }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            throw new NotImplementedException();
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
