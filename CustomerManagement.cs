using GestionParking.Data;
using GestionParking.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionParking
{
    public partial class CustomerManagement : Form
    {
        public static Customer customer = new Customer();
        public CustomerManagement()
        {
            using ParkingDbContext context = new ParkingDbContext();

            InitializeComponent();
            DisplayList();
           

        }

        //bouton pour ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputLastName.Text == "" | InputFirstName.Text == "" | InputAddress.Text == "" | InputPhoneNumber.Text == "" | InputNIC.Text == "")
            {
                MessageBox.Show("Please fill in all the Inputs ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }

           //int CountNIC = contextF.customers.Select(c => c.NIC == InputNIC.Text).Count();
            var countNIC = contextF.customers.Count(c=> c.NIC == InputNIC.Text);         
            if (countNIC == 1)
            {
                MessageBox.Show("The NIC is already in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Regex regexName = new Regex(@"^[A-Za-z]+$");
            if (regexName.IsMatch(InputLastName.Text) == false )
            {
                MessageBox.Show("Invalid LastName ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!regexName.IsMatch(InputFirstName.Text))
            {
                MessageBox.Show("Invalid FirstName ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Regex regexPhone = new Regex(@"^[0-9]{10}$");

            if (regexPhone.IsMatch(InputPhoneNumber.Text))
            {



                Customer customer = new Customer()
                {
                    LastName = InputLastName.Text,
                    FirstName = InputFirstName.Text,
                    NIC = InputNIC.Text,
                    Address = InputAddress.Text,
                    PhoneNumber = InputPhoneNumber.Text
                };
                contextF.Add(customer);
                contextF.SaveChanges();
                MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //vider la liste
                foreach (ListViewItem item in listViewCustomers.Items)
                {
                    listViewCustomers.Items.Remove(item);
                }

                // vider les cases
                InputLastName.Text = "";
                InputFirstName.Text = "";
                InputAddress.Text = "";
                InputPhoneNumber.Text = "";
                InputNIC.Text = "";

                DisplayList();
            }
            else
            {
                MessageBox.Show("Invalid Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //lors de la selection 
        //ou 
        //lstMaster.SelectedItems.Count > 0 / lstMaster.SelectedItems(0).Selected
       /* private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            ListViewItem listViewItem = listViewCustomers.SelectedItems[0];
            InputLastName.Text = listViewItem.SubItems[0].Text;
            InputFirstName.Text = listViewItem.SubItems[1].Text;
            InputNIC.Text = listViewItem.SubItems[2].Text;
            InputAddress.Text = listViewItem.SubItems[3].Text;
            InputPhoneNumber.Text = listViewItem.SubItems[4].Text;
           
        }*/



        //selection de la liste
        private void listViewCustomers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewCustomers.SelectedItems[0];
                InputLastName.Text = listView.SubItems[0].Text;
                InputFirstName.Text = listView.SubItems[1].Text;
                InputNIC.Text = listView.SubItems[2].Text;
                InputAddress.Text = listView.SubItems[3].Text;
                InputPhoneNumber.Text = listView.SubItems[4].Text;

            }
            customer.NIC = InputNIC.Text;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            InputLastName.Text = "";
              InputFirstName.Text = "";
              InputAddress.Text = "";
              InputPhoneNumber.Text = "";
              InputNIC.Text = "";
              listViewCustomers.SelectedItems.Clear();
            btnModify.Enabled = false;
        }

        //affichage de la liste ou bien remplir listview
        private void DisplayList()
        {
            using ParkingDbContext contextF = new ParkingDbContext();
            List<Customer> list = contextF.customers.ToList();
            foreach (Customer cust in list)
            {
                ListViewItem item = new ListViewItem(cust.LastName);
                item.SubItems.Add(cust.FirstName);
                item.SubItems.Add(cust.NIC);
                item.SubItems.Add(cust.Address);
                item.SubItems.Add(cust.PhoneNumber);

                listViewCustomers.Items.Add(item);
            }

        }

        // bouton modifier
        private void btnModify_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();
            if (InputLastName.Text == "" | InputFirstName.Text == "" | InputAddress.Text == "" | InputPhoneNumber.Text == "" | InputNIC.Text == "")
            {
                MessageBox.Show("Please fill in all the Inputs ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Regex regexName = new Regex(@"^[A-Za-z]+$");
            if (regexName.IsMatch(InputLastName.Text) == false)
            {
                MessageBox.Show("Invalid LastName ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!regexName.IsMatch(InputFirstName.Text))
            {
                MessageBox.Show("Invalid FirstName ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Regex regexPhone = new Regex(@"^[0-9]{10}$");
            if (!regexPhone.IsMatch(InputPhoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var customerUpdate = contextF.customers
                .Where(c=> c.NIC == customer.NIC)
                .FirstOrDefault();
            
            customerUpdate.LastName = InputLastName.Text;
            customerUpdate.FirstName = InputFirstName.Text;
            customerUpdate.NIC = InputNIC.Text;
            customerUpdate.Address = InputAddress.Text;
            customerUpdate.PhoneNumber = InputPhoneNumber.Text;
            contextF.SaveChanges();

            MessageBox.Show("Well-established modification", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //vider la liste
            foreach (ListViewItem item in listViewCustomers.Items)
            {
                listViewCustomers.Items.Remove(item);
            }

            // vider les cases
            InputLastName.Text = "";
            InputFirstName.Text = "";
            InputAddress.Text = "";
            InputPhoneNumber.Text = "";
            InputNIC.Text = "";

            btnModify.Enabled = false;
            
            DisplayList();


        }

        //bouton pour la recherche
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputSearch.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }else if (InputSearch.Text == "ALL")
            {
                foreach (ListViewItem item in listViewCustomers.Items)
                {
                    listViewCustomers.Items.Remove(item);

                }
                DisplayList();

                InputSearch.Text = "";
                return;
            }



            var countNIC = contextF.customers.Count(c => c.NIC == InputSearch.Text);

            if(countNIC == 1 )
            {
                //vider la liste
                foreach (ListViewItem item in listViewCustomers.Items)
                {
                    listViewCustomers.Items.Remove(item);
                }

                List<Customer> list = contextF.customers.ToList();
                foreach (Customer cust in list)
                {
                    if (cust.NIC == InputSearch.Text)
                    {
                        ListViewItem item = new ListViewItem(cust.LastName);
                        item.SubItems.Add(cust.FirstName);
                        item.SubItems.Add(cust.NIC);
                        item.SubItems.Add(cust.Address);
                        item.SubItems.Add(cust.PhoneNumber);

                        listViewCustomers.Items.Add(item);
                    }
                }
                InputSearch.Text = "";

            }
            else
            {
                MessageBox.Show("This CIN is not found","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        // switch to another form
        private void LogoIParking_Click(object sender, MouseEventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();
        }

        private void LogoCustomers_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.client_image;
        }
    }
}