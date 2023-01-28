using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Lesson_Tuple_Nullable.Homework.task1
{
    public interface IPerson<TId> where TId : struct
    {
        TId Id { get; set; }
        byte Age { get; set; }
        string? Name { get; set; }
    }
}
