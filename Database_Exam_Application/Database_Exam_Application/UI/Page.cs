using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI {
    /// <summary>
    /// Represents a UI page
    /// </summary>
    internal abstract class Page {



        protected List<string> menuContentToDraw = new List<string>();
        protected List<string> resultToDraw = new List<string>();

        protected int lastEnteredMenuLine = 0;
        protected int lastEnteredResultLine = 0;

        protected int window_Width = Console.WindowWidth;
        protected int window_Height = Console.WindowHeight;

        protected int menu_Width;
        protected int menu_Height;

        protected int result_Width;
        protected int result_Height;


        protected float menuToResultRel = (float)0.4;


        //abstract public string ContentToDraw { set;}

        //abstract public string UserInput();

        public Page() {
            menu_Width = window_Width;
            menu_Height = (int)Math.Truncate(window_Height * menuToResultRel);
            result_Width = window_Width;
            result_Height = window_Height - menu_Height;
            
        }



        internal void MenuRender(string content) {
            menuContentToDraw.Add(content);
            //Console.WriteLine(content);
        }

        internal void MenuRenderClear() { 
            menuContentToDraw.Clear();
        }

        internal void MenuScreenClear() {
            char[] blank = new char[menu_Width];
            char[] divideLine = new char[menu_Width];
            for(int i = 0; i < blank.Length; i++) {
                blank[i] = ' ';
            }
            for(int i = 0; i < divideLine.Length; i++) {
                divideLine[i] = '-';
            }

            for(int i = 0; i < menu_Height-3; i++) {
                Console.WriteLine(blank);
            }
            Console.WriteLine(divideLine);
            Console.WriteLine(blank);
            Console.WriteLine(divideLine);
            
        }


        internal void ResultRender(string resultToPrint) {
            resultToDraw.Add(resultToPrint);
            //Console.WriteLine(resultToPrint);
        }

        internal void ResultRenderClear() {
            resultToDraw.Clear();
        }




        internal string MenuUserInput() {
            Console.SetCursorPosition(0,menu_Height-2);
            string input = " ";
            input = Console.ReadLine();
            return input;
        }

        internal void Draw() {
            Console.Clear();
            
            Console.SetCursorPosition(0,menu_Height);
            foreach(var element in this.resultToDraw) {
                Console.WriteLine(element);
            }
            lastEnteredResultLine = Console.GetCursorPosition().Top;

            Console.SetCursorPosition(0, 0);
            MenuScreenClear();
            Console.SetCursorPosition(0, 0);
            foreach(var element in this.menuContentToDraw) {
                Console.WriteLine(element);
            }
            lastEnteredMenuLine = Console.GetCursorPosition().Top;
            
        }

        internal void FullClear() { 
            Console.Clear();
        }

        internal void IntegerInputSanitation(out int output) {
            while(true) {
                Draw();
                if(int.TryParse(MenuUserInput(), out output)) {
                    break;
                }
                ResultRender("ERROR: Please enter an integer!");
            }
        }

        internal void DoubleInputSanitation(out double output) {
            while(true) {
                Draw();
                if(double.TryParse(MenuUserInput(), out output)) {
                    break;
                }
                ResultRender("ERROR: Please enter a valid double precision floating point value (decimal or integer)!");
            }
        }

        abstract internal void Run();
        
    }


}
