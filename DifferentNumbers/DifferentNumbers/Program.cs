using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = 0;
            for (int N1=A; N1<=B; N1++)
            {
                for (int N2 = A; N2 <= B; N2++)
                {
                    for (int N3 = A;N3 <= B; N3++)
                    {
                        for ( int N4 = A;N4 <=B; N4++)
                        {
                            for(int N5 = A; N5 <= B; N5++)
                            {
                                if(A<=N1 && N1<N2 && N2<N3 && N3<N4 && N4<N5 && N5<=B)
                                {
                                    Console.WriteLine($"{N1} {N2} {N3} {N4} {N5}");
                                    C++;
                                }
                           
                            }
                        }
                    }
                
                }
            }if (C==0)
            {              
                    Console.WriteLine("No");
             
            }
        }
    }
}
