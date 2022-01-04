using DecoratorPatternLab.Components;
using DecoratorPatternLab.Decorators;
using DecoratorPatternLab.Interfaces;
using System;
using System.IO;

namespace DecoratorPatternLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteTextFile fileWriter = new Signature(new CharacterShifterUp(new StreamWriter("abc.txt", true)));
            fileWriter.WriteLine("Hello there! How is it going?");
            fileWriter.Close();

            /*
             * 3.English Answer: What happens in the written file when you wrap decorator 1 (Signature) in decorator 2 (CharacterShifterUp)?  What about decorator 2 in 1?
             * 
             * So I actually took the time to test it and noticed a pattern. When I have the decorator similar to line 14 it will add the signature, then shift the characters up.
             * However, If I were to reverse that it should shift the character up and then add the signature. The problem with that is when I go to use the fileReader I have below
             * it will shift the date characters down which is incorrect.
             * 
             */

            ReadTextFile fileReader = new CharacterShifterDown(new LineEndingConverter(new StreamReader("abc.txt")));
            Console.WriteLine(fileReader.ReadToEnd());
            fileReader.Close();
        }
    }
}
