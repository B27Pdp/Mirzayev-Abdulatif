using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_modul.Lesson2_Delegate2.Homework.States;
namespace _3_modul.Lesson2_Delegate2.Homework.Interfaces
{
    public interface IPerson
    {
        string Password { get; }
        string Login { get; }
        string Name { get; }
        int Age { get; }
        int Id { get; }
        Status Status { get; }

    }
}
