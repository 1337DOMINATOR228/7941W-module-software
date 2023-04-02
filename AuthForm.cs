using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _79412W13._56MHz125KHz
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        public event EventHandler AccessGranted;
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;user=root;password=1337;database=vaulttechsecure;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            if (textBox1.Text != "" && textBox2.Text != "")
                try
                {
                        connection.Open();
                        string sql = "SELECT \'" + textBox1.Text.ToString() + "\'= LogIn FROM administration WHERE Password =\'" + textBox2.Text.ToString()+"\'";

                        MySqlCommand command = new MySqlCommand(sql, connection);

                        object respond = command.ExecuteScalar();
                        if (respond != null) 
                        {
                            AccessGranted?.Invoke(this, new EventArgs());

                        }

                        else MessageBox.Show("Access denied");
                        connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else MessageBox.Show("Вы не заполнили поля!");
        }
    }
}
