using DecoratorPatternLab.Interfaces;
using System;
using System.IO;

namespace DecoratorPatternLab.Decorators
{
    public class CharacterShifterDown : ReadTextFile
    {
        public CharacterShifterDown(TextReader textReader) : base(textReader){}
        public override string ReadToEnd()
        {
            String decryptedString = "";
            String encryptedString = base.ReadToEnd();

            for(int i=0; i< encryptedString.Length; i++)
            {
                decryptedString += (char)(encryptedString[i] - 1);
            }

            return decryptedString;
        }
    }
}
