using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_J : Page {
        CoVidRental.CoVidRental coVidRental;

        int supplier_number;

        string caseMenu;

        string choice;

        public QueryPage_J(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();

                MenuRender("supplier_number");
                Draw();
                IntegerInputSanitation(out supplier_number);

                ResultRender(coVidRental.business.DataMiscQuerie_j(supplier_number));

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
