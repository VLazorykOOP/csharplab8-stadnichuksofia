using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        public static void Main_Task2()
        {
            string inputFile = "D:\\2 course\\С#\\lab_8\\Lab8CSharp\\inputTask2.txt";
            string outputFile = "D:\\2 course\\С#\\lab_8\\Lab8CSharp\\outputTask2.txt";

            string inputText = File.ReadAllText(inputFile);

            string pattern = @"\b[АаОоЕеУуИиІіЄєЯяЮюЇї]\w*\b";

            string result = Regex.Replace(inputText, pattern, "");

            File.WriteAllText(outputFile, result);

            Console.WriteLine("Ukrainian words starting with a vowel letter have been removed successfully");
        }
    }
}