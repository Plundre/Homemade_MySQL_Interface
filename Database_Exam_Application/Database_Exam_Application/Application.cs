using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application {

    struct ServerCredentials {
        public string username;
        public string password;
        public string port;
        public string address;
        public string database;
        public ServerCredentials() {
            username = "";
            password = "";
            port = "";
            address = "";
            database = "";
        }
    }

    internal class Application {

        protected UI.MenuPages.InitPage initPage;
        
        public Application() {
            Console.SetBufferSize(200, 60);
            Console.SetWindowSize(200, 60);
            this.initPage = new UI.MenuPages.InitPage();
        }
        
        
        
        public void Loop() {
            this.initPage.Run();
        }

    }
}
