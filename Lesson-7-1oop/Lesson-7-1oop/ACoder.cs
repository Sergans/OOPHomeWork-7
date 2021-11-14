using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_1oop
{
    public class ACoder : ICoder
    {
        public string Decode(string input)
        {
            char[] _input = input.ToCharArray();
            for(int i = 0; i < _input.Length; i++)
            {
                _input[i] = (char)(_input[i] - 1);
            }
            return new string(_input);
        }

        public string Encode(string input)
        {
            char[] _input = input.ToCharArray();
            for (int i = 0; i < _input.Length; i++)
            {
                _input[i] = (char)(_input[i] + 1);
            }
           return new string(_input);
        }
    }
}
