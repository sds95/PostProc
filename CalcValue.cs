using System;
using System.Collections.Generic;
using System.Text;

namespace PostProc
{
    class CalcValue
    {
        IPostProc _postProc;

        public CalcValue(IPostProc postProc)
        {
            _postProc = postProc;
        }

        public void Caulculate()
        {
            _postProc.DoIt();
        }
    }
}
