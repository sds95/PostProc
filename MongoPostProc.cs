using System;
using System.Collections.Generic;
using System.Text;

namespace PostProc
{
    class MongoPostProc : IPostProc
    {
        public void DoIt()
        {
            Console.WriteLine("Записал чето в монго");
        }
    }
}
