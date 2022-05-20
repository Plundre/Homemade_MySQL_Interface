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

        internal static string queryString;

        public Branch branch { get; set; }
        public Business business { get; set; }

        /// <summary>
        /// Con
        /// </summary>
        public CoVidRental() { 
            this.branch = new Branch();
            this.business = new Business();
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

            public string DataEntry_a(int branch_number, string street, string city, string state, string zip_code, string telephone_number_1, string telephone_number_2, string telephone_number_3) {
                query = new CoVid_DbQuery(credentials);
                //string CurrentYr = DateTime.Today.Year.ToString();
                queryString = "";
                return query.Send(queryString);
            }//INSERT INTO branch (branch_number, street, city, state, zip_code, telephone_number_1, telephone_number_2, telephone_number_3) VALUES (?, '?', '?', '?', '?', '?', '?', '?');


            public string DataEntry_b(int staff_number, int branch_number, string fullname, string position, int salary) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//INSERT INTO staff (staff_number, branch_number, fullname, position, salary) VALUES (?, ?, '?', '?', ?);

            public string DataEntry_c(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?, ?, ?, ?, '?', '?', ?, ?, '?', '?', '?', '?', ?);

            public string DataEntry_d(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?, ?, ?, ?, '?', '?', ?, ?, '?', '?', '?', '?', ?);


            public string DataEntry_e(int member_number, int branch_number, string fullname, int staff_number, string street, string city, string state, string zip_code, string date_of_registry, string staff_name) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//INSERT INTO member_info (member_number, branch_number, fullname, staff_number, street, city, state, zip_code, date_of_registry, staff_name) VALUES (?, ?, '?', ?, '?', '?', '?', '?', '?', '?');


            public string DataEntry_f(int rental_number, int member_number, string member_name, int video_number, string title, double daily_rental_cost, string date_rented, string date_returned, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//INSERT INTO rental (rental_number, member_number, member_name, video_number, title, daily_rental_cost, date_rented, date_returned, branch_number) VALUES (?, ?, '?', ?, '?', ?, '?', '?', ?);








            public string DataUpdateDelete_a_Update(int branch_number, string street, string city, string state, string zip_code, string telephone_number_1, string telephone_number_2, string telephone_number_3) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE branch SET street = '?', city = '?', state = '?', zip_code = '?', telephone_number_1 = '?', telephone_number_2 = '?', telephone_number_3 = '?' WHERE branch_number = ?;

            public string DataUpdateDelete_a_Delete(int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); 
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM branch WHERE branch_number = ?;



            public string DataUpdateDelete_b_Update(int staff_number, int branch_number, string fullname, string position, double salary) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE staff SET branch_number = ?, fullname = '?', position = '?', salary = ? WHERE staff_number = ?;

            public string DataUpdateDelete_b_Delete(int staff_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); 
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM staff WHERE staff_number = ?;



            public string DataUpdateDelete_c_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE video SET staff_number = ?, catalog_number = ?, supplier_number = ?, title = '?', category = '?', daily_rental_rate = ?, purchase_price = ?, status_ = '?', main_character_name = '?', main_actor_name = '?', director = '?', branch_number = ? WHERE video_number = ?;


            public string DataUpdateDelete_c_Delete(int video_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM video WHERE video_number = ?;



            public string DataUpdateDelete_d_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE video SET staff_number = ?, catalog_number = ?, supplier_number = ?, title = '?', category = '?', daily_rental_rate = ?, purchase_price = ?, status_ = '?', main_character_name = '?', main_actor_name = '?', director = '?', branch_number = ? WHERE video_number = ?;


            public string DataUpdateDelete_d_Delete(int video_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); 
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM video WHERE video_number = ?;



            public string DataUpdateDelete_e_Update(int member_number, int branch_number, string fullname, int staff_number, string street, string city, string state, string zip_code, string date_of_registry, string staff_name) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE member_info SET branch_number = ?, fullname = '?', staff_number = ?, street = '?', city = '?', state = '?', zip_code = '?', date_of_registry = '?', staff_name = '?' WHERE member_number = ?;


            public string DataUpdateDelete_e_Delete(int member_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); 
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM member_info WHERE member_number = ?;



            public string DataUpdateDelete_f_Update(int rental_number, int member_number, string member_name, int video_number, string title, double daily_rental_cost, string date_rented, string date_returned, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//UPDATE rental SET member_number = ?, member_name = '?', video_number = ?, title = '?', daily_rental_cost = ?, date_rented = '?', date_returned = '?', branch_number = ? WHERE rental_number = ?;


            public string DataUpdateDelete_f_Delete(int rental_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); 
                queryString = "";
                return query.Send(queryString);

            }//DELETE FROM rental WHERE rental_number = ?;








            public string DataMiscQuerie_a(string city) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT * FROM branch WHERE city = '?';


            public string DataMiscQuerie_b(int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT fullname, position, salary FROM staff WHERE branch_number = ? ORDER BY fullname;


            public string DataMiscQuerie_c(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT fullname FROM staff WHERE position = 'Manager' ORDER BY branch_number;


            public string DataMiscQuerie_d(int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT title, category, status_ FROM video WHERE branch_number = ? ORDER BY category;


            public string DataMiscQuerie_e(string main_actor_name, string branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT title, category, status_ FROM video WHERE main_actor_name = '?' AND branch_number = ? ORDER BY title;


            public string DataMiscQuerie_f(string director, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT title, category, status_ FROM video WHERE director = '?' AND branch_number = ? ORDER BY title;


            public string DataMiscQuerie_g(int member_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT * FROM rental WHERE member_number = ? AND date_returned = null;


            public string DataMiscQuerie_h(int catalog_number, int branch_number) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT * FROM video WHERE catalog_number = 1 AND branch_number = 1;


            public string DataMiscQuerie_i(string category) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT title FROM video WHERE category = '?' ORDER BY title;


            public string DataMiscQuerie_j(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT count(video_number) FROM video GROUP BY category, branch_number ORDER BY branch_number;


            public string DataMiscQuerie_k(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT SUM(daily_rental_cost) FROM rental;


            public string DataMiscQuerie_l(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT main_actor_name, count(video_number) FROM video GROUP BY main_actor_name ORDER BY main_actor_name;


            public string DataMiscQuerie_m(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT branch_number, count(member_number) FROM member_info WHERE date_of_registry LIKE '%2020%' GROUP BY branch_number ORDER BY branch_number;


            public string DataMiscQuerie_n(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials); throw new NotImplementedException();
                queryString = "";
                return query.Send(queryString);

            }//SELECT sum(daily_rental_rate) FROM video GROUP BY branch_number ORDER BY branch_number;


        }


        public class Business {
            //public ServerCredentials credentials;

            //protected CoVid_DbQuery query;

            public void DataEntry_a(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, string branch_number) {
                query = new CoVid_DbQuery(credentials);

                query.Send("SELECT * FROM branch WHERE city = 'Oslo';", 8);
                query.Send("SELECT fullname, position, salary FROM staff WHERE branch_number = 2 ORDER BY fullname;", 3);
            }


            public void DataEntry_b(int supplier_number, string supplier_name, string street, string city, string state, string zip_code, string telephone_number, string status_) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataEntry_c(int order_number, int branch_number, int supplier_number, string supplier_street, string supplier_city, string supplier_state, string supplier_zip_code, int video_catalog_number, string video_title, double video_purchase_price, int quantity, string date_order_placed, string date_order_received, string branch_street, string branch_city, string branch_state, string branch_zip_code) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            
            
            public void DataUpdateDelete_a_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataUpdateDelete_a_Delete(int video_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }

            public void DataUpdateDelete_b_Update(int supplier_number, string supplier_name, string street, string city, string state, string zip_code, string telephone_number, string status_) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataUpdateDelete_b_Delete(int supplier_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }

            public void DataUpdateDelete_c_Update(int order_number, int branch_number, int spplier_number, string supplier_street, string supplier_city, string supplier_state, string supplier_zip_code, int video_catalog_number, string video_title, double video_purchase_price, int quantity, string date_order_placed, string date_order_received, string branch_street, string branch_city, string branch_state, string branch_zip_code) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataUpdateDelete_c_Delete(int order_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }


            public void DataMiscQuerie_a(/*No parameter*/) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_b(int staff_branch_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_c(int branch_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_d(int branch_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_e(/*No parameter*/) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_f(/*No parameter*/) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_g(string first_date_rented, string second_date_rented) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_h(int branch_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_i(/*No parameter*/) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_j(int supplier_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_k(int supplier_number) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_l(string date_order_placed) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
            public void DataMiscQuerie_m(string first_date, string second_date) { query = new CoVid_DbQuery(credentials); throw new NotImplementedException(); }
        }


        public bool TestConnection() {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection();
            
            return false;
        }


    }




}
