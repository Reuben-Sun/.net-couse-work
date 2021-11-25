using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLite_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string connectionString = "Data Source=../testDB.db";

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Sqlite Demo Begin!");

            using (UserRepository userRepository =
               new UserRepository(connectionString))
            {
                //userRepository.DeleteFromLOGTable();
                Console.WriteLine("Creating LOG table\n");
                userRepository.CreateLogTable();
            }


        }


        private void createTableButton_Click(object sender, EventArgs e)
        {
            using (UserRepository userRepository =
                new UserRepository(connectionString))
            {
                Console.WriteLine("Creating STUDENT table\n");
                userRepository.InsertIntoLogTable("Creating STUDENT table");
                userRepository.CreateUserTable();
                
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (UserRepository userRepository =
                new UserRepository(connectionString))
            {
                Console.WriteLine("Inserting data to user table\n");
                userRepository.InsertIntoLogTable("Inserting data to user table");
                userRepository.InsertIntoUserTable(new Student() { Name = nameText.Text, Classes = classText.Text, School = schoolText.Text });
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            using (UserRepository userRepository =
                new UserRepository(connectionString))
            {             
                Console.WriteLine("Selecting data\n");
                userRepository.InsertIntoLogTable("Selecting data");
                userRepository.SelectFromUserTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (UserRepository userRepository =
                new UserRepository(connectionString))
            {
                Console.WriteLine("\nDeleting data\n");
                userRepository.InsertIntoLogTable("Deleting data");
                userRepository.DeleteFromUserTable();

            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            using (UserRepository userRepository =
                new UserRepository(connectionString))
            {
                userRepository.SelectFromLogTable();

            }
        }
    }
}
