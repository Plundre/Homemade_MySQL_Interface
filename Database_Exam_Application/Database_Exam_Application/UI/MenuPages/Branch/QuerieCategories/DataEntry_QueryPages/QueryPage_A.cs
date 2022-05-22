using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_A : Page {

        CoVidRental.CoVidRental coVidRental;
            
        protected int branch_number;
        protected string street;
        protected string city;
        protected string state;
        protected string zip_code;
        protected string telephone_number_1;
        protected string telephone_number_2;
        protected string telephone_number_3;


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



                ResultRender(coVidRental.branch.DataEntry_a(branch_number, street, city, state, zip_code, telephone_number_1, telephone_number_2, telephone_number_3));

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
