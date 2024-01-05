using System;

namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 128;
            var fileWorker= new DerivedFileWorker(x);



            fileWorker.Write("myFile.txt","Happy New Year!");
            fileWorker.Read("myFile.txt");
            fileWorker.Delete("myFile.txt");
            fileWorker.Edit("myFile.txt", "update letter, today 5 January");
            Console.ReadKey();
        }
    }
}
