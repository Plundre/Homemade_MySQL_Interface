using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories {
    internal class UpdateDelete : Page{
        CoVidRental.CoVidRental coVidRental;


        protected string caseMenuA = "    a: Update / delete the details of a branch.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuB = "    b: Update / delete the details of a member of staff at a branch.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuC = "    c: Update / delete the details of a given video.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuD = "    d: Update / delete the details of a copy of a video.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuE = "    e: Update / delete the details of a given member.\n" +
                                     "       You want to Update or Delete? (U/d)";

        protected string caseMenuF = "    f: Update / delete the details of a given rental agreement for a member renting a vid\n" +
                                     "       You want to Update or Delete? (U/d)";

        UpdateDelete_QueryPages.QueryPage_A queryPageA;
        UpdateDelete_QueryPages.QueryPage_B queryPageB;
        UpdateDelete_QueryPages.QueryPage_C queryPageC;
        UpdateDelete_QueryPages.QueryPage_D queryPageD;
        UpdateDelete_QueryPages.QueryPage_E queryPageE;
        UpdateDelete_QueryPages.QueryPage_F queryPageF;

        public UpdateDelete(CoVidRental.CoVidRental coVidRental) {
            this.coVidRental = coVidRental;

            
            MenuRender("\n"
                     + "    What would you like to do?\n"
                     + "\n"
                     + "    a: Update / delete the details of a branch.\n"
                     + "    b: Update / delete the details of a member of staff at a branch.\n"
                     + "    c: Update / delete the details of a given video.\n"
                     + "    d: Update / delete the details of a copy of a video.\n"
                     + "    e: Update / delete the details of a given member.\n"
                     + "    f: Update / delete the details of a given rental agreement for a member renting a vid\n"
                     + "    9: Back\n");


            queryPageA = new UpdateDelete_QueryPages.QueryPage_A(coVidRental, caseMenuA);
            queryPageB = new UpdateDelete_QueryPages.QueryPage_B(coVidRental, caseMenuB);
            queryPageC = new UpdateDelete_QueryPages.QueryPage_C(coVidRental, caseMenuC);
            queryPageD = new UpdateDelete_QueryPages.QueryPage_D(coVidRental, caseMenuD);
            queryPageE = new UpdateDelete_QueryPages.QueryPage_E(coVidRental, caseMenuE);
            queryPageF = new UpdateDelete_QueryPages.QueryPage_F(coVidRental, caseMenuF);


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

                    case 'd': //(d)
                        queryPageD.Run();
                        break;

                    case 'e': //(e)
                        queryPageE.Run();
                        break;

                    case 'f': //(f)
                        queryPageF.Run();
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
(a) Update / delete the details of a branch. 
(b) Update / delete the details of a member of staff at a branch. 
(c) Update / delete the details of a given video. 
(d) Update / delete the details of a copy of a video. 
(e) Update / delete the details of a given member. 
(f) Update / delete the details of a given rental agreement for a member renting a vid
 */