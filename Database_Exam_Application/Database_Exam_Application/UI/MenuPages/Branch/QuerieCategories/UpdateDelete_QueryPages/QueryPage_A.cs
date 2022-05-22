using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.UpdateDelete_QueryPages {
    internal class QueryPage_A : Page {
        CoVidRental.CoVidRental coVidRental;


        //query variables here

                    int branch_number;
                    string street;
                    string city;
                    string state;
                    string zip_code;
                    string telephone_number_1;
                    string telephone_number_2;
                    string telephone_number_3;



        string caseMenu;

        string choice;

        string result;

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

                    
                MenuRenderClear();
                MenuRender(caseMenu);// You want to Update or Delete? (U/d)
                Draw();
                choice = MenuUserInput();
                if(choice.ToLower() == "u" || choice == "") {
                    
                    MenuRender("Branch number:");
                    Draw();
                    IntegerInputSanitation(out branch_number);

                    MenuRender("Street:");
                    Draw();
                    street = MenuUserInput();

                    MenuRender("City:");
                    Draw();
                    city = MenuUserInput();

                    MenuRender("State:");
                    Draw();
                    state = MenuUserInput();

                    MenuRender("Zip Code:");
                    Draw();
                    zip_code = MenuUserInput();

                    MenuRender("Telephone number 1:");
                    Draw();
                    telephone_number_1 = MenuUserInput();

                    MenuRender("Telephone number 2:");
                    Draw();
                    telephone_number_2 = MenuUserInput();
                    
                    MenuRender("Telephone number 3:");
                    Draw();
                    telephone_number_3 = MenuUserInput();

                    result = coVidRental.branch.DataUpdateDelete_a_Update(branch_number,street,city,state,zip_code,telephone_number_1,telephone_number_2,telephone_number_3);
                
                }else if(choice.ToLower() == "d") {

                    MenuRender("Branch number:");
                    Draw();
                    IntegerInputSanitation(out branch_number);

                    result = coVidRental.branch.DataUpdateDelete_a_Delete(branch_number);
                } else {

                    return;
                }
                


                ResultRender(result);

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
