using UserBlog.Models;

namespace UserBlog
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            User user = new User();
            bool running = true;
            do
            {
                Console.WriteLine("=========Menyu===========");
                Console.WriteLine("1. Register");
                Console.WriteLine("2 Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your surname:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        Console.WriteLine("Password must contain min 8 characters, begin upper case and 1 number .");
                        string password = Console.ReadLine();

                        UserServices.Register(name, surname, password);

                        break;

                    case "2":
                        Console.WriteLine("Enter username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        Console.WriteLine("Password must contain min 8 characters, begin upper case and 1 number .");
                        string password2 = Console.ReadLine();
                        UserServices.Login(username, password2);

                        bool checkLogin = true;

                        do
                        {
                            Console.WriteLine("1. Blog elave et");
                            Console.WriteLine("2. Blog sil");
                            Console.WriteLine("3. Blog detail");
                            Console.WriteLine("4. Butun bloglara bax");
                            Console.WriteLine("5. Bloglari filterle ");
                            Console.WriteLine("0. Proqramı bitir");
                            string input2 = Console.ReadLine();
                            Blog blog = null;
                            switch (input2)

                            {
                                case "1":
                                    Console.WriteLine("");
                                    BlogService.AddBlog(blog);
                                    break;


                                case "2":
                                    Console.WriteLine("Enter id:");
                                    string id = Console.ReadLine();
                                    if (int.TryParse(id, out int id2))
                                    {
                                        BlogService.RemoveBlog(id2);
                                    }

                                    break;


                                case "3":
                                    Console.WriteLine("Enter id:");
                                    string id3 = Console.ReadLine();
                                    if (int.TryParse(id3, out int id4))
                                    {
                                        BlogService.GetBlogById(id4);
                                    }
                                    break;

                                case "4":
                                    BlogService.GetAllBlogs();
                                    break;

                                case "5":
                                    break;


                                
                                case "0":
                                    Console.WriteLine("Exit!");
                                    break;
                                default:
                                    Console.WriteLine("Please make the right choice.");
                                    break;


                            }



                        } while (checkLogin);

                        break;
                    case "3":
                        Console.WriteLine("Exit!");
                        break;
                        default :
                        Console.WriteLine("Please make the right choice.");
                        break ;
                   
                }

            }while(running);
        } 
    } 
}