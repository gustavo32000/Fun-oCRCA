using System;

namespace FunçãoCRCA
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = {50 , 6.78 , 10 , 7.7 , 86 , 7.77};
            Console.WriteLine(soma(n));
        }
        static Double soma(double[] valores){
            double rs = 0;
            for(int i = 0; i < valores.Length; i++){
                rs+=valores[i];
            }
            return rs;

        }
    }
}
