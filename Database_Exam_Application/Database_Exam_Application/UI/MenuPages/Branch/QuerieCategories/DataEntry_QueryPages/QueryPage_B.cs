using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_B : Page {

        CoVidRental.CoVidRental coVidRental;


        int staff_number;
        int branch_number;
        string fullname;
        string position;
        double salary;

        string caseMenu;
        string choice;


        public QueryPage_B(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {

            while(true) {


                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();


                MenuRender("Staff number:");
                Draw();
                IntegerInputSanitation(out staff_number);

                MenuRender("Branch number:");
                Draw();
                IntegerInputSanitation(out branch_number);

                MenuRender("Full name:");
                Draw();
                fullname = MenuUserInput();

                MenuRender("Position:");
                Draw();
                position = MenuUserInput();

                MenuRender("Salary:");
                Draw();
                DoubleInputSanitation(out salary);


                ResultRender(coVidRental.branch.DataEntry_b(staff_number, branch_number, fullname, position, salary));

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
