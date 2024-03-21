using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        public static void Main_Task3()
        {
            string inputFile = "D:\\2 course\\С#\\lab_8\\Lab8CSharp\\inputTask3.txt";
            string outputFile = "D:\\2 course\\С#\\lab_8\\Lab8CSharp\\outputTask3.txt";

            string inputText = File.ReadAllText(inputFile);

            string[] words = Regex.Split(inputText, @"[\s,.;!?]+");

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    string pattern = "(?i)" + words[i][0] + @"(?!.*?" + words[i][0] + ")";
                    words[i] = Regex.Replace(words[i], pattern, "");
                }
            }

            string result = string.Join(" ", words);

            File.WriteAllText(outputFile, result);

            Console.WriteLine("The result is successfully written to the output file");
        }
    }
}