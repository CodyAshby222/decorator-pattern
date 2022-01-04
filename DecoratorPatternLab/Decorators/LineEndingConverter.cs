using DecoratorPatternLab.Interfaces;
using System;
using System.IO;

namespace DecoratorPatternLab.Decorators
{
    public class LineEndingConverter : ReadTextFile
    {
        public LineEndingConverter(TextReader textReader) : base(textReader) { }
        public override string ReadToEnd()
        {
            String oldStr = base.ReadToEnd();
            String newStr = oldStr.Replace("\r\n", "\n");
            return newStr;
        }
    }
}
