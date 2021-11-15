using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_1oop
{
    public class BCoder : ICoder
    {
        public string Decode(string input)
        {
            int downBegin = 'а';
            int downEnd = 'я';
            int UpBegin = 'А';
            int UpEnd = 'Я';
            char[] _input = input.ToCharArray();
            for (int i = 0; i < _input.Length; i++)
            {
                if ((_input[i] == 'я'))
                {
                    _input[i] = (char)(downBegin);
                }
                else if (_input[i] == 'Я')
                {
                    _input[i] = (char)(UpBegin);
                }
                else if (char.IsUpper(_input[i]))
                {
                    int index = (_input[i] - UpBegin)+1;
                    _input[i] = (char)(UpEnd - index);
                }
                else if (char.IsLower(_input[i]))
                {
                    int index =(_input[i] - downBegin)+1;
                    _input[i] = (char)(downEnd - index);
                }
            }
            return new string(_input);
        }
        public string Encode(string input)
        {
            int downBegin = 'а';
            int downEnd = 'я';
            int UpBegin = 'А';
            int UpEnd = 'Я';
            char[] _input = input.ToCharArray();
            for (int i = 0; i < _input.Length; i++)
            {
                if ((_input[i] == 'а'))
                {
                    _input[i] = (char)(downEnd);
                }
                else if (_input[i] == 'А')
                {
                    _input[i] = (char)(UpEnd);
                }
                else if (char.IsUpper(_input[i]))
                {
                    int index =(_input[i] - UpBegin)+1;
                    _input[i] = (char)(UpEnd - index);
                }
                else if (char.IsLower(_input[i]))
                {
                    int index =( _input[i] - downBegin)+1;
                    _input[i] = (char)(downEnd - index);
                }
            }
            return new string(_input);
        }
    }
}
