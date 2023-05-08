using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopForms
{
    public partial class Form1 : Form
    {
        Rootobject rootobject;
        Product produkt;

        HttpClient client = new HttpClient();

        string url = "https://api.predic8.de";



        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            rootobject = JsonSerializer.Deserialize<Rootobject>(await client.GetStringAsync(url + @"/shop/products/"));

            for(int i = 0; i< rootobject.products.Length; i++)
            {
                lbxÜbersicht.Items.Add(rootobject.products[i].name);
            }
        }

        private async void lbxÜbersicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product test = FindeProdukt(lbxÜbersicht.SelectedItem.ToString());

            produkt = JsonSerializer.Deserialize<Product>(await client.GetStringAsync(url + test.product_url));

            tbxName.Text = produkt.name;
            tbxPreis.Text = Convert.ToString(produkt.price);

            Kategorie kategorie = JsonSerializer.Deserialize<Kategorie>(await client.GetStringAsync(url + produkt.category_url));

            tbxKategorie.Text = kategorie.name;

            Hersteller hersteller = JsonSerializer.Deserialize<Hersteller>(await client.GetStringAsync(url + produkt.vendor_url));

            tbxHersteller.Text = hersteller.name;

            byte[] bytes = await client.GetByteArrayAsync(url + produkt.photo_url);
            MemoryStream ms = new MemoryStream(bytes);
            try
            {
                pbxBild.Image = Image.FromStream(ms);
            }catch(Exception ex) 
            {
            }

        }

        private Product FindeProdukt(string name)
        {
            foreach (var item in rootobject.products)
            {
                if (string.Equals(name.Trim(), item.name))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
