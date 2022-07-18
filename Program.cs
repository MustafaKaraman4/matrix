using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            operations operations = new operations();


            int[,] matris1 = new int[3, 3];
            int[,] matris2 = new int[3, 3];
            

            matris1[0,0] = 1; matris1[0,1] = 2; matris1[0,2] = 3;
            matris1[1, 0] = 4; matris1[1,1] = 5; matris1[1,2]= 6;
            matris1[2,0] = 7; matris1[2,1] = 8; matris1[2,2] = 9;

            matris2[0,0] = 10; matris2[0, 1] =10; matris2[0, 2] = 11;
            matris2[1, 0] = 12; matris2[1,1]=13; matris2[1,2]=14;
            matris2[2,0] = 15; matris2[2,1] = 16; matris2[2, 2] = 4;

            
            

            for (int satir = 0; satir < 3; satir++) {
                for (int sütün = 0; sütün < 3; sütün++)
                {
                    
                    Console.Write(matris1[satir, sütün] + matris2[satir,sütün]);
                    Console.Write("    ");
                }
                Console.WriteLine(" ");
            }
            
            
            
            
           operations.Wait();
        }
    }
}
