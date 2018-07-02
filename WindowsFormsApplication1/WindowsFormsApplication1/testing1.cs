using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private store theStore = new store();
        private List<item> shoppingCart = new List<item>();
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource venderBinding = new BindingSource();

        private void SetupData()
        {
            theStore.Vendors.Add(new vender { FirstName = "Bill", LastName = "Nie" });
            theStore.Vendors.Add(new vender { FirstName = "Sue", LastName = "Ling" });

            theStore.Items.Add(new item { Title = "dick", Description = "book", Price = 4.0M, Owner = theStore.Vendors[0] });
            theStore.Items.Add(new item { Title = "poppin", Description = "magic", Price = 1.0M, Owner = theStore.Vendors[1] });
            theStore.Items.Add(new item { Title = "goblin", Description = "tales", Price = 3.0M, Owner = theStore.Vendors[0] });
            theStore.Items.Add(new item { Title = "A Single Paper", Description = "tree", Price = 5.5M, Owner = theStore.Vendors[1] });

            theStore.Name = "BooksAreGood";
        }

        public Form1()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource = theStore.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCart;
            cartListBox.DataSource = cartBinding;
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";

            venderBinding.DataSource = theStore.Vendors;
            priceTextBox.DataSource = venderBinding;
            priceTextBox.DisplayMember = "Display";
            priceTextBox.ValueMember = "Display";
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            shoppingCart.Add((item)itemsListBox.SelectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchaseButton_Click(object sender, EventArgs e)
        {
            foreach(item item in shoppingCart)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
            }

            venderBinding.ResetBindings(false);
            shoppingCart.Clear();
            cartBinding.ResetBindings(false);
            itemBinding.DataSource = theStore.Items.Where(x => x.Sold == false).ToList();
            itemBinding.ResetBindings(false);
        }
    }
}

