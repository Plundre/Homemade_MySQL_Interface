using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories {
    internal class UpdateDelete : Page{
        CoVidRental.CoVidRental coVidRental;


        protected string caseMenuA = "    a: Update / delete the details of a given video.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuB = "    b: Update / delete the details of a given video supplier.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuC = "    c: Update / delete the details of a given video order.\n" +
                                     "       You want to Update or Delete? (U/d)";

        UpdateDelete_QueryPages.QueryPage_A queryPageA;
        UpdateDelete_QueryPages.QueryPage_B queryPageB;
        UpdateDelete_QueryPages.QueryPage_C queryPageC;

        public UpdateDelete(CoVidRental.CoVidRental coVidRental) {
            this.coVidRental = coVidRental;

            
            MenuRender("\n"
                     + "    2: Update & Delete\n"
                     + "\n"
                     + "    What would you like to do?\n"
                     + "\n"
                     + "    a: Update / delete the details of a given video. \n"
                     + "    b: Update / delete the details of a given video supplier. \n"
                     + "    c: Update / delete the details of a given video order.\n"
                     + "    9: Back\n");


            queryPageA = new UpdateDelete_QueryPages.QueryPage_A(coVidRental, caseMenuA);
            queryPageB = new UpdateDelete_QueryPages.QueryPage_B(coVidRental, caseMenuB);
            queryPageC = new UpdateDelete_QueryPages.QueryPage_C(coVidRental, caseMenuC);


        }

        internal override void Run() {
            char menuChoice;
            while(true) {
                Draw();

                string input = MenuUserInput();
                menuChoice = input[0];

                switch(menuChoice) {
                    case 'a': //(a)
                        queryPageA.Run();
                        break;

                    case 'b': //(b)
                        queryPageB.Run();
                        break;

                    case 'c': //(c)
                        queryPageC.Run();
                        break;


                    case '9':
                        return;

                    default:
                        ResultRender("Please enter a valid choice");
                        break;
                }
            }
        }
    }
}

/*
 Data Update / Deletion 
a: Update / delete the details of a given video. 
b: Update / delete the details of a given video supplier. 
c: Update / delete the details of a given video order.
 */