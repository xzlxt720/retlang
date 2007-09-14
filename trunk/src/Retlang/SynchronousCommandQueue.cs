using System;
using System.Collections.Generic;
using System.Text;

namespace Retlang
{
    public class SynchronousCommandQueue: ICommandQueue
    {
        public void Enqueue(Command command)
        {
            command();
        }
    }
}