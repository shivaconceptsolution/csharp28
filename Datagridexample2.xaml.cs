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
using System.Windows.Shapes;

namespace WpfAdvanceControl
{
    /// <summary>
    /// Interaction logic for Datagridexample2.xaml
    /// </summary>
    public partial class Datagridexample2 : Window
    {
        public Datagridexample2()
        {
            InitializeComponent();
            List<User> users = new List<User>();
           
            users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "logo2.png" });
            users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "logo2.png" });
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "logo2.png" });

            dgUsers.ItemsSource = users;

        }
        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime Birthday { get; set; }
            public string ImageUrl { get; set; }
            public string Details
            {
                get
                {
                    return String.Format("{0} was born on {1} and this is a long description of the person.", this.Name, this.Birthday.ToLongDateString());
                }
            }
        }

    }
}
