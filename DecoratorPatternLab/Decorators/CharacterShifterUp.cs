using DecoratorPatternLab.Components;
using System;
using System.IO;

namespace DecoratorPatternLab.Decorators
{
    public class CharacterShifterUp : WriteTextFile
    {
        public CharacterShifterUp(TextWriter textWriter) : base(textWriter){}
        public override void WriteLine(String value)
        {
            String decryptedStr = "";

            for (int i = 0; i < value.Length; i++)
            {
                decryptedStr += (char)(value[i] + 1);
            }

            base.WriteLine(decryptedStr);
        }
    }
}
