using GestionParking.Data;
using GestionParking.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParking
{
    public partial class BadgesManagement : Form
    {
        public BadgesManagement()
        {
            InitializeComponent();
          /*  var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow500, Primary.Yellow500, Primary.BlueGrey500, Accent.Yellow400, TextShade.WHITE);
           */
            Display();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void LogoBadges_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();
        }

        private void BadgesManagement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.badge_customer;
        }

        //boutton pour ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ParkingDbContext contextF = new ParkingDbContext();
            if (InputNIC_Customers.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            var countNic = contextF.customerBadges
              .Include(cb => cb.Customer)
              .Count(cb => cb.Customer.NIC == InputNIC_Customers.Text);
            if(countNic == 1)
            {
                MessageBox.Show("This CIN is already used", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var countCustomer = contextF.customers.Count(c => c.NIC == InputNIC_Customers.Text);
            //traitement de l'ajout
            var CustomerIdN = contextF.customers
                .Where(c => c.NIC == InputNIC_Customers.Text)
                .FirstOrDefault();
            if (countCustomer != 1)
            {
                MessageBox.Show("This CIN is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (countCustomer == 1)
            {
                
                CustomerBadge customerBadge = new CustomerBadge()
                {
                    Customer = CustomerIdN,
                    Point = 0
                };

                contextF.Add(customerBadge);
                contextF.SaveChanges();

                MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();

                InputNIC_Customers.Text = "";
            }
        }

        //affichage
        private void Display()
        {
           ParkingDbContext contextF = new ParkingDbContext();
            var customerBadge = contextF.customerBadges.Include(cb => cb.Customer).ToList();

            List<CustomerBadge> list = customerBadge;

            //vider la liste
            foreach(ListViewItem item  in listViewBadges.Items)
            {
                listViewBadges.Items.Remove(item);
            }

            //remplir la liste

            foreach (CustomerBadge badge in list)
            {
                ListViewItem item = new ListViewItem(badge.Customer.NIC.ToString());
                item.SubItems.Add(badge.Point.ToString());
                listViewBadges.Items.Add(item);
            }
        }

        //bouton de recherche
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParkingDbContext contextF = new ParkingDbContext();
            var countNic = contextF.customerBadges
                .Include(cb => cb.Customer)
                .Count(cb => cb.Customer.NIC == InputSearch.Text);

            if (InputSearch.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (InputSearch.Text == "ALL")
            {
                foreach (ListViewItem item in listViewBadges.Items)
                {
                    listViewBadges.Items.Remove(item);

                }
                Display();

                InputSearch.Text = "";
                return;
            }

            if (countNic == 1)
            {
                var customerBadge = contextF.customerBadges.Include(cb => cb.Customer).ToList();

                List<CustomerBadge> list = customerBadge;

                //vider la liste
                foreach (ListViewItem item in listViewBadges.Items)
                {
                    listViewBadges.Items.Remove(item);
                }

                //remplir la liste

                foreach (CustomerBadge badge in list)
                {
                    if (badge.Customer.NIC == InputSearch.Text) {
                        ListViewItem item = new ListViewItem(badge.Customer.NIC.ToString());
                        item.SubItems.Add(badge.Point.ToString());
                        listViewBadges.Items.Add(item);
                    }
                }

            }else
            {
                MessageBox.Show("This CIN is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bouton pour la racherche d'un ID
        private void btnSearchId_Click(object sender, EventArgs e)
        {
            ParkingDbContext contextF = new ParkingDbContext();
            if (InputSearchId.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (InputSearchId.Text == "ALL")
            {
                foreach (ListViewItem item in listViewBadges.Items)
                {
                    listViewBadges.Items.Remove(item);

                }
                Display();

                InputSearchId.Text = "";
                return;
            }
            Regex regexID = new Regex(@"^[1-9]+");
            if (!regexID.IsMatch(InputSearchId.Text))
            {
                MessageBox.Show("ID contains only Numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            var countId = contextF.customerBadges.Count(cb => cb.Id == Convert.ToInt32(InputSearchId.Text));

            if (countId == 1)
            {
                var customerBadge = contextF.customerBadges.Include(cb => cb.Customer).ToList();

                List<CustomerBadge> list = customerBadge;

                //vider la liste
                foreach (ListViewItem item in listViewBadges.Items)
                {
                    listViewBadges.Items.Remove(item);
                }

                //remplir la liste

                foreach (CustomerBadge badge in list)
                {
                    if (badge.Id == Convert.ToInt32(InputSearchId.Text))
                    {
                        ListViewItem item = new ListViewItem(badge.Customer.NIC.ToString());
                        item.SubItems.Add(badge.Point.ToString());
                        listViewBadges.Items.Add(item);
                    }
                }

            }
            else
            {
                MessageBox.Show("This ID is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
