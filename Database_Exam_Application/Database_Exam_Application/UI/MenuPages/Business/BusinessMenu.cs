using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business {
    internal class BusinessMenu : Page{

        //CoVidRental.CoVidRental.Business dbBusinessView = new CoVidRental.CoVidRental.Business();

        //CoVidRental.CoVidRental.Branch dbBranchView;// = new CoVidRental.CoVidRental.Branch();
        CoVidRental.CoVidRental coVidRental;

        QuerieCategories.DataEntry dataEntry;
        QuerieCategories.UpdateDelete updateDelete;
        QuerieCategories.MiscQueries miscQueries;


        public BusinessMenu(CoVidRental.CoVidRental coVidRental) {
            this.coVidRental = coVidRental;
            this.dataEntry = new QuerieCategories.DataEntry(coVidRental);
            this.updateDelete = new QuerieCategories.UpdateDelete(coVidRental);
            this.miscQueries = new QuerieCategories.MiscQueries(coVidRental);
            MenuRender("\n"
                     + "    Business View:\n"
                     + "\n"
                     + "    What View would you like?\n"
                     + "\n"
                     + "    1: Data Entry\n"
                     + "    2: Data Update & Delete\n"
                     + "    3: Data Misc Queries\n"
                     + "    9: Back\n");
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
                        dataEntry.Run();
                        break;

                    case 2:
                        updateDelete.Run();
                        break;

                    case 3:
                        miscQueries.Run();
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
