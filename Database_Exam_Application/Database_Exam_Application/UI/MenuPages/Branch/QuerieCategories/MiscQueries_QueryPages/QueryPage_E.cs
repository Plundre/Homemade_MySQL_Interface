using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_E : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
        string main_actor_name;
        string branch_number;

    


        string caseMenu;

        string choice;

        public QueryPage_E(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();



                MenuRender("main_actor_name:");
                Draw();
                main_actor_name = MenuUserInput();

                MenuRender("branch_number:");
                Draw();
                branch_number = MenuUserInput();


            


                ResultRender(coVidRental.branch.DataMiscQuerie_e(main_actor_name, branch_number));

                MenuRender("Run query again? (y/N)");
                Draw();
                choice = MenuUserInput();
                if(choice.ToLower() == "n" || choice == "") {
                    return;
                }
            }
        }
    }
}
