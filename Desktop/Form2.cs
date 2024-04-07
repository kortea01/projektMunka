using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using RestaurantDesktopApp;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;



namespace RestaurantDesktopApp
{
    public partial class Form2 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSettings("endpointUrl");

        

        private static string ReadSettings(string keyName)
        {
            string result = null;
            try
            {
                //var value = ConfigurationSettings.AppSettings;
                var value = System.Configuration.ConfigurationSettings.AppSettings;

                result = value[keyName];
            }
            catch (ConfigurationException ex) {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {               
            refreshMenu();
        }

        private async void refreshMenu()
        {
            listBox_RestaurantMenu.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                //HttpResponseMessage response = await client.GetAsync("https://mocki.io/v1/6729685f-22e0-4161-9dbb-619593fd9cc5");            
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var restaurantMenu = RestaurantMenu.FromJson(jsonString);

                    
                    foreach (RestaurantMenu item in restaurantMenu)
                    {
                        listBox_RestaurantMenu.Items.Add(item);
                    }
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private async void reloadMenu()
        {
            listBox_RestaurantMenu.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void listBox_RestaurantMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantMenu restaurantMenu = (RestaurantMenu)listBox_RestaurantMenu.SelectedItem;
            OrderID.Text = restaurantMenu.Id.ToString();
            comboBox_Category.Text = restaurantMenu.Category.ToString();
            textBox_Name.Text = restaurantMenu.Name.ToString();
            textBox_Description.Text = restaurantMenu.Description.ToString();
            //ingerdientsCombo.Items.Add(restaurantMenu.Ingredients.ToString());
            numericUpDownPrice.Value = restaurantMenu.Price;            
        }
    }
}
