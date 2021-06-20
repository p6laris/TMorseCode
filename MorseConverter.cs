using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMorseCode
{
    class MorseConverter
    {
        public static char[][] MorseCode()
        {
            //Morse Code 
            char[][] Morse = new char[36][];
            //Alphabets
            Morse[0] = new char[] { 'A', '.', '_' };
            Morse[1] = new char[] { 'B', '_', '.', '.', '.' };
            Morse[2] = new char[] { 'C', '_', '.', '_', '.' };
            Morse[3] = new char[] { 'D', '_', '.', '.' };
            Morse[4] = new char[] { 'E', '.' };
            Morse[5] = new char[] { 'F', '.', '.', '_', '.' };
            Morse[6] = new char[] { 'G', '_', '_', '.' };
            Morse[7] = new char[] { 'H', '.', '.', '.', '.' };
            Morse[8] = new char[] { 'I', '.', '.' };
            Morse[9] = new char[] { 'J', '.', '_', '_', '_' };
            Morse[10] = new char[] { 'K', '_', '.', '_' };
            Morse[11] = new char[] { 'L', '.', '_', '.', '.' };
            Morse[12] = new char[] { 'M', '_', '_' };
            Morse[13] = new char[] { 'N', '_', '.' };
            Morse[14] = new char[] { 'O', '_', '_', '_' };
            Morse[15] = new char[] { 'P', '.', '_', '_', '.' };
            Morse[16] = new char[] { 'Q', '_', '_', '.', '_' };
            Morse[17] = new char[] { 'R', '.', '_', '.' };
            Morse[18] = new char[] { 'S', '.', '.', '.' };
            Morse[19] = new char[] { 'T', '_' };
            Morse[20] = new char[] { 'U', '.', '.', '_' };
            Morse[21] = new char[] { 'V', '.', '.', '.', '_' };
            Morse[22] = new char[] { 'W', '.', '_', '_' };
            Morse[23] = new char[] { 'X', '_', '.', '.', '_' };
            Morse[24] = new char[] { 'Y', '_', '.', '_', '_' };
            Morse[25] = new char[] { 'Z', '_', '_', '.', '.' };
            //Numerics
            Morse[27] = new char[] { '1', '.', '_', '_', '_', '_' };
            Morse[28] = new char[] { '2', '.', '.', '_', '_', '_' };
            Morse[29] = new char[] { '3', '.', '.', '.', '_', '_' };
            Morse[30] = new char[] { '4', '.', '.', '.', '.', '_' };
            Morse[31] = new char[] { '5', '.', '.', '.', '.', '.' };
            Morse[31] = new char[] { '6', '_', '.', '.', '.', '.' };
            Morse[32] = new char[] { '7', '_', '_', '.', '.', '.' };
            Morse[33] = new char[] { '8', '_', '_', '_', '.', '.' };
            Morse[34] = new char[] { '8', '_', '_', '_', '_', '.' };
            Morse[35] = new char[] { '0', '_', '_', '_', '_', '_' };

            return Morse;

        }
    }
}
