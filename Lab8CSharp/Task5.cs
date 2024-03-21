using System;
using System.IO;

namespace Task5
{
    class Program
    {
        public static void Main_Task5()
        {// Замість <прізвище_студента> введіть прізвище студента
            string studentSurname = "Прізвище";

            // Шлях до тимчасової теки
            string tempFolderPath = @"d:\temp\";

            // Створення папок
            string studentFolder1 = studentSurname + "1";
            string studentFolder2 = studentSurname + "2";
            Directory.CreateDirectory(Path.Combine(tempFolderPath, studentFolder1));
            Directory.CreateDirectory(Path.Combine(tempFolderPath, studentFolder2));

            // Шляхи до файлів
            string t1FilePath = Path.Combine(tempFolderPath, studentFolder1, "t1.txt");
            string t2FilePath = Path.Combine(tempFolderPath, studentFolder1, "t2.txt");
            string t3FilePath = Path.Combine(tempFolderPath, studentFolder2, "t3.txt");

            // Запис тексту в файл t1.txt
            File.WriteAllText(t1FilePath, "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>");

            // Запис тексту в файл t2.txt
            File.WriteAllText(t2FilePath, "<Комар Сергій Федорович, 2000> року народження, місце проживання <м. Київ>");

            // Читання тексту з файлів t1.txt і t2.txt
            string t1Content = File.ReadAllText(t1FilePath);
            string t2Content = File.ReadAllText(t2FilePath);

            // Запис тексту з файлів t1.txt і t2.txt в файл t3.txt
            File.WriteAllText(t3FilePath, t1Content + Environment.NewLine + t2Content);

            // Перенесення файлу t2.txt у папку <прізвище_студента>2
            string destinationFolder2 = Path.Combine(tempFolderPath, studentFolder2);
            File.Move(t2FilePath, Path.Combine(destinationFolder2, "t2.txt"));

            // Копіювання файлу t1.txt в папку <прізвище_студента>2
            File.Copy(t1FilePath, Path.Combine(destinationFolder2, "t1.txt"), true);

            // Перейменування папки <прізвище_студента>1 в ALL
            Directory.Move(Path.Combine(tempFolderPath, studentFolder1), Path.Combine(tempFolderPath, "ALL"));

            // Виведення інформації про файли папки ALL
            string[] allFiles = Directory.GetFiles(Path.Combine(tempFolderPath, "ALL"));
            foreach (string file in allFiles)
            {
                Console.WriteLine($"File Name: {Path.GetFileName(file)}");
                Console.WriteLine($"Size: {new FileInfo(file).Length} bytes");
                Console.WriteLine($"Path: {file}");
                Console.WriteLine();
            }
        }
    }
}
