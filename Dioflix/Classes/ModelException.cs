using System;
using System.Collections.Generic;
using System.Text;

namespace DioFlix.Classes
{
    public class ModelException : Exception
    {
        public ModelException(string msg): base(msg)
        {

        }
    }
}
