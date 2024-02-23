namespace NameDB;

public class Utilities
{
    public static string GetConnectionString()
        {
            var database = "Names";
            var server = Environment.GetEnvironmentVariable("db_server");
            var user = Environment.GetEnvironmentVariable("db_user");
            var password = Environment.GetEnvironmentVariable("db_passwd");
            
            // Check if any of the required environment variables are missing
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(database))
            {
                throw new InvalidOperationException("Missing database environment variables.");
            }

            // Construct and return the connection string
            return $"server={server};user={user};password={password};database={database};";
        }
}
