using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Products;


namespace Shop
{

    public partial class Shop : Form
    {

        public Shop()
        {
            InitializeComponent();
            menu.View = View.Details;
            menu.Columns.Add("Name", -2, HorizontalAlignment.Left);
            menu.Columns.Add("Price", -2, HorizontalAlignment.Left);
            menu.Columns.Add("Manufacturer", -2, HorizontalAlignment.Left);
            menu.Columns.Add("Ingredient", -2, HorizontalAlignment.Left);
            Burger krabsburger = new Burger("Крабс Бургер", 25000, "Шефмаркет", "Крабовое мясо");
            Burger caesarburger = new Burger("Цезарь Бургер", 23000, "Шефмаркет", "Куриная грудка");
            Burger wasabiburger = new Burger("Васаби-Бургер", 28000, "Шефмаркет", "Говяжье мясо");
            Burger troutburger = new Burger("Бургер с форелью", 21000, "Шефмаркет", "Форель");
            var burger1 = new ListViewItem(new[] { krabsburger.Name, Convert.ToString(krabsburger.Price), krabsburger.Manufacturer, krabsburger.Ingredient });
            var burger2 = new ListViewItem(new[] { caesarburger.Name, Convert.ToString(caesarburger.Price), caesarburger.Manufacturer, caesarburger.Ingredient });
            var burger3 = new ListViewItem(new[] { wasabiburger.Name, Convert.ToString(wasabiburger.Price), wasabiburger.Manufacturer, wasabiburger.Ingredient });
            var burger4 = new ListViewItem(new[] { troutburger.Name, Convert.ToString(troutburger.Price), troutburger.Manufacturer, troutburger.Ingredient });

            Hot_Dog chicagohotdog = new Hot_Dog("Чикагский хотдог", 15000, "Delimano");
            Hot_Dog japanhotdog = new Hot_Dog("Японский хотдог", 20000, "Delimano");
            Hot_Dog corndog = new Hot_Dog("Корн-дог", 18000, "Delimano");
            Hot_Dog arizona = new Hot_Dog("Аризонский хотдог", 17000, "Delimano");
            var hotdog1 = new ListViewItem(new[] { chicagohotdog.Name, Convert.ToString(chicagohotdog.Price), chicagohotdog.Manufacturer });
            var hotdog2 = new ListViewItem(new[] { japanhotdog.Name, Convert.ToString(japanhotdog.Price), japanhotdog.Manufacturer });
            var hotdog3 = new ListViewItem(new[] { corndog.Name, Convert.ToString(corndog.Price), corndog.Manufacturer });
            var hotdog4 = new ListViewItem(new[] { arizona.Name, Convert.ToString(arizona.Price), arizona.Manufacturer });

            Tea mattya = new Tea("Маття", 4000, "Kofecha.ru", "Ферментированный");
            Tea puer = new Tea("Пуэр", 5000, "Kofecha.ru", "Постферментированный");
            Tea ulun = new Tea("Улун", 3000, "Kofecha.ru", "Полуферментированный");
            var tea1 = new ListViewItem(new[] { mattya.Name, Convert.ToString(mattya.Price), mattya.Manufacturer, mattya.Type });
            var tea2 = new ListViewItem(new[] { puer.Name, Convert.ToString(puer.Price), puer.Manufacturer, puer.Type });
            var tea3 = new ListViewItem(new[] { ulun.Name, Convert.ToString(ulun.Price), ulun.Manufacturer, ulun.Type });

            menu.Items.Add(burger1);
            menu.Items.Add(burger2);
            menu.Items.Add(burger3);
            menu.Items.Add(burger4);
            menu.Items.Add(hotdog1);
            menu.Items.Add(hotdog2);
            menu.Items.Add(hotdog3);
            menu.Items.Add(hotdog4);
            menu.Items.Add(tea1);
            menu.Items.Add(tea2);
            menu.Items.Add(tea3);


            orderbox.Items.Add(krabsburger.Name);
            orderbox.Items.Add(caesarburger.Name);
            orderbox.Items.Add(wasabiburger.Name);
            orderbox.Items.Add(troutburger.Name);
            orderbox.Items.Add(chicagohotdog.Name);
            orderbox.Items.Add(japanhotdog.Name);
            orderbox.Items.Add(corndog.Name);
            orderbox.Items.Add(arizona.Name);
            orderbox.Items.Add(mattya.Name);
            orderbox.Items.Add(puer.Name);
            orderbox.Items.Add(ulun.Name);
        }



        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveinfo_Click(object sender, EventArgs e)
        {

        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap[] image = new Bitmap[11];
            image[0] = new Bitmap(ShopWinForms.Properties.Resources.krabsburger);
            image[1] = new Bitmap(ShopWinForms.Properties.Resources.arizona);
            image[2] = new Bitmap(ShopWinForms.Properties.Resources.caesarburger);
            image[3] = new Bitmap(ShopWinForms.Properties.Resources.wasabiburger);
            image[4] = new Bitmap(ShopWinForms.Properties.Resources.troutburger);
            image[5] = new Bitmap(ShopWinForms.Properties.Resources.chicagohotdog);
            image[6] = new Bitmap(ShopWinForms.Properties.Resources.japanhotdoh);
            image[7] = new Bitmap(ShopWinForms.Properties.Resources.mattya);
            image[8] = new Bitmap(ShopWinForms.Properties.Resources.puer);
            image[9] = new Bitmap(ShopWinForms.Properties.Resources.ulun);
            image[10] = new Bitmap(ShopWinForms.Properties.Resources.corndog);

            switch (menu.FocusedItem.Text)
            {
                case "Крабс Бургер": pictureBox.Image = image[0]; break;
                case "Аризонский хотдог": pictureBox.Image = image[1]; break;
                case "Цезарь Бургер": pictureBox.Image = image[2]; break;
                case "Васаби-Бургер": pictureBox.Image = image[3]; break;
                case "Бургер с форелью": pictureBox.Image = image[4]; break;
                case "Чикагский хотдог": pictureBox.Image = image[5]; break;
                case "Японский хотдог": pictureBox.Image = image[6]; break;
                case "Маття": pictureBox.Image = image[7]; break;
                case "Пуэр": pictureBox.Image = image[8]; break;
                case "Улун": pictureBox.Image = image[9]; break;
                case "Корн-дог": pictureBox.Image = image[10]; break;
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add(Convert.ToString(orderbox.SelectedItem));
        }

        private void orderbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap[] image = new Bitmap[11];
            image[0] = new Bitmap(ShopWinForms.Properties.Resources.krabsburger);
            image[1] = new Bitmap(ShopWinForms.Properties.Resources.arizona);
            image[2] = new Bitmap(ShopWinForms.Properties.Resources.caesarburger);
            image[3] = new Bitmap(ShopWinForms.Properties.Resources.wasabiburger);
            image[4] = new Bitmap(ShopWinForms.Properties.Resources.troutburger);
            image[5] = new Bitmap(ShopWinForms.Properties.Resources.chicagohotdog);
            image[6] = new Bitmap(ShopWinForms.Properties.Resources.japanhotdoh);
            image[7] = new Bitmap(ShopWinForms.Properties.Resources.mattya);
            image[8] = new Bitmap(ShopWinForms.Properties.Resources.puer);
            image[9] = new Bitmap(ShopWinForms.Properties.Resources.ulun);
            image[10] = new Bitmap(ShopWinForms.Properties.Resources.corndog);

            switch (orderbox.Text)
            {
                case "Крабс Бургер": pictureBox.Image = image[0]; break;
                case "Аризонский хотдог": pictureBox.Image = image[1]; break;
                case "Цезарь Бургер": pictureBox.Image = image[2]; break;
                case "Васаби-Бургер": pictureBox.Image = image[3]; break;
                case "Бургер с форелью": pictureBox.Image = image[4]; break;
                case "Чикагский хотдог": pictureBox.Image = image[5]; break;
                case "Японский хотдог": pictureBox.Image = image[6]; break;
                case "Маття": pictureBox.Image = image[7]; break;
                case "Пуэр": pictureBox.Image = image[8]; break;
                case "Улун": pictureBox.Image = image[9]; break;
                case "Корн-дог": pictureBox.Image = image[10]; break;
            }

        }


