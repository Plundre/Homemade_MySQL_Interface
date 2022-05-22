using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_E : Page {
        CoVidRental.CoVidRental coVidRental;

        int member_number;
        int branch_number;
        string fullname;
        int staff_number;
        string street;
        string city;
        string state;
        string zip_code;
        string date_of_registry;
        string staff_name;

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


                MenuRender("member_number:");
                Draw();
                IntegerInputSanitation(out member_number);

                MenuRender("branch_number:");
                Draw();
                IntegerInputSanitation(out branch_number);

                MenuRender("fullname:");
                Draw();
                fullname = MenuUserInput();

                MenuRender("staff_number:");
                Draw();
                IntegerInputSanitation(out staff_number);

                MenuRender("street:");
                Draw();
                street = MenuUserInput();

                MenuRender("city:");
                Draw();
                city = MenuUserInput();

                MenuRender("state:");
                Draw();
                state = MenuUserInput();

                MenuRender("zip_code:");
                Draw();
                zip_code = MenuUserInput();

                MenuRender("date_of_registry:");
                Draw();
                date_of_registry = MenuUserInput();

                MenuRender("staff_name:");
                Draw();
                staff_name = MenuUserInput();


                ResultRender(coVidRental.branch.DataEntry_e(member_number, branch_number, fullname, staff_number, street, city, state, zip_code, date_of_registry, staff_name));

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
