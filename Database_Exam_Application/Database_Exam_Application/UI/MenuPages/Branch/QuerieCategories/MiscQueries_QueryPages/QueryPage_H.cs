using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_H : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
        int catalog_number;
        int branch_number;


        string caseMenu;

        string choice;

        public QueryPage_H(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();

                MenuRender("catalog_number:");
                Draw();
                IntegerInputSanitation(out catalog_number);

                MenuRender("branch_number:");
                Draw();
                IntegerInputSanitation(out branch_number);

                ResultRender(coVidRental.branch.DataMiscQuerie_h(catalog_number, branch_number));

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
