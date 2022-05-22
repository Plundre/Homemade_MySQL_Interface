using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_B : Page {

        CoVidRental.CoVidRental coVidRental;



        int supplier_number;
        string supplier_name;
        string street;
        string city;
        string state;
        string zip_code;
        string telephone_number;
        string status_;
    
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

                MenuRender("supplier_number:");
                IntegerInputSanitation(out supplier_number);



                MenuRender("supplier_name:");
                Draw();
                supplier_name = MenuUserInput();

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

                MenuRender("telephone_number:");
                Draw();
                telephone_number = MenuUserInput();

                MenuRender("status_:");
                Draw();
                status_ = MenuUserInput();

                ResultRender(coVidRental.business.DataEntry_b(supplier_number, supplier_name, street, city, state, zip_code, telephone_number, status_));

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
