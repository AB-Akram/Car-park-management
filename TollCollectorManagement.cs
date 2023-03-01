using GestionParking.Data;
using GestionParking.Models;
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
    public partial class TollCollectorManagement : Form
    {
        public static TollCollector tollCollectorNIC = new TollCollector();
        public TollCollectorManagement()
        {
            InitializeComponent();
            DisplayList();
        }

        //boutton ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputLastName.Text == "" | InputFirstName.Text == "" | InputAddress.Text == "" | InputPhoneNumber.Text == "" | InputNIC.Text == "")
            {
                MessageBox.Show("Please fill in all the Inputs ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //int CountNIC = contextF.customers.Select(c => c.NIC == InputNIC.Text).Count();
            var countNIC = contextF.tollCollectors.Count(tc =>tc.NIC == InputNIC.Text);
            if (countNIC >= 1)
            {
                MessageBox.Show("The NIC is already in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (regexPhone.IsMatch(InputPhoneNumber.Text))
            {

                TollCollector tollCollector = new TollCollector()
                {
                    LastName = InputLastName.Text,
                    FirstName = InputFirstName.Text,
                    NIC = InputNIC.Text,
                    Address = InputAddress.Text,
                    PhoneNumber = InputPhoneNumber.Text,
                    isActive= false
                };
                contextF.Add(tollCollector);
                contextF.SaveChanges();
                MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //vider la liste
                foreach (ListViewItem item in listViewTollCollecTors.Items)
                {
                    listViewTollCollecTors.Items.Remove(item);
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


        //affichage de la liste ou bien remplir listview
        private void DisplayList()
        {
            using ParkingDbContext contextF = new ParkingDbContext();
            List<TollCollector> list = contextF.tollCollectors.ToList();
            foreach (TollCollector tc in list)
            {
                ListViewItem item = new ListViewItem(tc.LastName);
                item.SubItems.Add(tc.FirstName);
                item.SubItems.Add(tc.NIC);
                item.SubItems.Add(tc.Address);
                item.SubItems.Add(tc.PhoneNumber);

                listViewTollCollecTors.Items.Add(item);
            }

        }

        private void LogoTollCollector_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();
        }

        //bouton de modification
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
            var tollCollectorUpdate = contextF.tollCollectors
                .Where(t => t.NIC == tollCollectorNIC.NIC)
                .FirstOrDefault();

            tollCollectorUpdate.LastName = InputLastName.Text;
            tollCollectorUpdate.FirstName = InputFirstName.Text;
            tollCollectorUpdate.NIC = InputNIC.Text;
            tollCollectorUpdate.Address = InputAddress.Text;
            tollCollectorUpdate.PhoneNumber = InputPhoneNumber.Text;
            contextF.SaveChanges();

            MessageBox.Show("Well-established modification", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //vider la liste
            foreach (ListViewItem item in listViewTollCollecTors.Items)
            {
                listViewTollCollecTors.Items.Remove(item);
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

        //selection de la liste
        private void listViewTollCollecTors_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            if (listViewTollCollecTors.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewTollCollecTors.SelectedItems[0];
                InputLastName.Text = listView.SubItems[0].Text;
                InputFirstName.Text = listView.SubItems[1].Text;
                InputNIC.Text = listView.SubItems[2].Text;
                InputAddress.Text = listView.SubItems[3].Text;
                InputPhoneNumber.Text = listView.SubItems[4].Text;

            }
            tollCollectorNIC.NIC = InputNIC.Text;

        }

        private void Panel_Click(object sender, EventArgs e)
        {
            InputLastName.Text = "";
            InputFirstName.Text = "";
            InputAddress.Text = "";
            InputPhoneNumber.Text = "";
            InputNIC.Text = "";
            listViewTollCollecTors.SelectedItems.Clear();
            btnModify.Enabled = false;

        }

        //bouton de recherche
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputSearch.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (InputSearch.Text == "ALL")
            {
                foreach (ListViewItem item in listViewTollCollecTors.Items)
                {
                    listViewTollCollecTors.Items.Remove(item);

                }
                DisplayList();

                InputSearch.Text = "";
                return;
            }



            var countNIC = contextF.tollCollectors.Count(t => t.NIC == InputSearch.Text);

            if (countNIC == 1)
            {
                //vider la liste
                foreach (ListViewItem item in listViewTollCollecTors.Items)
                {
                    listViewTollCollecTors.Items.Remove(item);
                }

                List<TollCollector> list = contextF.tollCollectors.ToList();
                foreach (TollCollector tc in list)
                {
                    if (tc.NIC == InputSearch.Text)
                    {
                        ListViewItem item = new ListViewItem(tc.LastName);
                        item.SubItems.Add(tc.FirstName);
                        item.SubItems.Add(tc.NIC);
                        item.SubItems.Add(tc.Address);
                        item.SubItems.Add(tc.PhoneNumber);

                        listViewTollCollecTors.Items.Add(item);
                    }
                }
                InputSearch.Text = "";

            }
            else
            {
                MessageBox.Show("This CIN is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TollCollectorManagement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.employee_background;

        }
    }
}
