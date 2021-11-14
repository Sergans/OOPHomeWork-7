using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_1oop
{
   public interface ICoder
    {
        string Encode(string input);
        string Decode(string input);
    }
}
