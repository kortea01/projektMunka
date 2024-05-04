using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;



namespace RestaurantDesktopApp
{
    public partial class RestaurantMenuForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSettings("endpointUrlMenu");        

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

        public RestaurantMenuForm()
        {
            InitializeComponent();
        }

        private void RestaurantMenuForm_Load(object sender, EventArgs e)
        {               
            refreshMenu();
        }

        private async void refreshMenu()
        {
            listBox_RestaurantMenu.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);                          
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
            checkedListBox1.Items.Clear();
            foreach (var item in restaurantMenu.Ingredients)
            {
                //Ingredients.FromJson()
                checkedListBox1.Items.Add(item);
            }
                


        }

        private void ingerdientsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            RestaurantMenu restaurantMenu = new RestaurantMenu();
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Név megadása kötelezõ");
                textBox_Name.Focus();
                return;
            }
            restaurantMenu.Name = textBox_Name.Text;
            restaurantMenu.Description = textBox_Description.Text;
            restaurantMenu.Price = numericUpDownPrice.Value;
            restaurantMenu.Category = comboBox_Category.Text;
            //TODO: ingredients is kötelezõ            
            restaurantMenu.Ingredients = ingerdientsCombo.Items.Cast<string>()
            .Where(item => long.TryParse(item, out _))  // Filter out items that cannot be parsed to long
            .Select(long.Parse)  // Parse the remaining items to long
            .ToArray();

            var json = JsonConvert.SerializeObject(restaurantMenu); //-- továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!");
                refreshMenu();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }
            OrderID.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            textBox_Description.Text = string.Empty;
            comboBox_Category.Text = string.Empty;
            numericUpDownPrice.Value = 0;
            checkedListBox1.Items.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("valóban törölni akarja?") == DialogResult.OK)
            {                
                string endPointDelete = $"{endPoint}/{long.Parse(OrderID.Text)}";                              
                var response = client.DeleteAsync(endPointDelete).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    refreshMenu();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }
                //-- beviteli mezõk törlése ---------------
                OrderID.Text = string.Empty;
                textBox_Name.Text = string.Empty;
                textBox_Description.Text = string.Empty;                
                comboBox_Category.Text = string.Empty;
                numericUpDownPrice.Value = 0;
                checkedListBox1.Items.Clear();


            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            refreshMenu();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(OrderID.Text))
            {
                MessageBox.Show("Nincs kiválasztott étel."); return;
            }
            if(textBox_Name.Text.Length <3) {

                MessageBox.Show("Név megadása kötelezõ!");
                textBox_Name.Focus();
                return;
            
            }

            RestaurantMenu restaurantMenu = new RestaurantMenu();
            
            restaurantMenu.Name = textBox_Name.Text;
            restaurantMenu.Description = textBox_Description.Text;
            restaurantMenu.Price = numericUpDownPrice.Value;            
            restaurantMenu.Category = comboBox_Category.Text;
            //TODO: ingredients is kötelezõ            
            restaurantMenu.Ingredients = ingerdientsCombo.Items.Cast<string>()
            .Where(item => long.TryParse(item, out _))  // Filter out items that cannot be parsed to long
            .Select(long.Parse)  // Parse the remaining items to long
            .ToArray();
            var json = JsonConvert.SerializeObject(restaurantMenu); //-- továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            string endPointUpdate = $"{endPoint}/{long.Parse(OrderID.Text)}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres módosítás!");
                refreshMenu();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");
            }
            OrderID.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            textBox_Description.Text = string.Empty;
            comboBox_Category.Text = string.Empty;
            numericUpDownPrice.Value = 0;
            checkedListBox1.Items.Clear();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
