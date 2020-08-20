using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.String.Iskluchenye
{
    class MyOwnException : Exception // мое исключение
    {
        public MyOwnException() : base ("Это мое исключение") // конструктор
        {
           
        }
        public MyOwnException(string message) : base(message)
        {
           
        }

    }
}