        private void orderbox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void orderlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {



        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(orderlist.SelectedItem) == "Пакетик")
            {
                bag.Checked = false;
            }
            else
            {
                orderlist.Items.Remove(orderlist.SelectedItem); 
            }

        }

        private void balance_Click(object sender, EventArgs e)
        {
            //Бургеры
            Burger krabsburger = new Burger("Крабс Бургер", 25000, "Шефмаркет", "Крабовое мясо");
            Burger caesarburger = new Burger("Цезарь Бургер", 23000, "Шефмаркет", "Куриная грудка");
            Burger wasabiburger = new Burger("Васаби-Бургер", 28000, "Шефмаркет", "Говяжье мясо");
            Burger troutburger = new Burger("Бургер с форелью", 21000, "Шефмаркет", "Форель");
            //Хот доги
            Hot_Dog chicagohotdog = new Hot_Dog("Чикагский хотдог", 15000, "Delimano");
            Hot_Dog japanhotdog = new Hot_Dog("Японский хотдог", 20000, "Delimano");
            Hot_Dog corndog = new Hot_Dog("Корн-дог", 18000, "Delimano");
            Hot_Dog arizona = new Hot_Dog("Аризонский хотдог", 17000, "Delimano");
            //Чаи
            Tea mattya = new Tea("Маття", 4000, "Kofecha.ru", "Ферментированный");
            Tea puer = new Tea("Пуэр", 5000, "Kofecha.ru", "Постферментированный");
            Tea ulun = new Tea("Улун", 3000, "Kofecha.ru", "Полуферментированный");
            //Остальное MAGIC!!!
            int n = orderlist.Items.Count;
            double summ = 0;
            string[] items = new string[n];

            for (int i = 0; i < n; i++)
            {
                items[i] = orderlist.Items[i].ToString();
            }
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == krabsburger.Name)
                {
                    summ += krabsburger.Price;
                }
                else if (items[i] == caesarburger.Name)
                {
                    summ += caesarburger.Price;
                }
                else if (items[i] == wasabiburger.Name)
                {
                    summ += wasabiburger.Price;
                }
                else if (items[i] == troutburger.Name)
                {
                    summ += troutburger.Price;
                }
                else if (items[i] == chicagohotdog.Name)
                {
                    summ += chicagohotdog.Price;
                }
                else if (items[i] == japanhotdog.Name)
                {
                    summ += japanhotdog.Price;
                }
                else if (items[i] == corndog.Name)
                {
                    summ += corndog.Price;
                }
                else if (items[i] == arizona.Name)
                {
                    summ += arizona.Price;
                }
                else if (items[i] == mattya.Name)
                {
                    summ += mattya.Price;
                }
                else if (items[i] == puer.Name)
                {
                    summ += puer.Price;
                }
                else if (items[i] == ulun.Name)
                {
                    summ += ulun.Price;
                }
                else if (items[i] == "Пакетик")
                {
                    summ += 300;
                }
                pricesumm.Text = Convert.ToString(summ);
            }

        }

        private void bag_CheckedChanged(object sender, EventArgs e)
        {
            if (bag.Checked)
            {
                orderlist.Items.Add("Пакетик");
            }
            else
            {
                orderlist.Items.Remove("Пакетик");
            }
        }

        private void pricesumm_Click(object sender, EventArgs e)
        {

        }
    }
}