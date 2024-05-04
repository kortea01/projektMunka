using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantDesktopApp
{
    public partial class IngredientsForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSettings("endpointUrlIngreditents");

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
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {
            refreshIngedients();
        }

        private async void refreshIngedients()
        {
            listBox_ingredients.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var ingredients = Ingredients.FromJson(jsonString);


                    foreach (Ingredients item in ingredients)
                    {
                        listBox_ingredients.Items.Add(item);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void reloadIngredients()
        {
            listBox_ingredients.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void listBox_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingredients ingredients = (Ingredients)listBox_ingredients.SelectedItem;
            textBox_id.Text = ingredients.Id.ToString();
            textBox_Name.Text = ingredients.Name.ToString();
            if (string.IsNullOrEmpty(ingredients.Allergen))
            {
                textBox_Allergen.Text = "";
            } else
            {
                textBox_Allergen.Text = ingredients.Allergen.ToString();
            }
            
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            refreshIngedients();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients();
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Név megadása kötelező");
                textBox_Name.Focus();
                return;
            }
            ingredients.Name = textBox_Name.Text;
            ingredients.Allergen = textBox_Allergen.Text;


            var json = JsonConvert.SerializeObject(ingredients); //-- továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!");
                refreshIngedients();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }
            textBox_id.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            textBox_Allergen.Text = string.Empty;

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("valóban törölni akarja?") == DialogResult.OK)
            {            
                string endPointDelete = $"{endPoint}/{long.Parse(textBox_id.Text)}";
                var response = client.DeleteAsync(endPointDelete).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    refreshIngedients();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }
                //-- beviteli mezők törlése ---------------
                textBox_id.Text = string.Empty;
                textBox_Name.Text = string.Empty;
                textBox_Allergen.Text = string.Empty;
            }

        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text))
            {
                MessageBox.Show("Nincs kiválasztott hozzávaló"); return;
            }
            if (textBox_Name.Text.Length < 2)
            {

                MessageBox.Show("Hozzávaló megadása kötelező!");
                textBox_Name.Focus();
                return;

            }

            Ingredients ingredients = new Ingredients();

            ingredients.Name = textBox_Name.Text;
            ingredients.Allergen = textBox_Allergen.Text;


            var json = JsonConvert.SerializeObject(ingredients); //-- továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //-- fejlécet adtunk hozzá
            string endPointUpdate = $"{endPoint}/{long.Parse(textBox_id.Text)}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!" );
                refreshIngedients();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }
            textBox_id.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            textBox_Allergen.Text = string.Empty;
        }
    }
}

