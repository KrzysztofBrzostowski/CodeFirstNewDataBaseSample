using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public MainWindow()
        {

            InitializeComponent();
            Loaded += MainWindow_Loaded;




            //using (var db = new BloggingContext())
            //{
            //    // Create and save a new Blog
            //    Console.Write("Enter a name for a new Blog: ");
            //    var name = Console.ReadLine();

            //    var blog = new Blog { Name = name };
            //    db.Blogs.Add(blog);
            //    db.SaveChanges();

            //    // Display all Blogs from the database
            //    var query = from b in db.Blogs
            //                orderby b.Name
            //                select b;

            //    Console.WriteLine("All blogs in the database:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //    Console.WriteLine("Press any key to exit...");
            //    Console.ReadKey();
            //}

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            using (var db = new Model1())
            {
                var entit = new MyEntity { Id = 2, Name = "bcd" };
                db.MyEntities.Add(entit);
                db.SaveChanges();
            }

        }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

}
