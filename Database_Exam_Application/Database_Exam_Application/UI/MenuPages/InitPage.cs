using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages {
    internal class InitPage : Page{
            
        int choice = 0;

        LoginPage loginPage;

        public InitPage() : base() {
            MenuRender(  "Welcome to this MySQL interface application!\n"
                        +"\n"
                        +"Please:\n"
                        +"1. Log in\n"
                        +"\n"
                        +"9. Exit\n");
            loginPage = new LoginPage();
        }

        internal override void Run() {
            while(true) {
                Draw();
                if(!int.TryParse(MenuUserInput(), out choice)) {
                    ResultRender("ERROR: Please enter an integer!");
                    continue;
                }
                switch(choice) {
                    case 1:
                        loginPage.Run();
                        break;
                    case 9:
                        return;

                    default:
                        ResultRender("ERROR: Please enter a valid option!");
                        break;
                }
            }
        }
    }
}


/*
"
"Welcome to this MySQL interface application!\n"
+"\n"
+"Please:\n"
+"1. Log in\n"
+"\n"
+"9. Exit\n"


*/
