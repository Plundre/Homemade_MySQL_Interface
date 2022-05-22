using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database_Exam_Application.UI.MenuPages {
    internal class MainMenu : Page {

        int menuChoice;

        protected Branch.BranchMenu branchMenu;
        protected Business.BusinessMenu businessMenu;
        protected ServerCredentials credentials;

        CoVidRental.CoVidRental coVidRental;

        public MainMenu(CoVidRental.CoVidRental coVidRental, ServerCredentials credentials) : base() {
            this.credentials = credentials;
            this.coVidRental = coVidRental;
            branchMenu = new Branch.BranchMenu(this.coVidRental);
            businessMenu = new Business.BusinessMenu(this.coVidRental);
            MenuRender("\n"
                     + "    Main Menu:\n"
                     + "\n"
                     + "    What View would you like?\n"
                     + "\n"
                     + "    1: Branch View\n"
                     + "    2: Business View\n"
                     + "    9: Log out\n");

//                             + "    9: Exit";

            //contentToDraw[2] = "";

        }

        internal void SetCreds(ServerCredentials serverCredentials) {
            this.credentials = serverCredentials;
        }

        internal override void Run() {
            while(true) {
                Draw();
                if(!int.TryParse(MenuUserInput(), out menuChoice)) {
                    ResultRender("Please enter an integer!");
                    continue;
                }

                switch(menuChoice) {
                    case 1: //1: Branch View
                        branchMenu.Run();
                        break;

                    case 2: //2: Business View
                        businessMenu.Run();
                        break;

                    case 9:
                        return;

                    default:
                        ResultRender("Please enter a valid choice");
                        break;
                }
            }
        }
    }
}

//MAIN MENU::::

// "      "
//+"    What View would you like?"
//+"        "
/*
 "    1: Branch View"
+"    2: Business View"
+"    8: Log out"
+"    9: Exit"
*/
