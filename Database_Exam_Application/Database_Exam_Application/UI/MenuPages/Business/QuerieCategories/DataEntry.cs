using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories {
    internal class DataEntry : Page{

        CoVidRental.CoVidRental coVidRental;

        protected string caseMenuA = "    a: Enter the details for a newly released video (such as details of a video called Clue:Maltesergåten).\n"  
                                    +"    Please enter details:";

        protected string caseMenuB = "    b: Enter the details of a video supplier (such as a supplier called Maipo Films).\n" 
                                    +"    Please enter details:";

        protected string caseMenuC = "    c: Enter the details of a video order (such as ordering 10 copies of Croods – En ny tid for branch Avd002)\n"
                                   + "    Please enter details:";

               

        DataEntry_QueryPages.QueryPage_A queryPageA;
        DataEntry_QueryPages.QueryPage_B queryPageB;
        DataEntry_QueryPages.QueryPage_C queryPageC;

        
        public DataEntry(CoVidRental.CoVidRental coVidRental) {
            this.coVidRental = coVidRental;




            queryPageA = new DataEntry_QueryPages.QueryPage_A(this.coVidRental,caseMenuA);
            queryPageB = new DataEntry_QueryPages.QueryPage_B(this.coVidRental,caseMenuB);
            queryPageC = new DataEntry_QueryPages.QueryPage_C(this.coVidRental,caseMenuC);




            MenuRender("\n"
                     + "    1: Data Entry:\n"
                     + "\n"
                     + "    What View would you like?\n"
                     + "\n"
                     + "    a: Enter the details for a newly released video (such as details of a video called Clue:Maltesergåten). \n"
                     + "    b: Enter the details of a video supplier (such as a supplier called Maipo Films). \n"
                     + "    c: Enter the details of a video order (such as ordering 10 copies of Croods – En ny tid for branch Avd002)\n"
                     + "    9: Back\n");

        }

        internal override void Run() {
            char menuChoice;
            while(true) {
                Draw();

                string input = MenuUserInput();
                menuChoice = input[0];

                switch(menuChoice) {
                    case 'a': //(a) Enter details of a new branch. 
                        queryPageA.Run();
                        break;

                    case 'b': //(b) Enter the details of a new member of staff at a branch (such as an employee Ole Olsen at branch Avd001). 
                        queryPageB.Run();
                        break;

                    case 'c': //(c) Enter the details for a newly released video (such as details of a video called Independence Day). 
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
 Data Entry 
a: Enter the details for a newly released video (such as details of a video called Clue:Maltesergåten). 
b: Enter the details of a video supplier (such as a supplier called Maipo Films). 
c: Enter the details of a video order (such as ordering 10 copies of Croods – En ny tid for branch Avd002)
 */
