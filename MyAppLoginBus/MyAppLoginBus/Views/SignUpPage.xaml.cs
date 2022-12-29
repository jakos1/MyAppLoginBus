using MyAppLoginBus.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAppLoginBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        public async void CreateNewUserProcedure(object sender, EventArgs e)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            MySqlConnection conn = new MySqlConnection(Constants.ConnectionString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Constants.SelectALL, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    users.Add(rdr.GetString(1), rdr.GetString(3));
                }
                rdr.Close();
            }
            conn.Close();
            if ((Entry_UserName.Text != null && !Entry_UserName.Text.Equals("")) && (Entry_Password.Text != null && !Entry_Password.Text.Equals("")) && (Entry_Email.Text != null && !Entry_Email.Text.Equals("")))
            {
                if (users.ContainsKey(Entry_UserName.Text))
                {
                    if (users[Entry_UserName.Text] == Entry_Email.Text)
                    {
                        DisplayAlert("Error", "Email already is use!", "Ok!");
                    }
                    else
                    {
                        DisplayAlert("Error", "That user already exists", "Ok!");
                    }

                }
                else
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = Constants.InsertNewUser;
                    cmd.Parameters.Add("@USERNAME", MySqlDbType.VarChar).Value = Entry_UserName.Text;
                    cmd.Parameters.Add("@PASSWORD", MySqlDbType.VarChar).Value = Entry_Password.Text;
                    cmd.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Entry_Email.Text;
                    cmd.ExecuteNonQueryAsync();
                    conn.Close();
                    DisplayAlert("Signed up", "Signing up sucsessfull please log in!", "Ok!");
                }
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                DisplayAlert("Error", "Please fill out all fields", "Ok!");
            }
        }
    }
}