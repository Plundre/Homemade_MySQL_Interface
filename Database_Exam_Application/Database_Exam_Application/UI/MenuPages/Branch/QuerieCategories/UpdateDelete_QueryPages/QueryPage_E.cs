using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_E : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
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

        string result;

        public QueryPage_E(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {
                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();


                //query shit go here
                choice = MenuUserInput();
                if(choice.ToLower() == "u" || choice == "") {


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

                    result = coVidRental.branch.DataUpdateDelete_e_Update(member_number, branch_number, fullname, staff_number, street, city, state, zip_code, date_of_registry, staff_name);


                } else if(choice.ToLower() == "d") {

                    MenuRender("member_number:");
                    Draw();
                    IntegerInputSanitation(out member_number);

                    result = coVidRental.branch.DataUpdateDelete_e_Delete(member_number);

                } else {

                    return;
                }




                ResultRender(result);// <---

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
