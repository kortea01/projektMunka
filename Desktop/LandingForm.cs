using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Http;
using System.Net;

namespace RestaurantDesktopApp
{
    public partial class LandingForm : Form
    {
        private string loginApiEndPoint = ReadSettings("endpointUrlLogin");
        private string userApiEndPoint = ReadSettings("endpointUrlUsers");
        private HttpClient client;

        public LandingForm()
        {
            InitializeComponent();
            menuStrip.Hide();            
            client = new HttpClient();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void restaurantMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurantMenuForm restaurantMenuForm = new RestaurantMenuForm();
            restaurantMenuForm.Show();

        }

        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredientsForm = new IngredientsForm();
            ingredientsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {

            //TODO: call login api, get the bearer token, check user role
            string username = userEmail.Text;
            string password = userPassword.Text;

            try
            {
                string token = await Login(username, password);                
                if (!string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Login successful!");
                    // Here you can navigate to another form or perform any other actions
                    //Hide the groupbox
                    loginGroupBox.Hide();
                    menuStrip.Show();
                    User user = await GetUserData(token);
                    if (user != null)
                    {
                        MessageBox.Show("Welcome to BellaItalia dear " + user.FirstName + " " + user.LastName);
                    }                   

                }
                else
                {
                    MessageBox.Show("Login failed. Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }            
        }

        private async Task<string> Login(string username, string password)
        {
            var loginData = new { email = username, password = password };
            var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

            using (var response = await client.PostAsync(loginApiEndPoint, content))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                // Assuming your API returns a token in the response
                // Modify this according to your actual response format
                dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                return responseData.token;
            }
        }

        // Method to get user data after successful login
        private async Task<User> GetUserData(string token)
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            using (var response = await client.GetAsync(userApiEndPoint))
            {
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                // Assuming your API returns user data in the response
                // Modify this according to your actual response format
                dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(responseBody);
                return responseData;
            }
        }

        // Define a class to represent your user data
        private class UserData
        {
            // Add properties according to your user data structure
        }

        private static string ReadSettings(string keyName)
        {
            string result = null;
            try
            {
                var value = System.Configuration.ConfigurationSettings.AppSettings;

                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your Restaurant manager for further details");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This functionality is under development");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }



}