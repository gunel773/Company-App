
using static System.Console;

namespace CompanyApp.Utilities
{
     public class Menu
    {
        private int _selection;
        private string[] _options;
        private string _input;

        public Menu( string input, string[] options)
        {
            _input = input;
            _options = options;
            _selection = 0;
        }
        public void DisplayOptions()
        {
            WriteLine(_input);
            for (int i = 0; i < _options.Length; i++)
            {
                string currentOptions = _options[i];
                string prefix;
                if (i == _selection)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($" {prefix} <<{ currentOptions}>>");

            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                
                ConsoleKeyInfo keyinfo = ReadKey(true);
                keyPressed = keyinfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selection--;
                    if (_selection == -1)
                    {
                        _selection = _options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selection++;
                    if (_selection == _options.Length)
                    {
                        _selection = 0;
                    }
                }

            }
            while (keyPressed != ConsoleKey.Enter);
            return _selection;
        }










    }
}
