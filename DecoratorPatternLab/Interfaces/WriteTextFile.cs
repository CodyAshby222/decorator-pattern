using System;
using System.Text;
using System.IO;

namespace DecoratorPatternLab.Components
{
    public class WriteTextFile : TextWriter
    {
        public override Encoding Encoding => throw new NotImplementedException();
        private TextWriter baseText;

        public WriteTextFile(TextWriter text)
        {
            baseText = text;
        }

        public override void WriteLine(String input)
        {
            baseText.WriteLine(input);
        }

        public override void Close()
        {
            baseText.Close();
        }
    }
}
