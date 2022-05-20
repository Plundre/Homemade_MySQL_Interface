using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.CoVidRental
{

    internal class CoVidRental
    {
        internal static ServerCredentials credentials;


        internal static CoVid_DbQuery query;
       

        /// <summary>
        /// Con
        /// </summary>
        public CoVidRental() { 
        }

        public void SetCreds(ServerCredentials credentials_) {
            credentials.username = credentials_.username;
            credentials.password = credentials_.password;
            credentials.port = credentials_.port;
            credentials.address = credentials_.address;
            credentials.database = credentials_.database;
        }

        public class Branch {
            //public ServerCredentials credentials;

            //protected CoVid_DbQuery query;

            public void Branch_DataEntry_a() {
                query = new CoVid_DbQuery(credentials);

                query.Send("SELECT * FROM branch WHERE city = 'Oslo';", 8);
                query.Send("SELECT fullname, position, salary FROM staff WHERE branch_number = 2 ORDER BY fullname;", 3);
            }


            public void DataEntry_b() {query = new CoVid_DbQuery(credentials);  throw new NotImplementedException();}
            public void DataEntry_c() {query = new CoVid_DbQuery(credentials);  throw new NotImplementedException();}
            public void DataEntry_d() {query = new CoVid_DbQuery(credentials);  throw new NotImplementedException();}
            public void DataEntry_e() {query = new CoVid_DbQuery(credentials);  throw new NotImplementedException();}
            public void DataEntry_f() {query = new CoVid_DbQuery(credentials);  throw new NotImplementedException();}
            public void DataUpdateDelete_a() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataUpdateDelete_b() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataUpdateDelete_c() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataUpdateDelete_d() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataUpdateDelete_e() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataUpdateDelete_f() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_a() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_b() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_c() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_d() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_e() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_f() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_g() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_h() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_i() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_j() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_k() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_l() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_m() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
            public void DataMiscQuerie_n() {query = new CoVid_DbQuery(credentials); throw new NotImplementedException();}
        }


        public bool TestConnection() {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection();
            
            return false;
        }


    }




}
