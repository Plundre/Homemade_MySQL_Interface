using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.MiscQueries_QueryPages {
    internal class QueryPage_A : Page{
        CoVidRental.CoVidRental coVidRental;


        //query variables here


        string city;


        string caseMenu;

        string choice;

        public QueryPage_A(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;
            
        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();


                //query shit go here

                MenuRender("city:");
                Draw();
                city = MenuUserInput();


                
                ResultRender(coVidRental.branch.DataMiscQuerie_a(city));// <---

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
