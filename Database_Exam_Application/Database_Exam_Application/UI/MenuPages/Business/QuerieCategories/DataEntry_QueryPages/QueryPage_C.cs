using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Exam_Application.UI.MenuPages.Business.QuerieCategories.DataEntry_QueryPages {
    internal class QueryPage_C : Page {
        CoVidRental.CoVidRental coVidRental;



        int order_number;
        int branch_number;
        int supplier_number;

        string supplier_street;
        string supplier_city;
        string supplier_state;
        string supplier_zip_code;

        int video_catalog_number;

        string video_title;

        double video_purchase_price;

        int quantity;

        string date_order_placed;
        string date_order_received;
        string branch_street;
        string branch_city;
        string branch_state;
        string branch_zip_code;
    
        

        string caseMenu;
        string choice;

        public QueryPage_C(CoVidRental.CoVidRental coVidRental, string caseMenu) {
            this.coVidRental = coVidRental;
            this.caseMenu = caseMenu;

        }

        internal override void Run() {
            while(true) {


                MenuRenderClear();
                MenuRender(caseMenu);
                Draw();


                MenuRender("order_number:"); Draw();  IntegerInputSanitation(out order_number);
                MenuRender("branch_number:"); Draw();  IntegerInputSanitation(out branch_number);
                MenuRender("supplier_number:"); Draw();  IntegerInputSanitation(out supplier_number);


                MenuRender("supplier_street:"); Draw(); supplier_street = MenuUserInput();
                MenuRender("supplier_city:"); Draw(); supplier_city = MenuUserInput();
                MenuRender("supplier_state:"); Draw(); supplier_state = MenuUserInput();
                MenuRender("supplier_zip_code:"); Draw(); supplier_zip_code  = MenuUserInput();

                MenuRender("video_catalog_number:"); Draw();  IntegerInputSanitation(out video_catalog_number);
                
                MenuRender("video_title:"); Draw(); video_title = MenuUserInput();
                
                MenuRender("video_purchase_price:"); Draw(); DoubleInputSanitation(out video_purchase_price);
                
                MenuRender("quantity:"); Draw();  IntegerInputSanitation(out quantity);
                
                MenuRender("date_order_placed:"); Draw(); date_order_placed = MenuUserInput();
                MenuRender("date_order_received:"); Draw(); date_order_received = MenuUserInput();
                MenuRender("branch_street:"); Draw(); branch_street = MenuUserInput();
                MenuRender("branch_city:"); Draw(); branch_city = MenuUserInput();
                MenuRender("branch_state:"); Draw(); branch_state = MenuUserInput();
                MenuRender("branch_zip_code:"); Draw(); branch_zip_code  = MenuUserInput();

                ResultRender(coVidRental.business.DataEntry_c( order_number, branch_number, supplier_number, supplier_street, supplier_city, supplier_state, supplier_zip_code, video_catalog_number, video_title, video_purchase_price, quantity, date_order_placed, date_order_received, branch_street, branch_city, branch_state, branch_zip_code));

                MenuRender("Run query again? (y/N)");
                Draw();
                choice = MenuUserInput();
                if(choice.ToLower() == "n" || choice == "") {
                    return;
                }
            }
        }
         
    }
}
