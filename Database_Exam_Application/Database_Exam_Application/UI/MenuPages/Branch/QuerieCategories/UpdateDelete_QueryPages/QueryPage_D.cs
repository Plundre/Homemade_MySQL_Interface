using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_D : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here
        int video_number;
        int staff_number;
        int catalog_number;
        int supplier_number;
        string title;
        string category;
        double daily_rental_rate;
        double purchase_price;
        string status_;
        string main_character_name;
        string main_actor_name;
        string director;
        int branch_number;


    

        string caseMenu;

        string choice;

        string result;


        public QueryPage_D(CoVidRental.CoVidRental coVidRental, string caseMenu) {
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

                    MenuRender("video_number:");
                    Draw();
                    IntegerInputSanitation(out video_number);

                    MenuRender("staff_number:");
                    Draw();
                    IntegerInputSanitation(out staff_number);

                    MenuRender("catalog_number:");
                    Draw();
                    IntegerInputSanitation(out catalog_number);

                    MenuRender("supplier_number:");
                    Draw();
                    IntegerInputSanitation(out supplier_number);

                    MenuRender("title:");
                    Draw();
                    title = MenuUserInput();

                    MenuRender("category:");
                    Draw();
                    category = MenuUserInput();

                    MenuRender("daily_rental_rate:");
                    Draw();
                    DoubleInputSanitation(out daily_rental_rate);

                    MenuRender("purchase_price:");
                    Draw();
                    DoubleInputSanitation(out purchase_price);

                    MenuRender("status_:");
                    Draw();
                    status_ = MenuUserInput();

                    MenuRender("main_character_name:");
                    Draw();
                    main_character_name = MenuUserInput();

                    MenuRender("main_actor_name:");
                    Draw();
                    main_actor_name = MenuUserInput();

                    MenuRender("director:");
                    Draw();
                    director = MenuUserInput();

                    MenuRender("branch_number:");
                    Draw();
                    IntegerInputSanitation(out branch_number);



                    result = coVidRental.branch.DataUpdateDelete_d_Update(video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number);




                } else if(choice.ToLower() == "d") {

                    MenuRender("video_number:");
                    Draw();
                    IntegerInputSanitation(out video_number);


                    result = coVidRental.branch.DataUpdateDelete_d_Delete(video_number);

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
