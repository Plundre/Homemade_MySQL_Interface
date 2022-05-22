using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_L : Page {
        CoVidRental.CoVidRental coVidRental;

        string date_order_placed;

        string caseMenu;

        string choice;

        public QueryPage_L(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;
            
        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();

                MenuRender("date_order_placed");
                Draw();
                date_order_placed = MenuUserInput();

                ResultRender(coVidRental.business.DataMiscQuerie_l(date_order_placed));

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
