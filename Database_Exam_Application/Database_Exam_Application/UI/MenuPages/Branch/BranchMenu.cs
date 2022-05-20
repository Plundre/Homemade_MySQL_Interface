using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch {
    internal class BranchMenu : Page {

        //CoVidRental.CoVidRental.Branch dbBranchView;// = new CoVidRental.CoVidRental.Branch();
        CoVidRental.CoVidRental coVidRental;
        public BranchMenu(CoVidRental.CoVidRental coVidRental) {
            this.coVidRental = coVidRental;
            MenuRender("\n"
                     + "    What View would you like?\n"
                     + "\n"
                     + "    1: Data Entry\n"
                     + "    2: Data Update/Delete\n"
                     + "    3: Data Queries\n"
                     + "    9: Log out\n");
        }


        internal override void Run() {
            int menuChoice = 9;
            while(true) { 
                Draw();
                if(!int.TryParse(MenuUserInput(), out menuChoice)) {
                    ResultRender("Please enter an integer!");
                    continue;
                }

                switch(menuChoice) {
                    case 1:


                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
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
