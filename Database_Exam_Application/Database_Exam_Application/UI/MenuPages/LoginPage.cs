using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages {
    internal class LoginPage : Page {

        ServerCredentials resultCredentials;

        CoVidRental.CoVidRental coVidRental;

        protected string menuTxt_Address  = "    Server address: ";
        protected string menuTxt_Port     = "    Port number: ";
        protected string menuTxt_Username = "    Username: ";
        protected string menuTxt_Password = "    Password: ";
        protected string menuTxt_Database = "    Database: " 
                                    + "                   ";
        protected MainMenu mainMenu;
        public LoginPage() : base() {
            this.coVidRental = new CoVidRental.CoVidRental();
            
            resultCredentials = new ServerCredentials();
            mainMenu = new MainMenu(this.coVidRental, this.resultCredentials);

        }


        bool TestConnection() {
            string connectionString = "server=" + this.resultCredentials.address + ";user=" + this.resultCredentials.username + ";database=" + this.resultCredentials.database + ";port=" + this.resultCredentials.port + ";password=" + this.resultCredentials.password;

            MySqlConnector.MySqlConnection connector = new MySqlConnector.MySqlConnection(connectionString);
            ResultRender("Connecting to database...");
            Draw();
            try {
                connector.Open();
                connector.Close();
                ResultRender("SUCCESS: Connection Accepted");
                Draw();
                return true;
            } catch(Exception excep) {
                ResultRender("Failed to connect!");
                //ResultRender(excep.ToString());
                ResultRender("\n\nPlease try again or later");
                Draw();
                return false;
            }
        }


        internal override void Run() {
            while(true) {
                MenuRender("\n"+ "    Please Log In\n"+ "\n");
                
                MenuRender(menuTxt_Address);
                Draw();
                this.resultCredentials.address = MenuUserInput();

                MenuRender(menuTxt_Port);
                Draw();
                this.resultCredentials.port = MenuUserInput();
                
                MenuRender(menuTxt_Username);
                Draw();
                this.resultCredentials.username = MenuUserInput();

                MenuRender(menuTxt_Password);
                Draw();
                this.resultCredentials.password = MenuUserInput();

                MenuRender(menuTxt_Database);
                Draw();
                this.resultCredentials.database = MenuUserInput();

                mainMenu.SetCreds(this.resultCredentials);
                if(TestConnection()) {
                    coVidRental.SetCreds(this.resultCredentials);
                    mainMenu.Run();
                    return;
                }
                MenuRenderClear();
            }
        }

        public ServerCredentials GetResult() {
            return resultCredentials;
        }

    }
}

// "                     "
//+"    Please Log In    "
//+"                     ";
// "    Server address:  ";
// "    Port number:     ";
// "    Username:        ";
// "    Password:        ";
// "    Database:        "
//+"                     ";

