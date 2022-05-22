using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_M : Page {
        CoVidRental.CoVidRental coVidRental;

        string first_date;
        string second_date;

        string caseMenu;

        string choice;

        public QueryPage_M(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();
                
                MenuRender("first_date"); 
                Draw(); 
                first_date = MenuUserInput();
                
                MenuRender("second_date"); 
                Draw(); 
                second_date = MenuUserInput();

                ResultRender(coVidRental.business.DataMiscQuerie_m( first_date, second_date));

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
