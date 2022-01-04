using System.IO;

namespace DecoratorPatternLab.Interfaces
{
    public class ReadTextFile : TextReader
    {
        private TextReader baseText;

        public ReadTextFile(TextReader text)
        {
            baseText = text;
        }

        public override string ReadToEnd()
        {
            return baseText.ReadToEnd();
        }

        public override void Close()
        {
            baseText.Close();
        }
    }
}