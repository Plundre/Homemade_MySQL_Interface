using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_B : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here

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

                    MenuRender("supplier_number:");
                    Draw();
                    IntegerInputSanitation(out supplier_number);
                    
                    MenuRender("supplier_name:");
                    Draw();
                    supplier_name = MenuUserInput();
                    
                    MenuRender("street:");
                    Draw();
                    street= MenuUserInput();
                    
                    MenuRender("city:");
                    Draw();
                    city= MenuUserInput();
                    
                    MenuRender("state:");
                    Draw();
                    state= MenuUserInput();
                    
                    MenuRender("zip_code:");
                    Draw();
                    zip_code= MenuUserInput();
                    
                    MenuRender("telephone_number:");
                    Draw();
                    telephone_number= MenuUserInput();
                    
                    MenuRender("status_:");
                    Draw();
                    status_= MenuUserInput();



                    result = coVidRental.business.DataUpdateDelete_b_Update(supplier_number, supplier_name, street, city, state, zip_code, telephone_number, status_);


                } else if(choice.ToLower() == "d") {

                    MenuRender("Staff number:");
                    Draw();
                    IntegerInputSanitation(out supplier_number);

                    result = coVidRental.business.DataUpdateDelete_b_Delete(supplier_number);

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
