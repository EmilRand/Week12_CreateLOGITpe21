using System;
using System.IO;
namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFilesFromMyList(ReplaceNumbers(GetDataFromFile()));
            UpdateMyFiles(ReplaceNumbers(GetDataFromFile()));
        }
        private static string[] GetDataFromFile()
        {
            string sourceFilePath = $@"C:\Users\opilane\samples\LOGITpe21\myFiles.txt";
            string[] dataFromFile = File.ReadAllLines(sourceFilePath);
            return dataFromFile;
        }
        private static string[] ReplaceNumbers(string[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = sourceArray[i].Replace('4', 'a').Replace('3', 'e').Replace('0', 'o').Replace('1', 'i');

            }
            return sourceArray;
        }
        private static void CreateFilesFromMyList(string[] ArrayOfNames)
        {
            string rootPath = $@"C:\Users\opilane\samples\LOGITpe21";
            for (int i = 0; i < ArrayOfNames.Length; i++)
            {
                File.Create($@"{rootPath}\{ArrayOfNames[i]}.txt");
            }
        }
        private static void UpdateMyFiles(string[] updatedArray)
        {
            string sourceFilePath = $@"C:\Users\opilane\samples\LOGITpe21\myFiles.txt";
            File.WriteAllLines(sourceFilePath, updatedArray);

        }
    }
}