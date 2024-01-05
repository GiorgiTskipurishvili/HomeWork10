using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    //abstratct
    /*•	შექმენით აბსტრაქტული კლასი FileWorker  რომელსაც ექნება 1 პარამეტრი 
     * ფაილის მაქსიმალური ზომა,1 აბსტრაქტული პარამეტრი ფაილის გაფართოება
        და 4 მეთოდი Read(),Write(),Edit(),Delete()
        შვილ კლასში მეთოდებმა უნდა შეძლონ მშობელი კლასის მეთოდების override  
        და ასევე პარამეტრის გამოყენება 
        */
    public abstract class FileWorker
    {
        public byte maxFileSize { get;}

        //abstraqtuli parametri failis gafartoebit
        public abstract string FileExtension { get; }

        public FileWorker(byte maxFileSize)
        {
            maxFileSize = maxFileSize;
        }



        public abstract void Read(string filePath);
        public abstract void Write(string filePath, string letter);
        public abstract void Edit(string filePath, string newLetter);
        public abstract void Delete(string filePath);
        
    }
}
