using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_A : Page {

        CoVidRental.CoVidRental coVidRental;


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
        string branch_number;

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

                MenuRender("Branch number:");
                IntegerInputSanitation(out video_number);

                MenuRender("staff_number:");
                IntegerInputSanitation(out staff_number);

                MenuRender("catalog_number:");
                IntegerInputSanitation(out catalog_number);

                MenuRender("supplier_number:");
                IntegerInputSanitation(out supplier_number);

                MenuRender("title:");
                Draw();
                title = MenuUserInput();

                MenuRender("category:");
                Draw();
                category = MenuUserInput();

                MenuRender("daily_rental_rate:");
                DoubleInputSanitation(out daily_rental_rate);

                MenuRender("purchase_price:");
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
                branch_number = MenuUserInput();




                ResultRender(coVidRental.business.DataEntry_a(video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number));

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
