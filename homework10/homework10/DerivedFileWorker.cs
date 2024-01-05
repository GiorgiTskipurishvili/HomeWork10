using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class DerivedFileWorker : FileWorker
    {
        public DerivedFileWorker(byte maxFileSize) : base(maxFileSize)
        {
        }

        
        public override string FileExtension => "txt";

        public override void Write(string filePath, string letter)
        {
            //Console.WriteLine($"I Can write {FileExtension} file with max storage {maxFileSize}");
            Console.Write("I Can write from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{maxFileSize}");
            Console.ResetColor();

        }

        public override void Read(string filePath)
        {
            //Console.WriteLine($"I Can read {FileExtension} file with max storage {maxFileSize}");
            Console.Write("I Can read to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{maxFileSize}");
            Console.ResetColor();
        }

        public override void Delete(string filePath)
        {
            //Console.WriteLine($"I Can delete {FileExtension} file with max storage {maxFileSize}");
            Console.Write("I Can delete ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{maxFileSize}");
            Console.ResetColor();
        }

        public override void Edit(string filePath, string newLetter)
        {
            //Console.WriteLine($"I Can edit {FileExtension} file with max storage {maxFileSize}");
            Console.Write("I Can edit ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{FileExtension} ");
            Console.ResetColor();
            Console.Write($"file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{maxFileSize}");
            Console.ResetColor();
        }


    }
}
