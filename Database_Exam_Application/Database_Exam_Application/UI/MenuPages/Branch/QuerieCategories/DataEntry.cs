using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Branch.QuerieCategories {
    internal class DataEntry : Page{

        public DataEntry() {
            MenuRender("\n"
                     + "    What View would you like?\n"
                     + "\n"
                     + "    a: Enter details of a new branch.\n"
                     + "    b: Enter details of a new staff member at a branch\n"
                     + "    c: Enter details for a newly released video\n"
                     + "    d: Enter details of copies of a new video at a given branch\n"
                     + "    e: Enter details of a new customer/member registering at a given branch\n"
                     + "    f: Enter details of a rental agreement for a member renting a video\n"
                     + "    9: Back\n");
        }

        internal override void Run() {
            char menuChoice;
            while(true) {
                Draw();
                menuChoice = MenuUserInput()[0];
                
                switch(menuChoice) {
                    case 'a': //(a) Enter details of a new branch. 
                        
                        break;

                    case 'b': //(b) Enter the details of a new member of staff at a branch (such as an employee Ole Olsen at branch Avd001). 

                        break;

                    case 'c': //(c) Enter the details for a newly released video (such as details of a video called Independence Day). 

                        break;

                    case 'd': //(d) Enter the details of copies of a new video at a given branch (such as three copies of Independence Day at branch Avd001).

                        break;

                    case 'e': //(e) Enter the details of a new member registering at a given branch (such as a member Eva Jensen registering at branch Avd002). 

                        break;

                    case 'f': //(f) Enter the details of a rental agreement for a member renting a video (such as member Helga Amundsen renting Free Guy on 4-Aug-2021). 

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
(a) Enter the details of a new branch. 
(b) Enter the details of a new member of staff at a branch (such as an employee Ole Olsen at branch Avd001). 
(c) Enter the details for a newly released video (such as details of a video called Independence Day). 
(d) Enter the details of copies of a new video at a given branch (such as three copies of Independence Day at branch Avd001).
(e) Enter the details of a new member registering at a given branch (such as a member Eva Jensen registering at branch Avd002). 
(f) Enter the details of a rental agreement for a member renting a video (such as member Helga Amundsen renting Free Guy on 4-Aug-2021). 
 */
