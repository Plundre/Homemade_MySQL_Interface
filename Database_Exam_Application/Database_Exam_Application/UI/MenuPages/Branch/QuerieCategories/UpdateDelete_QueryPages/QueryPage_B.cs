using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_B : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here

         int staff_number;
         int branch_number;
         string fullname;
         string position;
         double salary;



        string caseMenu;

        string choice;

        string result;


        public QueryPage_B(CoVidRental.CoVidRental coVidRental, string caseMenu) {
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

                    result = coVidRental.branch.DataUpdateDelete_b_Update(staff_number,branch_number,fullname,position,salary);


                } else if(choice.ToLower() == "d") {

                    MenuRender("Staff number:");
                    Draw();
                    IntegerInputSanitation(out staff_number);

                    result = coVidRental.branch.DataUpdateDelete_b_Delete(staff_number);

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
