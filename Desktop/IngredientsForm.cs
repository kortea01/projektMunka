using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

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

        private void listBox_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingredients ingredients = (Ingredients)listBox_ingredients.SelectedItem;
            textBox_id.Text = ingredients.Id.ToString();            
            textBox1.Text = ingredients.Name.ToString();            
        }
    }
}
