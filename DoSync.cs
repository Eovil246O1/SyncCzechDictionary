using System;
using static System.Console;

string targetPath = @"A:\Sync\Selfeducation\Languages\TutorDict\Czech LearnCsCs.xml";
string originalPath = @"C:\Users\Eovil\AppData\Local\ABBYY\Lingvo\15.0\Dic\TutorDict\Czech LearnCsCs.xml";

Console.WriteLine("Staring to copy file...");

File.Copy(originalPath, targetPath, overwrite: true);

Console.WriteLine($"File successfully copied for {DateTime.Now.ToString("dd/MM/yyyy")}");