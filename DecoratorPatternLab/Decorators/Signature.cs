using DecoratorPatternLab.Components;
using System;
using System.IO;

namespace DecoratorPatternLab.Decorators
{
    public class Signature : WriteTextFile
    {
        public Signature(TextWriter textWriter) : base(textWriter){}
        public override void WriteLine(String value)
        {
            base.WriteLine(value + " - Cody Ashby " + DateTime.Now + "\r\n");
        }
    }
}
