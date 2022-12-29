using MyAppLoginBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySqlConnector;
using System.Collections;

namespace MyAppLoginBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginProcedure(object s, EventArgs e)
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
                    users.Add(rdr.GetString(1),rdr.GetString(2));
                }
                rdr.Close();
            }
            conn.Close();
            if ((Entry_UserName.Text != null && !Entry_UserName.Text.Equals("")) && (Entry_Password.Text != null && !Entry_Password.Text.Equals("")))
            {


                if (users.ContainsKey(Entry_UserName.Text)) //need to check for empty 
                {
                    string pwd = users[Entry_UserName.Text];
                    if (pwd == Entry_Password.Text)
                    {
                        DisplayAlert("Sucsess", "You Have Logged In!", "Ok!");
                    }
                    else
                    {
                        DisplayAlert("Error", "Incorrect Username Or Password", "Ok!");
                    }
                }
                else
                {
                    DisplayAlert("Error", "No user found, please Sign Up!", "Ok!");
                }
            }
            else
            {
                DisplayAlert("Error", "Please fill out all the fields!", "Ok!");
            }
        }
        public async void SignUpProcedure(object s, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}