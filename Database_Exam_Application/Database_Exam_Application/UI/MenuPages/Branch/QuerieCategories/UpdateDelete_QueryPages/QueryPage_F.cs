using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_F : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
        int rental_number;
        int member_number;
        string member_name;
        int video_number;
        string title;
        double daily_rental_cost;
        string date_rented;
        string date_returned;
        int branch_number;

    


        string caseMenu;

        string choice;

        string result;

        public QueryPage_F(CoVidRental.CoVidRental coVidRental, string caseMenu) {
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

                    MenuRender("rental_number:");
                    Draw();
                    IntegerInputSanitation(out rental_number);

                    MenuRender("member_number:");
                    Draw();
                    IntegerInputSanitation(out member_number);

                    MenuRender("member_name:");
                    Draw();
                    member_name = MenuUserInput();

                    MenuRender("video_number:");
                    Draw();
                    IntegerInputSanitation(out video_number);

                    MenuRender("title:");
                    Draw();
                    title = MenuUserInput();

                    MenuRender("daily_rental_cost:");
                    Draw();
                    DoubleInputSanitation(out daily_rental_cost);

                    MenuRender("date_rented:");
                    Draw();
                    date_rented = MenuUserInput();

                    MenuRender("date_returned:");
                    Draw();
                    date_returned = MenuUserInput();

                    MenuRender("branch_number:");
                    Draw();
                    IntegerInputSanitation(out branch_number);


                    result = coVidRental.branch.DataUpdateDelete_f_Update(rental_number, member_number, member_name, video_number, title, daily_rental_cost, date_rented, date_returned, branch_number);




                } else if(choice.ToLower() == "d") {

                    MenuRender("rental_number:");
                    Draw();
                    IntegerInputSanitation(out rental_number);

                    result = coVidRental.branch.DataUpdateDelete_f_Delete(rental_number);

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
