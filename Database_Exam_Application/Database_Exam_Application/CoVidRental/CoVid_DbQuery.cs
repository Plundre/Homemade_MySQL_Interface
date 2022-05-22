using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database_Exam_Application.CoVidRental {


    /// <summary>
    /// Represents a query made towards the database
    /// </summary>
    ///  
    /// <remarks>
    /// The class stremlines and abstracts the usage of the <see cref="MySqlConnector"/> to send queries to a MySQL database.
    /// </remarks>
    internal class CoVid_DbQuery {

        

        CoVid_DbConnection _conn;

        //string query;

        //string server;
        //string user;
        //string database;
        //string port;
        //string password;

        ServerCredentials credentials;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address_"></param>
        /// <param name="port_"></param>
        /// <param name="user_"></param>
        /// <param name="password_"></param>
        /// <param name="database_"></param>
        
        //public CoVid_DbQuery(string address_ = "localhost", string port_ = "3306", string user_ = "root", string password_ = "toor", string database_ = "world") {
        //    this.credentials.password = password_; // Insecure or something i guess, should probably be a hash instead of clear text
        //    this.credentials.address = address_;
        //    this.credentials.username = user_;
        //    this.credentials.database = database_;
        //    this.credentials.port = port_;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="credentials_"></param>
        public CoVid_DbQuery(ServerCredentials credentials_) {
            this.credentials.password = credentials_.password; // Insecure or something i guess, should probably be a hash instead of clear text
            this.credentials.address = credentials_.address;
            this.credentials.username = credentials_.username;
            this.credentials.database = credentials_.database;
            this.credentials.port = credentials_.port;
        }



        public string Send(string sqlQueryString, int colNum = 0) {

            //return sqlQueryString + "\nWARNING! |CoVid_DbQuery.Send()| is commented out, u dumb dumb!!";
            try {
                _conn = new CoVid_DbConnection(this.credentials.address, this.credentials.port, this.credentials.username, this.credentials.password, this.credentials.database);
                MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(sqlQueryString, _conn.GetConnection());
                string output = "";
                if(sqlQueryString.Contains("SELECT")) {
                    
                    MySqlConnector.MySqlDataReader readValue = cmd.ExecuteReader();

                    while(readValue.Read()) {
                        output = "Result: |";
                        int j = 0;
                        for(int i = 0; i < colNum -1; i++) {
                            output += (readValue[i] + "|, |");
                            j = i;
                        }
                        output += readValue[j+1] + "|";
                        //Console.WriteLine(output);
                    }
                    readValue.Close();
                    output += "\nDone reading!";
                } else {
                    cmd.ExecuteNonQuery();
                    output = "Query is pushed!";
                    //Console.WriteLine("Query is pushed!");
                }
                _conn.ConnectionManualStop();
                return sqlQueryString + "\n" + output;

            } catch(Exception ex) {
                _conn.ConnectionManualStop();
                return "Failed to read!";
                //Console.WriteLine("Failed to read!");
                //Console.WriteLine(ex);
            }
        }
    }
}
