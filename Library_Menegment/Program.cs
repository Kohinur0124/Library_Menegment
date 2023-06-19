namespace Library_Menegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var LibraryManagement = new LibraryManagementCore(DataSource.Books, DataSource.Users);
            LibraryManagement.DisplayAllUsers();
            LibraryManagement.DisplayAllBooks();

            
        }
    }
}