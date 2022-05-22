using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_I : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
        string category;

    


        string caseMenu;

        string choice;

        public QueryPage_I(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();

                MenuRender("category:");
                Draw();
                category = MenuUserInput();

                ResultRender(coVidRental.branch.DataMiscQuerie_i(category));

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
