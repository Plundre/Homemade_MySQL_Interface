using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories {
    internal class MiscQueries : Page{
        CoVidRental.CoVidRental coVidRental;
        string caseMenuA = "    a: List the name, position, and salary of staff at all branches, ordered by branch number. \n" 
                         + "       Please enter details:";

        string caseMenuB = "    b: List the name and telephone number of the Manager at a given branch. \n" 
                         + "       Please enter details:";

        string caseMenuC = "    c: List the catalog number and title of all videos at a given branch, ordered by title. \n" 
                         + "       Please enter details:";

        string caseMenuD = "    d: List the number of copies of a given video at a given branch. \n" 
                         + "       Please enter details:";

        string caseMenuE = "    e: List the number of members at each branch, ordered by branch number. \n" 
                         + "       Please enter details:";

        string caseMenuF = "    f: List the number of members who joined this year at each branch, ordered by branch number. \n" 
                         + "       Please enter details:";

        string caseMenuG = "    g: List the number of video rentals at each branch between certain dates, ordered by branch number. \n" 
                         + "       Please enter details:";

        string caseMenuH = "    h: List the number of videos in each category at a given branch, ordered by category. \n" 
                         + "       Please enter details:";

        string caseMenuI = "    i: List the name, address, and telephone number of all video suppliers, ordered by supplier number.  \n" 
                         + "       Please enter details:";

        string caseMenuJ = "    j: List the name and telephone number of a video supplier. \n" 
                         + "       Please enter details:";

        string caseMenuK = "    k: List the details of all video orders placed with a given supplier, ordered by the date of order. \n" 
                         + "       Please enter details:";

        string caseMenuL = "    l: List the details of all video orders placed on a certain date. \n" 
                         + "       Please enter details:";

        string caseMenuM = "    m: List the total daily rentals for videos at each branch between certain dates, ordered by branch number. \n" 
                         + "       Please enter details:";


        MiscQueries_QueryPages.QueryPage_A queryPageA;
        MiscQueries_QueryPages.QueryPage_B queryPageB;
        MiscQueries_QueryPages.QueryPage_C queryPageC;
        MiscQueries_QueryPages.QueryPage_D queryPageD;
        MiscQueries_QueryPages.QueryPage_E queryPageE;
        MiscQueries_QueryPages.QueryPage_F queryPageF;
        MiscQueries_QueryPages.QueryPage_G queryPageG;
        MiscQueries_QueryPages.QueryPage_H queryPageH;
        MiscQueries_QueryPages.QueryPage_I queryPageI;
        MiscQueries_QueryPages.QueryPage_J queryPageJ;
        MiscQueries_QueryPages.QueryPage_K queryPageK;
        MiscQueries_QueryPages.QueryPage_L queryPageL;
        MiscQueries_QueryPages.QueryPage_M queryPageM;




        public MiscQueries(CoVidRental.CoVidRental coVidRental) { 
            this.coVidRental = coVidRental;

            queryPageA = new MiscQueries_QueryPages.QueryPage_A(coVidRental, caseMenuA);
            queryPageB = new MiscQueries_QueryPages.QueryPage_B(coVidRental, caseMenuB);
            queryPageC = new MiscQueries_QueryPages.QueryPage_C(coVidRental, caseMenuC);
            queryPageD = new MiscQueries_QueryPages.QueryPage_D(coVidRental, caseMenuD);
            queryPageE = new MiscQueries_QueryPages.QueryPage_E(coVidRental, caseMenuE);
            queryPageF = new MiscQueries_QueryPages.QueryPage_F(coVidRental, caseMenuF);
            queryPageG = new MiscQueries_QueryPages.QueryPage_G(coVidRental, caseMenuG);
            queryPageH = new MiscQueries_QueryPages.QueryPage_H(coVidRental, caseMenuH);
            queryPageI = new MiscQueries_QueryPages.QueryPage_I(coVidRental, caseMenuI);
            queryPageJ = new MiscQueries_QueryPages.QueryPage_J(coVidRental, caseMenuJ);
            queryPageK = new MiscQueries_QueryPages.QueryPage_K(coVidRental, caseMenuK);
            queryPageL = new MiscQueries_QueryPages.QueryPage_L(coVidRental, caseMenuL);
            queryPageM = new MiscQueries_QueryPages.QueryPage_M(coVidRental, caseMenuM);


            MenuRender("\n"
                     + "    3: Misc Queries:\n"
                     + "\n"
                     + "    What would you like to do?\n"
                     + "\n"
                     + "    a: List the name, position, and salary of staff at all branches, ordered by branch number. \n"
                     + "    b: List the name and telephone number of the Manager at a given branch. \n"
                     + "    c: List the catalog number and title of all videos at a given branch, ordered by title. \n"
                     + "    d: List the number of copies of a given video at a given branch. \n"
                     + "    e: List the number of members at each branch, ordered by branch number. \n"
                     + "    f: List the number of members who joined this year at each branch, ordered by branch number. \n"
                     + "    g: List the number of video rentals at each branch between certain dates, ordered by branch number. \n"
                     + "    h: List the number of videos in each category at a given branch, ordered by category. \n"
                     + "    i: List the name, address, and telephone number of all video suppliers, ordered by supplier number.  \n"
                     + "    j: List the name and telephone number of a video supplier. \n"
                     + "    k: List the details of all video orders placed with a given supplier, ordered by the date of order. \n"
                     + "    l: List the details of all video orders placed on a certain date. \n"
                     + "    m: List the total daily rentals for videos at each branch between certain dates, ordered by branch number. \n"
                     + "   9: Back\n");

        }





        internal override void Run() {
            char menuChoice;
            while(true) {
                Draw();
                
                string input = MenuUserInput().ToLower();
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

                    case 'g': //(f)
                        queryPageG.Run();
                        break;

                    case 'h': //(f)
                        queryPageH.Run();
                        break;

                    case 'i': //(f)
                        queryPageI.Run();
                        break;

                    case 'j': //(f)
                        queryPageJ.Run();
                        break;

                    case 'k': //(f)
                        queryPageK.Run();
                        break;

                    case 'l': //(f)
                        queryPageL.Run();
                        break;

                    case 'm': //(f)
                        queryPageM.Run();
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
a: List the name, position, and salary of staff at all branches, ordered by branch number. 
b: List the name and telephone number of the Manager at a given branch. 
c: List the catalog number and title of all videos at a given branch, ordered by title. 
d: List the number of copies of a given video at a given branch. 
e: List the number of members at each branch, ordered by branch number. 
f: List the number of members who joined this year at each branch, ordered by branch number. 
g: List the number of video rentals at each branch between certain dates, ordered by branch number. 
h: List the number of videos in each category at a given branch, ordered by category. 
i: List the name, address, and telephone number of all video suppliers, ordered by supplier number.  
j: List the name and telephone number of a video supplier. 
k: List the details of all video orders placed with a given supplier, ordered by the date of order. 
l: List the details of all video orders placed on a certain date. 
m: List the total daily rentals for videos at each branch between certain dates, ordered by branch number. 
 */