using System;
using System.IO;

namespace Task4
{
    class Program
    {
        public static void Main_Task4()
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] sequence = new int[size];

            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("a[{0}] = ", i);
                sequence[i] = Convert.ToInt32(Console.ReadLine());
            }

            string fileName = "D:\\2 course\\С#\\lab_8\\Lab8CSharp\\positive_numbers.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (int num in sequence)
                {
                    if (num > 0)
                    {
                        writer.Write(num);
                    }
                }
            }

            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine("Positive numbers in the file:");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int num = reader.ReadInt32();
                    Console.WriteLine(num);
                }
            }
        }
    }

}