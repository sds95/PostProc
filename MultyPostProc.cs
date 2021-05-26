using System;
using System.Collections.Generic;
using System.Text;

namespace PostProc
{
    class MultyPostProc : IPostProc
    {
        List<IPostProc> _listPostProc;

        public MultyPostProc(List<IPostProc> listPostProc)
        {
            _listPostProc = listPostProc;
        }

        public void DoIt()
        {
            foreach (var doit in _listPostProc)
            {
                doit.DoIt();
            }
        }
    }
}
