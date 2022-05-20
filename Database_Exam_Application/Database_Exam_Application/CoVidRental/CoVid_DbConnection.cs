using MySqlConnector;


namespace Database_Exam_Application.CoVidRental {
    /// <summary>
    /// Represent a connection to the database
    /// </summary>
    /// 
    /// <remarks>
    /// The class implyfies the use of <see cref="MySqlConnection"/> slightly,
    /// abstracting the string used to configure the connection. Also slightly secures and automates its use.
    /// </remarks>
    internal class CoVid_DbConnection { //Implement, dispose maybe     : IDisposable{
        

        //Class1 klaass = new Class1(); //To be removed
        
        private string connectionString;
        
        private MySqlConnection connector;

        // Rewrite to use ServerCredentials struct
        //string server;
        //string user;
        //string database;
        //string port;
        //string password;

        ServerCredentials credentials;

        private bool disposedValue;



        /// <summary>
        /// Constructor of <see cref="CoVid_DbConnection"/>.
        /// </summary>
        /// <remarks>
        /// Initializes class variables, constructs the connection string and opens a connection to the wanted database from defined server.
        /// It will throw and print an exception if it fails to open a connection
        /// </remarks>
        /// <exception>
        /// </exception>
        /// <param name="address_"><see cref="string"/>, Address of the server (localhost by default)</param>
        /// <param name="port_"><see cref="string"/>, Port number to access server via</param>
        /// <param name="username_"><see cref="string"/>, Name of user to log into server with</param>
        /// <param name="password_"><see cref="string"/>, Users password</param>
        /// <param name="database_"><see cref="string"/>, Name of the database to access within the server</param>
        public CoVid_DbConnection(string address_, string port_, string username_, string password_, string database_) {

            this.credentials.password = password_; // Insecure or something i guess, should probably be a hash instead of clear text
            this.credentials.address = address_;
            this.credentials.username = username_;
            this.credentials.database = database_;
            this.credentials.port = port_;

            connectionString = "server=" + this.credentials.address + ";user=" + this.credentials.username + ";database=" + this.credentials.database + ";port=" + this.credentials.port + ";password=" + this.credentials.password;

            connector = new MySqlConnection(connectionString);
            try {
                Console.WriteLine("Connecting to database...");
                connector.Open();
            } catch(Exception excep) {
                Console.WriteLine("Failed to connect!");
                Console.WriteLine(excep);
            }

        }


        /// <summary>
        /// Constructor of <see cref="CoVid_DbConnection"/>.
        /// </summary>
        /// <remarks>
        /// Initializes class variables, constructs the connection string and opens a connection to the wanted database from defined server.
        /// It will throw and print an exception if it fails to open a connection
        /// </remarks>
        /// <exception>
        /// </exception>
        /// <param name="credentials_"> A <see cref="ServerCredentials"/> object containing necessary server information</param>
        public CoVid_DbConnection(ServerCredentials credentials_) {

            this.credentials = credentials_;

            connectionString = "server=" + this.credentials.address + ";user=" + this.credentials.username + ";database=" + this.credentials.database + ";port=" + this.credentials.port + ";password=" + this.credentials.password;

            connector = new MySqlConnection(connectionString);
            try {
                Console.WriteLine("Connecting to database...");
                connector.Open();
            } catch(Exception excep) {
                Console.WriteLine("Failed to connect!");
                Console.WriteLine(excep);
            }

        }

        /// <summary>
        /// Getter for the <see cref="MySqlConnection"/> connector of the object.
        /// </summary>
        /// <returns>Returns a <see cref="MySqlConnection connector"/></returns>
        public ref MySqlConnection GetConnection() {
            return ref connector;
        }

        /// <summary>
        /// A function to manually close the <see cref="MySqlConnection"/> connector of the object
        /// </summary>
        public void ConnectionManualStop() {
            connector.Close();
        }

        /// <summary>
        /// A function to manually start the <see cref="MySqlConnection"/> connector of the object./n
        /// It will throw and print an exception if it fails to open a connection
        /// </summary>
        public void ConnectionManualStart() {
            try {
                Console.WriteLine("Connecting to database...");
                connector.Open();
            } catch(Exception excep) {
                Console.WriteLine("Failed to connect!");
                Console.WriteLine(excep);
            }
        }

        /*
         * Implement Dispose maybe
        protected virtual void Dispose(bool disposing) {
            if(!disposedValue) {
                if(disposing) {
                    // TODO: dispose managed state (managed objects)
                }
                connector.;
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~CoVid_DbConnection()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose() {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }*/
    }
}
