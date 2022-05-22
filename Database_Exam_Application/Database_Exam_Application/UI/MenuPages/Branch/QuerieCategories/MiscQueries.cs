using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories {
    internal class MiscQueries : Page{
        CoVidRental.CoVidRental coVidRental;
        
        string caseMenuA = "    a: List the details of branches in a given city.\n" 
                         + "       Please enter details:";
        
        string caseMenuB = "    b: List the name, position, and salary of staff at a given branch, ordered by staff name.\n" 
                         + "       Please enter details:";

        string caseMenuC = "    c: List the name of each Manager at each branch, ordered by branch number.\n"; 
        
        string caseMenuD = "    d: List the title, category, and availability of all videos at a specified branch, ordered by category.\n" 
                         + "       Please enter details:";
        
        string caseMenuE = "    e: List the title, category, and availability of all videos for a given actor at a specified branch, ordered by title.\n" 
                         + "       Please enter details:";
        
        string caseMenuF = "    f: List the title, category, and availability of all videos for a given director at a specified branch, ordered by title.\n" 
                         + "       Please enter details:";
        
        string caseMenuG = "    g: List the details of all videos a specified member currently has on rent.\n" 
                         + "       Please enter details:";
        
        string caseMenuH = "    h: List the details of copies of a given video at a specified branch.\n" 
                         + "       Please enter details:";
        
        string caseMenuI = "    i: List the titles of all videos in a specified category, ordered by title. \n" 
                         + "       Please enter details:";

        string caseMenuJ = "    j: List the total number of videos in each video category at each branch, ordered by branch number.\n";

        string caseMenuK = "    k: List the total cost of the videos at all branches.\n";
        
        string caseMenuL = "    l: List the total number of videos featuring each actor, ordered by actor name.\n";
        
        string caseMenuM = "    m: List the total number of members at each branch who joined in 2020, ordered by branch number.\n";
        
        string caseMenuN = "    n: List the total possible daily rental for videos at each branch, ordered by branch number.\n";

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
        MiscQueries_QueryPages.QueryPage_N queryPageN;

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
            queryPageN = new MiscQueries_QueryPages.QueryPage_N(coVidRental, caseMenuN);












            MenuRender("\n"
                     + "    What would you like to do?\n"
                     + "\n"
                     + "    a: List the details of branches in a given city.\n"
                     + "    b: List the name, position, and salary of staff at a given branch, ordered by staff name.\n"
                     + "    c: List the name of each Manager at each branch, ordered by branch number.\n"
                     + "    d: List the title, category, and availability of all videos at a specified branch, ordered by category.\n"
                     + "    e: List the title, category, and availability of all videos for a given actor at a specified branch, ordered by title.\n"
                     + "    f: List the title, category, and availability of all videos for a given director at a specified branch, ordered by title.\n"
                     + "    g: List the details of all videos a specified member currently has on rent.\n"
                     + "    h: List the details of copies of a given video at a specified branch.\n"
                     + "    i: List the titles of all videos in a specified category, ordered by title. \n"
                     + "    j: List the total number of videos in each video category at each branch, ordered by branch number.\n"
                     + "    k: List the total cost of the videos at all branches.\n"
                     + "    l: List the total number of videos featuring each actor, ordered by actor name.\n"
                     + "    m: List the total number of members at each branch who joined in 2020, ordered by branch number.\n"
                     + "    n: List the total possible daily rental for videos at each branch, ordered by branch number.\n"
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

                    case 'n': //(f)
                        queryPageN.Run();
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
a: List the details of branches in a given city. 
b: List the name, position, and salary of staff at a given branch, ordered by staff name. 
c: List the name of each Manager at each branch, ordered by branch number. 
d: List the title, category, and availability of all videos at a specified branch, ordered by category. 
e: List the title, category, and availability of all videos for a given actor at a specified branch, ordered by title. 
f: List the title, category, and availability of all videos for a given director at a specified branch, ordered by title. 
g: List the details of all videos a specified member currently has on rent. 
h: List the details of copies of a given video at a specified branch. 
i: List the titles of all videos in a specified category, ordered by title.  
j: List the total number of videos in each video category at each branch, ordered by branch number. 
k: List the total cost of the videos at all branches. 
l: List the total number of videos featuring each actor, ordered by actor name. 
m: List the total number of members at each branch who joined in 2020, ordered by branch number. 
n: List the total possible daily rental for videos at each branch, ordered by branch number.
 */