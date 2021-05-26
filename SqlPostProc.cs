using System;
using System.Collections.Generic;
using System.Text;

namespace PostProc
{
    class SqlPostProc : IPostProc
    {
        public void DoIt()
        {
            Console.WriteLine("Записал чето в sql");
        }
    }
}
