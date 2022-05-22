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

        static string key1 = "?1";
        static string key2 = "?2";
        static string key3 = "?3";
        static string key4 = "?4";
        static string key5 = "?5";
        static string key6 = "?6";
        static string key7 = "?7";
        static string key8 = "?8";
        static string key9 = "?9";
        static string key10 = "?10";
        static string key11 = "?11";
        static string key12 = "?12";
        static string key13 = "?13";
        static string key14 = "?14";
        static string key15 = "?15";
        static string key16 = "?16";
        static string key17 = "?17";


        //Query functions for Branch and Business could definetely be done more elegantely,
        //but it was done in this way to more easily keep track of all the variables and ensuring that they go in the right spot in the query

        /// <summary>
        /// 
        /// </summary>
        public class Branch {
            //public ServerCredentials credentials;

            //protected CoVid_DbQuery query;

            public string DataEntry_a(int branch_number, string street, string city, string state, string zip_code, string telephone_number_1, string telephone_number_2, string telephone_number_3) {
                query = new CoVid_DbQuery(credentials);
                //string CurrentYr = DateTime.Today.Year.ToString();
                queryString = "INSERT INTO branch (branch_number, street, city, state, zip_code, telephone_number_1, telephone_number_2, telephone_number_3) VALUES (?1, '?2', '?3', '?4', '?5', '?6', '?7', '?8');";
                queryString = queryString.Replace(key1,branch_number.ToString());
                queryString = queryString.Replace(key2,street);
                queryString = queryString.Replace(key3,city);
                queryString = queryString.Replace(key4,state);
                queryString = queryString.Replace(key5,zip_code);
                queryString = queryString.Replace(key6,telephone_number_1);
                queryString = queryString.Replace(key7,telephone_number_2);
                queryString = queryString.Replace(key8,telephone_number_3);

                return query.Send(queryString);
            }//INSERT INTO branch (branch_number, street, city, state, zip_code, telephone_number_1, telephone_number_2, telephone_number_3) VALUES (?1, '?2', '?3', '?4', '?5', '?6', '?7', '?8');


            public string DataEntry_b(int staff_number, int branch_number, string fullname, string position, double salary) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO staff (staff_number, branch_number, fullname, position, salary) VALUES (?1, ?2, '?3', '?4', ?5);";
                queryString = queryString.Replace(key1,staff_number.ToString());
                queryString = queryString.Replace(key2,branch_number.ToString());
                queryString = queryString.Replace(key3,fullname);
                queryString = queryString.Replace(key4,position);
                queryString = queryString.Replace(key5,salary.ToString());
                return query.Send(queryString);

            }//INSERT INTO staff (staff_number, branch_number, fullname, position, salary) VALUES (?1, ?2, '?3', '?4', ?5);

            public string DataEntry_c(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '?10', '?11', '?12', ?13);";
                queryString = queryString.Replace(key10,main_actor_name);
                queryString = queryString.Replace(key11,main_actor_name);
                queryString = queryString.Replace(key12,director);
                queryString = queryString.Replace(key13,branch_number.ToString());
                queryString = queryString.Replace(key1,video_number.ToString());
                queryString = queryString.Replace(key2,staff_number.ToString());
                queryString = queryString.Replace(key3,catalog_number.ToString());
                queryString = queryString.Replace(key4,supplier_number.ToString());
                queryString = queryString.Replace(key5,title);
                queryString = queryString.Replace(key6,category);
                queryString = queryString.Replace(key7,daily_rental_rate.ToString());
                queryString = queryString.Replace(key8,purchase_price.ToString());
                queryString = queryString.Replace(key9,status_);
                return query.Send(queryString);

            }//INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '?10', '?11', '?12', ?13);

            public string DataEntry_d(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '10?', '?11', '?12', ?13);";
                queryString = queryString.Replace(key10, main_actor_name);
                queryString = queryString.Replace(key11, main_actor_name);
                queryString = queryString.Replace(key12, director);
                queryString = queryString.Replace(key13, branch_number.ToString());
                queryString = queryString.Replace(key1, video_number.ToString());
                queryString = queryString.Replace(key2, staff_number.ToString());
                queryString = queryString.Replace(key3, catalog_number.ToString());
                queryString = queryString.Replace(key4, supplier_number.ToString());
                queryString = queryString.Replace(key5, title);
                queryString = queryString.Replace(key6, category);
                queryString = queryString.Replace(key7, daily_rental_rate.ToString());
                queryString = queryString.Replace(key8, purchase_price.ToString());
                queryString = queryString.Replace(key9, status_);
                return query.Send(queryString);

            }//INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '10?', '?11', '?12', ?13);


            public string DataEntry_e(int member_number, int branch_number, string fullname, int staff_number, string street, string city, string state, string zip_code, string date_of_registry, string staff_name) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO member_info (member_number, branch_number, fullname, staff_number, street, city, state, zip_code, date_of_registry, staff_name) VALUES (?1, ?2, '?3', ?4, '?5', '?6', '?7', '?8', '?9', '?10');";
                queryString = queryString.Replace(key10,staff_name);
                queryString = queryString.Replace(key1,member_number.ToString());
                queryString = queryString.Replace(key2,branch_number.ToString());
                queryString = queryString.Replace(key3,fullname);
                queryString = queryString.Replace(key4,staff_number.ToString());
                queryString = queryString.Replace(key5,street);
                queryString = queryString.Replace(key6,city);
                queryString = queryString.Replace(key7,state);
                queryString = queryString.Replace(key8,zip_code);
                queryString = queryString.Replace(key9,date_of_registry);
                return query.Send(queryString);

            }//INSERT INTO member_info (member_number, branch_number, fullname, staff_number, street, city, state, zip_code, date_of_registry, staff_name) VALUES (?1, ?2, '?3', ?4, '?5', '?6', '?7', '?8', '?9', '?10');


            public string DataEntry_f(int rental_number, int member_number, string member_name, int video_number, string title, double daily_rental_cost, string date_rented, string date_returned, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO rental (rental_number, member_number, member_name, video_number, title, daily_rental_cost, date_rented, date_returned, branch_number) VALUES (?1, ?2, '?3', ?4, '?5', ?6, '?7', '?8', ?9);";
                queryString = queryString.Replace(key1,rental_number.ToString());
                queryString = queryString.Replace(key2,member_number.ToString());
                queryString = queryString.Replace(key3,member_name);
                queryString = queryString.Replace(key4,video_number.ToString());
                queryString = queryString.Replace(key5,title);
                queryString = queryString.Replace(key6,daily_rental_cost.ToString());
                queryString = queryString.Replace(key7,date_rented);
                queryString = queryString.Replace(key8,date_returned);
                queryString = queryString.Replace(key9,branch_number.ToString());
                return query.Send(queryString);

            }//INSERT INTO rental (rental_number, member_number, member_name, video_number, title, daily_rental_cost, date_rented, date_returned, branch_number) VALUES (?1, ?2, '?3', ?4, '?5', ?6, '?7', '?8', ?9);








            public string DataUpdateDelete_a_Update(int branch_number, string street, string city, string state, string zip_code, string telephone_number_1, string telephone_number_2, string telephone_number_3) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE branch SET street = '?1', city = '?2', state = '?3', zip_code = '?4', telephone_number_1 = '?5', telephone_number_2 = '?6', telephone_number_3 = '?7' WHERE branch_number = ?8;";
                queryString = queryString.Replace(key1,street);
                queryString = queryString.Replace(key2,city);
                queryString = queryString.Replace(key3,state);
                queryString = queryString.Replace(key4,zip_code);
                queryString = queryString.Replace(key5,telephone_number_1);
                queryString = queryString.Replace(key6,telephone_number_2);
                queryString = queryString.Replace(key7,telephone_number_3);
                queryString = queryString.Replace(key8,branch_number.ToString());
                return query.Send(queryString);

            }//UPDATE branch SET street = '?1', city = '?2', state = '?3', zip_code = '?4', telephone_number_1 = '?5', telephone_number_2 = '?6', telephone_number_3 = '?7' WHERE branch_number = ?8;

            public string DataUpdateDelete_a_Delete(int branch_number) {
                query = new CoVid_DbQuery(credentials);   
                queryString = "DELETE FROM branch WHERE branch_number = ?1;";
                queryString = queryString.Replace(key1,branch_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM branch WHERE branch_number = ?1;



            public string DataUpdateDelete_b_Update(int staff_number, int branch_number, string fullname, string position, double salary) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE staff SET branch_number = ?1, fullname = '?2', position = '?3', salary = ?4 WHERE staff_number = ?5;";
                queryString = queryString.Replace(key1,branch_number.ToString());
                queryString = queryString.Replace(key2,fullname);
                queryString = queryString.Replace(key3,position);
                queryString = queryString.Replace(key4,salary.ToString());
                queryString = queryString.Replace(key5,staff_number.ToString());
                return query.Send(queryString);

            }//UPDATE staff SET branch_number = ?1, fullname = '?2', position = '?3', salary = ?4 WHERE staff_number = ?5;

            public string DataUpdateDelete_b_Delete(int staff_number) {
                query = new CoVid_DbQuery(credentials);   
                queryString = "DELETE FROM staff WHERE staff_number = ?1;";
                queryString = queryString.Replace(key1,staff_number.ToString());

                return query.Send(queryString);

            }//DELETE FROM staff WHERE staff_number = ?1;



            public string DataUpdateDelete_c_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?12 WHERE video_number = ?13;";
                queryString = queryString.Replace(key10,main_actor_name);
                queryString = queryString.Replace(key11,director);
                queryString = queryString.Replace(key12,branch_number.ToString());
                queryString = queryString.Replace(key13,video_number.ToString());
                queryString = queryString.Replace(key1,staff_number.ToString());
                queryString = queryString.Replace(key2,catalog_number.ToString());
                queryString = queryString.Replace(key3,supplier_number.ToString());
                queryString = queryString.Replace(key4,title);
                queryString = queryString.Replace(key5,category);
                queryString = queryString.Replace(key6,daily_rental_rate.ToString());
                queryString = queryString.Replace(key7,purchase_price.ToString());
                queryString = queryString.Replace(key8,status_);
                queryString = queryString.Replace(key9,main_character_name);
                return query.Send(queryString);

            }//UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?12 WHERE video_number = ?13;


            public string DataUpdateDelete_c_Delete(int video_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "DELETE FROM video WHERE video_number = ?1;";
                queryString = queryString.Replace(key1,video_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM video WHERE video_number = ?1;



            public string DataUpdateDelete_d_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?12 WHERE video_number = ?13;";
                queryString = queryString.Replace(key10, main_actor_name);
                queryString = queryString.Replace(key11, director);
                queryString = queryString.Replace(key12, branch_number.ToString());
                queryString = queryString.Replace(key13, video_number.ToString());
                queryString = queryString.Replace(key1,staff_number.ToString());
                queryString = queryString.Replace(key2, catalog_number.ToString());
                queryString = queryString.Replace(key3, supplier_number.ToString());
                queryString = queryString.Replace(key4, title);
                queryString = queryString.Replace(key5, category);
                queryString = queryString.Replace(key6, daily_rental_rate.ToString());
                queryString = queryString.Replace(key7, purchase_price.ToString());
                queryString = queryString.Replace(key8, status_);
                queryString = queryString.Replace(key9, main_character_name);
                return query.Send(queryString);

            }//UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?12 WHERE video_number = ?13;


            public string DataUpdateDelete_d_Delete(int video_number) {
                query = new CoVid_DbQuery(credentials);   
                queryString = "DELETE FROM video WHERE video_number = ?1;";
                queryString = queryString.Replace(key1,video_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM video WHERE video_number = ?1;



            public string DataUpdateDelete_e_Update(int member_number, int branch_number, string fullname, int staff_number, string street, string city, string state, string zip_code, string date_of_registry, string staff_name) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE member_info SET branch_number = ?1, fullname = '?2', staff_number = ?3, street = '?4', city = '?5', state = '?6', zip_code = '?7', date_of_registry = '?8', staff_name = '?9' WHERE member_number = ?10;";
                queryString = queryString.Replace(key10, member_number.ToString());
                queryString = queryString.Replace(key1, branch_number.ToString());
                queryString = queryString.Replace(key2, fullname);
                queryString = queryString.Replace(key3, staff_number.ToString());
                queryString = queryString.Replace(key4, street);
                queryString = queryString.Replace(key5, city);
                queryString = queryString.Replace(key6, state);
                queryString = queryString.Replace(key7, zip_code);
                queryString = queryString.Replace(key8, date_of_registry);
                queryString = queryString.Replace(key9, staff_name);
                return query.Send(queryString);

            }//UPDATE member_info SET branch_number = ?1, fullname = '?2', staff_number = ?3, street = '?4', city = '?5', state = '?6', zip_code = '?7', date_of_registry = '?8', staff_name = '?9' WHERE member_number = ?10;


            public string DataUpdateDelete_e_Delete(int member_number) {
                query = new CoVid_DbQuery(credentials);   
                queryString = "DELETE FROM member_info WHERE member_number = ?1;";
                queryString = queryString.Replace(key1, member_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM member_info WHERE member_number = ?1;



            public string DataUpdateDelete_f_Update(int rental_number, int member_number, string member_name, int video_number, string title, double daily_rental_cost, string date_rented, string date_returned, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE rental SET member_number = ?1, member_name = '?2', video_number = ?3, title = '?4', daily_rental_cost = ?5, date_rented = '?6', date_returned = '?7', branch_number = ?8 WHERE rental_number = ?9;";
                queryString = queryString.Replace(key1, member_number.ToString());
                queryString = queryString.Replace(key2, member_name);
                queryString = queryString.Replace(key3, video_number.ToString());
                queryString = queryString.Replace(key4, title);
                queryString = queryString.Replace(key5, daily_rental_cost.ToString());
                queryString = queryString.Replace(key6, date_rented);
                queryString = queryString.Replace(key7, date_returned);
                queryString = queryString.Replace(key8, branch_number.ToString());
                queryString = queryString.Replace(key9, rental_number.ToString());
                return query.Send(queryString);

            }//UPDATE rental SET member_number = ?1, member_name = '?2', video_number = ?3, title = '?4', daily_rental_cost = ?5, date_rented = '?6', date_returned = '?7', branch_number = ?8 WHERE rental_number = ?9;


            public string DataUpdateDelete_f_Delete(int rental_number) {
                query = new CoVid_DbQuery(credentials);   
                queryString = "DELETE FROM rental WHERE rental_number = ?1;";
                queryString = queryString.Replace(key1,rental_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM rental WHERE rental_number = ?1;








            public string DataMiscQuerie_a(string city) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT * FROM branch WHERE city = '?1';";
                queryString = queryString.Replace(key1, city);
                return query.Send(queryString,8);

            }//SELECT * FROM branch WHERE city = '?1';


            public string DataMiscQuerie_b(int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT fullname, position, salary FROM staff WHERE branch_number = ?1 ORDER BY fullname;";
                queryString = queryString.Replace(key1, branch_number.ToString());
                return query.Send(queryString,3);

            }//SELECT fullname, position, salary FROM staff WHERE branch_number = ?1 ORDER BY fullname;


            public string DataMiscQuerie_c(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT fullname FROM staff WHERE position = 'Manager' ORDER BY branch_number;";
                return query.Send(queryString,1);

            }//SELECT fullname FROM staff WHERE position = 'Manager' ORDER BY branch_number;


            public string DataMiscQuerie_d(int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT title, category, status_ FROM video WHERE branch_number = ?1 ORDER BY category;";
                queryString = queryString.Replace(key1,branch_number.ToString());
                return query.Send(queryString,3);

            }//SELECT title, category, status_ FROM video WHERE branch_number = ?1 ORDER BY category;


            public string DataMiscQuerie_e(string main_actor_name, string branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT title, category, status_ FROM video WHERE main_actor_name = '?1' AND branch_number = ?2 ORDER BY title;";
                queryString = queryString.Replace(key1,main_actor_name);
                queryString = queryString.Replace(key2,branch_number.ToString());
                return query.Send(queryString,3);

            }//SELECT title, category, status_ FROM video WHERE main_actor_name = '?1' AND branch_number = ?2 ORDER BY title;


            public string DataMiscQuerie_f(string director, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT title, category, status_ FROM video WHERE director = '?1' AND branch_number = ?2 ORDER BY title;";
                queryString = queryString.Replace(key1,director);
                queryString = queryString.Replace(key2,branch_number.ToString());
                return query.Send(queryString,3);

            }//SELECT title, category, status_ FROM video WHERE director = '?1' AND branch_number = ?2 ORDER BY title;


            public string DataMiscQuerie_g(int member_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT * FROM rental WHERE member_number = ?1 AND date_returned = null;";
                queryString = queryString.Replace(key1,member_number.ToString());
                return query.Send(queryString,9);

            }//SELECT * FROM rental WHERE member_number = ?1 AND date_returned = null;


            public string DataMiscQuerie_h(int catalog_number, int branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT * FROM video WHERE catalog_number = ?1 AND branch_number = ?2;";
                queryString = queryString.Replace(key1,catalog_number.ToString());
                queryString = queryString.Replace(key2,branch_number.ToString());
                return query.Send(queryString,13);

            }//SELECT * FROM video WHERE catalog_number = ?1 AND branch_number = ?2;


            public string DataMiscQuerie_i(string category) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT title FROM video WHERE category = '?1' ORDER BY title;";
                queryString = queryString.Replace(key1,category);
                return query.Send(queryString,1);

            }//SELECT title FROM video WHERE category = '?1' ORDER BY title;


            public string DataMiscQuerie_j(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(video_number) FROM video GROUP BY category, branch_number ORDER BY branch_number;";
                return query.Send(queryString,1);

            }//SELECT count(video_number) FROM video GROUP BY category, branch_number ORDER BY branch_number;


            public string DataMiscQuerie_k(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT SUM(daily_rental_cost) FROM rental;";
                return query.Send(queryString,1);

            }//SELECT SUM(daily_rental_cost) FROM rental;


            public string DataMiscQuerie_l(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT main_actor_name, count(video_number) FROM video GROUP BY main_actor_name ORDER BY main_actor_name;";
                return query.Send(queryString,2);

            }//SELECT main_actor_name, count(video_number) FROM video GROUP BY main_actor_name ORDER BY main_actor_name;


            public string DataMiscQuerie_m(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT branch_number, count(member_number) FROM member_info WHERE date_of_registry LIKE '%2020%' GROUP BY branch_number ORDER BY branch_number;";
                return query.Send(queryString,2);

            }//SELECT branch_number, count(member_number) FROM member_info WHERE date_of_registry LIKE '%2020%' GROUP BY branch_number ORDER BY branch_number;


            public string DataMiscQuerie_n(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT sum(daily_rental_rate) FROM video GROUP BY branch_number ORDER BY branch_number;";
                return query.Send(queryString,1);

            }//SELECT sum(daily_rental_rate) FROM video GROUP BY branch_number ORDER BY branch_number;


        }

        /// <summary>
        /// 
        /// </summary>
        public class Business {
            //public ServerCredentials credentials;

            //protected CoVid_DbQuery query;

            public string DataEntry_a(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, string branch_number) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '?10', '?11', '?12', ?13);";
                queryString = queryString.Replace(key10, main_character_name);
                queryString = queryString.Replace(key11, main_actor_name);
                queryString = queryString.Replace(key12, director);
                queryString = queryString.Replace(key13, branch_number.ToString());
                queryString = queryString.Replace(key1, video_number.ToString());
                queryString = queryString.Replace(key2, staff_number.ToString());
                queryString = queryString.Replace(key3, catalog_number.ToString());
                queryString = queryString.Replace(key4, supplier_number.ToString());
                queryString = queryString.Replace(key5, title);
                queryString = queryString.Replace(key6, category);
                queryString = queryString.Replace(key7, daily_rental_rate.ToString());
                queryString = queryString.Replace(key8, purchase_price.ToString());
                queryString = queryString.Replace(key9, status_);
                return query.Send(queryString);
            }//INSERT INTO video (video_number, staff_number, catalog_number, supplier_number, title, category, daily_rental_rate, purchase_price, status_, main_character_name, main_actor_name, director, branch_number) VALUES (?1, ?2, ?3, ?4, '?5', '?6', ?7, ?8, '?9', '?10', '?11', '?12', ?13);



            public string DataEntry_b(int supplier_number, string supplier_name, string street, string city, string state, string zip_code, string telephone_number, string status_) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO video_supplier (supplier_number, supplier_name, street, city, state, zip_code, telephone_number, status_) VALUES (?1, '?2', '?3', '?4', '?5', '?6', '?7', '?8');";
                queryString = queryString.Replace(key1,supplier_number.ToString());
                queryString = queryString.Replace(key2,supplier_name);
                queryString = queryString.Replace(key3,street);
                queryString = queryString.Replace(key4,city);
                queryString = queryString.Replace(key5,state);
                queryString = queryString.Replace(key6,zip_code);
                queryString = queryString.Replace(key7,telephone_number);
                queryString = queryString.Replace(key8,status_);
                return query.Send(queryString);

            }//INSERT INTO video_supplier (supplier_number, supplier_name, street, city, state, zip_code, telephone_number, status_) VALUES (?1, '?2', '?3', '?4', '?5', '?6', '?7', '?8');

            public string DataEntry_c(int order_number, int branch_number, int supplier_number, string supplier_street, string supplier_city, string supplier_state, string supplier_zip_code, int video_catalog_number, string video_title, double video_purchase_price, int quantity, string date_order_placed, string date_order_received, string branch_street, string branch_city, string branch_state, string branch_zip_code) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "INSERT INTO video_order (order_number, branch_number, supplier_number, supplier_street, supplier_city, supplier_state, supplier_zip_code, video_catalog_number, video_title, video_purchase_price, quantity, date_order_placed, date_order_received, branch_street, branch_city, branch_state, branch_zip_code) VALUES (?1, ?2, ?3, '?4', '?5', '?6', '?7', ?8, '?9', ?10, ?11, '?12', '?13', '?14', '?15', '?16', '?17'); ";
                queryString = queryString.Replace(key10,video_purchase_price.ToString());
                queryString = queryString.Replace(key11,quantity.ToString());
                queryString = queryString.Replace(key12,date_order_placed);
                queryString = queryString.Replace(key13,date_order_received);
                queryString = queryString.Replace(key14,branch_street);
                queryString = queryString.Replace(key15,branch_city);
                queryString = queryString.Replace(key16,branch_state);
                queryString = queryString.Replace(key17,branch_zip_code);
                queryString = queryString.Replace(key1,order_number.ToString());
                queryString = queryString.Replace(key2,branch_number.ToString());
                queryString = queryString.Replace(key3,supplier_number.ToString());
                queryString = queryString.Replace(key4,supplier_street);
                queryString = queryString.Replace(key5,supplier_city);
                queryString = queryString.Replace(key6,supplier_state);
                queryString = queryString.Replace(key7,supplier_zip_code);
                queryString = queryString.Replace(key8,video_catalog_number.ToString());
                queryString = queryString.Replace(key9,video_title);
                return query.Send(queryString);

            }//INSERT INTO video_order (order_number, branch_number, supplier_number, supplier_street, supplier_city, supplier_state, supplier_zip_code, video_catalog_number, video_title, video_purchase_price, quantity, date_order_placed, date_order_received, branch_street, branch_city, branch_state, branch_zip_code) VALUES (?1, ?2, ?3, '?4', '?5', '?6', '?7', ?8, '?9', ?10, ?11, '?12', '?13', '?14', '?15', '?16', '?17'); 





            public string DataUpdateDelete_a_Update(int video_number, int staff_number, int catalog_number, int supplier_number, string title, string category, double daily_rental_rate, double purchase_price, string status_, string main_character_name, string main_actor_name, string director, int branch_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?12 WHERE video_number = ?13;";
                queryString = queryString.Replace(key10, main_actor_name);
                queryString = queryString.Replace(key11, director);
                queryString = queryString.Replace(key12, branch_number.ToString());
                queryString = queryString.Replace(key13, video_number.ToString());
                queryString = queryString.Replace(key1, staff_number.ToString());
                queryString = queryString.Replace(key2, catalog_number.ToString());
                queryString = queryString.Replace(key3, supplier_number.ToString());
                queryString = queryString.Replace(key4, title);
                queryString = queryString.Replace(key5, category);
                queryString = queryString.Replace(key6, daily_rental_rate.ToString());
                queryString = queryString.Replace(key7, purchase_price.ToString());
                queryString = queryString.Replace(key8, status_);
                queryString = queryString.Replace(key9, main_character_name);
                return query.Send(queryString);

            }//UPDATE video SET staff_number = ?1, catalog_number = ?2, supplier_number = ?3, title = '?4', category = '?5', daily_rental_rate = ?6, purchase_price = ?7, status_ = '?8', main_character_name = '?9', main_actor_name = '?10', director = '?11', branch_number = ?11 WHERE video_number = ?12;

            public string DataUpdateDelete_a_Delete(int video_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "DELETE FROM video WHERE video_number = ?1;";
                queryString = queryString.Replace(key1,video_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM video WHERE video_number = ?1;


            public string DataUpdateDelete_b_Update(int supplier_number, string supplier_name, string street, string city, string state, string zip_code, string telephone_number, string status_){
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE video_supplier SET supplier_name = '?1', street = '?2', city = '?3', state = '?4', zip_code = '?5', telephone_number = '?6', status_ = '?7' WHERE supplier_number = ?8;";
                queryString = queryString.Replace(key1, supplier_name);
                queryString = queryString.Replace(key2, street);
                queryString = queryString.Replace(key3, city);
                queryString = queryString.Replace(key4, state);
                queryString = queryString.Replace(key5, zip_code);
                queryString = queryString.Replace(key6, telephone_number);
                queryString = queryString.Replace(key7, status_);
                queryString = queryString.Replace(key8, supplier_number.ToString());
                return query.Send(queryString);

            }//UPDATE video_supplier SET supplier_name = '?1', street = '?2', city = '?3', state = '?4', zip_code = '?5', telephone_number = '?6', status_ = '?7' WHERE supplier_number = ?8;

            public string DataUpdateDelete_b_Delete(int supplier_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "DELETE FROM video_supplier WHERE supplier_number = ?1;";
                queryString = queryString.Replace(key1,supplier_number.ToString());
                return query.Send(queryString);

            }//DELETE FROM video_supplier WHERE supplier_number = ?1;


            public string DataUpdateDelete_c_Update(int order_number, int branch_number, int spplier_number, string supplier_street, string supplier_city, string supplier_state, string supplier_zip_code, int video_catalog_number, string video_title, double video_purchase_price, int quantity, string date_order_placed, string date_order_received, string branch_street, string branch_city, string branch_state, string branch_zip_code){
                query = new CoVid_DbQuery(credentials);  
                queryString = "UPDATE video_order SET branch_number = ?1, spplier_number = ?2, supplier_street = '?3', supplier_city = '?4', supplier_state = '?5', supplier_zip_code = '?6', video_catalog_number = ?7, video_title = '?8', video_purchase_price = ?9, quantity = ?10, date_order_placed = '?11', date_order_received = '?12', branch_street = '?13', branch_city = '?14', branch_state = '?15', branch_zip_code = '?16' WHERE order_number = ?17;";
                queryString = queryString.Replace(key10, quantity.ToString());
                queryString = queryString.Replace(key11, date_order_placed);
                queryString = queryString.Replace(key12, date_order_received);
                queryString = queryString.Replace(key13, branch_street);
                queryString = queryString.Replace(key14, branch_city);
                queryString = queryString.Replace(key15, branch_state);
                queryString = queryString.Replace(key16, branch_zip_code);
                queryString = queryString.Replace(key17, order_number.ToString());
                queryString = queryString.Replace(key1, branch_number.ToString());
                queryString = queryString.Replace(key2, spplier_number.ToString());
                queryString = queryString.Replace(key3, supplier_street);
                queryString = queryString.Replace(key4, supplier_city);
                queryString = queryString.Replace(key5, supplier_state);
                queryString = queryString.Replace(key6, supplier_zip_code);
                queryString = queryString.Replace(key7, video_catalog_number.ToString());
                queryString = queryString.Replace(key8, video_title);
                queryString = queryString.Replace(key9, video_purchase_price.ToString());
                return query.Send(queryString);

            }//UPDATE video_order SET branch_number = ?1, spplier_number = ?2, supplier_street = '?3', supplier_city = '?4', supplier_state = '?5',
             //supplier_zip_code = '?6', video_catalog_number = ?7, video_title = '?8', video_purchase_price = ?9, quantity = ?10, date_order_placed = '?11',
             //date_order_received = '?12', branch_street = '?13', branch_city = '?14', branch_state = '?15', branch_zip_code = '?16' WHERE order_number = ?17;

            public string DataUpdateDelete_c_Delete(int order_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "DELETE  FROM video_order WHERE order_number = ?1;";
                queryString = queryString.Replace(key1, order_number.ToString());
                return query.Send(queryString);

            }//DELETE  FROM video_order WHERE order_number = ?1;



            public string DataMiscQuerie_a(/*No parameter*/) {
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT fullname, position, salary FROM staff ORDER BY branch_number;";
                return query.Send(queryString,3);

            }//SELECT fullname, position, salary FROM staff ORDER BY branch_number;

            public string DataMiscQuerie_b(int staff_branch_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT staff.fullname, branch.telephone_number_1 FROM staff, branch WHERE branch.branch_number = staff.branch_number AND staff.position = 'Manager' AND staff.branch_number = ?1;";
                queryString = queryString.Replace(key1, staff_branch_number.ToString());
                return query.Send(queryString,2);

            }//SELECT staff.fullname, branch.telephone_number_1 FROM staff, branch WHERE branch.branch_number = staff.branch_number AND staff.position = 'Manager' AND staff.branch_number = ?1;

            public string DataMiscQuerie_c(int branch_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT catalog_number, title FROM video WHERE branch_number = ?1 ORDER BY title;";
                queryString = queryString.Replace(key1, branch_number.ToString());
                return query.Send(queryString,2);

            }//SELECT catalog_number, title FROM video WHERE branch_number = ?1 ORDER BY title;

            public string DataMiscQuerie_d(int branch_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(catalog_number) FROM video WHERE branch_number = ?1;";
                queryString = queryString.Replace(key1, branch_number.ToString());
                return query.Send(queryString,1);

            }//SELECT count(catalog_number) FROM video WHERE branch_number = ?1;

            public string DataMiscQuerie_e(/*No parameter*/){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(member_number) FROM member_info GROUP BY branch_number ORDER BY branch_number;";
                return query.Send(queryString,1);

            }//SELECT count(member_number) FROM member_info GROUP BY branch_number ORDER BY branch_number;

            public string DataMiscQuerie_f(/*No parameter*/){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(member_number) FROM member_info WHERE date_of_registry LIKE '%2022%' GROUP BY branch_number ORDER BY branch_number;";
                return query.Send(queryString,1);

            }//SELECT count(member_number) FROM member_info WHERE date_of_registry LIKE '%2022%' GROUP BY branch_number ORDER BY branch_number;

            public string DataMiscQuerie_g(string first_date_rented, string second_date_rented){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(rental_number) FROM rental WHERE date_rented BETWEEN '?1' AND '?2' GROUP BY branch_number ORDER BY branch_number;";
                queryString = queryString.Replace(key1, first_date_rented);
                queryString = queryString.Replace(key2, second_date_rented);
                return query.Send(queryString,1);

            }//SELECT count(rental_number) FROM rental WHERE date_rented BETWEEN '?1' AND '?2' GROUP BY branch_number ORDER BY branch_number;

            public string DataMiscQuerie_h(int branch_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(video_number) FROM video WHERE branch_number = ?1 GROUP BY category  ORDER BY category;";
                queryString = queryString.Replace(key1, branch_number.ToString());
                return query.Send(queryString,1);

            }//SELECT count(video_number) FROM video WHERE branch_number = ?1 GROUP BY category  ORDER BY category;

            public string DataMiscQuerie_i(/*No parameter*/){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT supplier_name, street, city, state, zip_code, telephone_number FROM video_supplier ORDER BY supplier_number;";
                return query.Send(queryString,6);

            }//SELECT supplier_name, street, city, state, zip_code, telephone_number FROM video_supplier ORDER BY supplier_number;

            public string DataMiscQuerie_j(int supplier_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT supplier_name, telephone_number FROM video_supplier WHERE supplier_number = ?1;";
                queryString = queryString.Replace(key1, supplier_number.ToString());
                return query.Send(queryString,2);

            }//SELECT supplier_name, telephone_number FROM video_supplier WHERE supplier_number = ?1;

            public string DataMiscQuerie_k(int supplier_number){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT * FROM video_order WHERE supplier_number = ?1 ORDER BY date_order_placed;";
                queryString = queryString.Replace(key1, supplier_number.ToString());
                return query.Send(queryString,17);

            }//SELECT * FROM video_order WHERE supplier_number = ?1 ORDER BY date_order_placed;

            public string DataMiscQuerie_l(string date_order_placed){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT * FROM video_order WHERE date_order_placed = '?1';";
                queryString = queryString.Replace(key1, date_order_placed);
                return query.Send(queryString,17);

            }//SELECT * FROM video_order WHERE date_order_placed = '?1';

            public string DataMiscQuerie_m(string first_date, string second_date){
                query = new CoVid_DbQuery(credentials);  
                queryString = "SELECT count(rental_number) FROM rental WHERE date_rented BETWEEN '?1' AND '?2' GROUP BY branch_number ORDER BY branch_number;";
                queryString = queryString.Replace(key1, first_date);
                queryString = queryString.Replace(key2, second_date);
                return query.Send(queryString,1);

            }//SELECT count(rental_number) FROM rental WHERE date_rented BETWEEN '?1' AND '?2' GROUP BY branch_number ORDER BY branch_number;
        }


    }
}
