using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_WorkingWithDI// first file  starting here

{// we are going to do dependancy test here
    public interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }
}
