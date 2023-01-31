using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Leeson_Enumerable.Classwork
{
    public interface IPerson
    {
        string Name { get; }
        int Id { get; }
        void Speak();
    }
}
