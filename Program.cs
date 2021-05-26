using System;
using System.Collections.Generic;

namespace PostProc
{
    class Program
    {
        static void Main(string[] args)
        {
            IPostProc mongoPostProc= new MongoPostProc();
            IPostProc sqlPostProc = new SqlPostProc();

            List<IPostProc> postProcs = new List<IPostProc>();
            postProcs.Add(mongoPostProc);
            postProcs.Add(sqlPostProc);

            IPostProc multyPostProc = new MultyPostProc(postProcs);
            
            CalcValue calc = new CalcValue(multyPostProc);
            calc.Caulculate();
            Console.ReadKey();
        }
    }
}
