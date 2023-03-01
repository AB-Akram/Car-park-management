using GestionParking.Data;
using GestionParking.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionParking
{
   
    public partial class VehiclesManagement : Form
    {
        public static Vehicle vehicleNumber = new Vehicle();
        public VehiclesManagement()
        {
            InitializeComponent();
            Display();
        }

        private void LogoVehicles_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();
        }

        //bouton ajouter
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputNumber.Text == "" | InputBrand.Text == "" | InputModel.Text == "" | InputType.Text == "" | InputBadgeId.Text == "" | InputVehicleType.Text == "")
            {
                MessageBox.Show("Please fill in all the Inputs ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var countNumber = contextF.vehicles.Count(v => v.VehicleNumber == InputNumber.Text);
            if(countNumber == 1)
            {
                MessageBox.Show("The VehicleNumber is already in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InputVehicleType.Text != "Car" && InputVehicleType.Text != "MotorCycle" && InputVehicleType.Text != "Truck")
            {
                MessageBox.Show("Invalid Vehicle Type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verification si le ID de badge exist - il
            var countBadgeId = contextF.badges.Count(b => b.Id == Convert.ToInt32(InputBadgeId.Text));

            if (countBadgeId == 1)
            {

                var badgeId = contextF.badges
                    .Where(b => b.Id == Convert.ToInt32(InputBadgeId.Text))
                    .FirstOrDefault();
                Vehicle vehicle = new Vehicle()
                {
                    VehicleNumber = InputNumber.Text,
                    Brand = InputBrand.Text,
                    Model = InputModel.Text,
                    Type = InputType.Text,
                    Badge = badgeId,
                    VehicleType = InputVehicleType.Text
                };
                contextF.vehicles.Add(vehicle);
                contextF.SaveChanges();
                MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InputNumber.Text = "";
                InputBrand.Text = "";
                InputModel.Text = "";
                InputType.Text = "";
                InputBadgeId.Text = "";
                InputVehicleType.Text = "";

                Display();
            
            }else
            {
                MessageBox.Show("Invalid Badge ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        //affichage
        private void Display()
        {
            using ParkingDbContext contexF = new ParkingDbContext();
            List<Vehicle> list = contexF.vehicles
                .Include(v => v.Badge)
                .ToList();

            //vider la liste
            foreach (ListViewItem item in listViewVehicles.Items)
            {
                listViewVehicles.Items.Remove(item);
            }
            //affichage
            foreach(Vehicle vehicle in list)
            {
                ListViewItem item = new ListViewItem(vehicle.VehicleNumber);
                item.SubItems.Add(vehicle.Brand);
                item.SubItems.Add(vehicle.Model);
                item.SubItems.Add(vehicle.Type);
                item.SubItems.Add(vehicle.Badge.Id.ToString());
                item.SubItems.Add(vehicle.VehicleType);
                listViewVehicles.Items.Add(item);
            }
        }

        //bouton de recherche
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF= new ParkingDbContext();

            if (InputSearch.Text == "")
            {
                MessageBox.Show("The inputs is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (InputSearch.Text == "ALL")
            {

                Display();

                InputSearch.Text = "";
                return;
            }

            var countNumbver = contextF.vehicles.Count(v => v.VehicleNumber == InputSearch.Text);
            
            if(countNumbver == 1)
            {
                List<Vehicle> list = contextF.vehicles
                    .Include(v => v.Badge)
                    .Where(v => v.VehicleNumber == InputSearch.Text)
                    .ToList();

                //vider la liste
                foreach (ListViewItem item in listViewVehicles.Items)
                {
                    listViewVehicles.Items.Remove(item);
                }
                //affichage

                foreach (Vehicle vehicle in list)
                {
                    ListViewItem item = new ListViewItem(vehicle.VehicleNumber);
                    item.SubItems.Add(vehicle.Brand);
                    item.SubItems.Add(vehicle.Brand);
                    item.SubItems.Add(vehicle.Model);
                    item.SubItems.Add(vehicle.Type);
                    item.SubItems.Add(vehicle.Badge.Id.ToString());
                    item.SubItems.Add(vehicle.VehicleType);
                    
                    listViewVehicles.Items.Add(item);
                }

            }else
            {
                MessageBox.Show("This Vehicle Number is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Panel_Click(object sender, EventArgs e)
        {
            InputNumber.Text = "";
            InputBrand.Text = "";
            InputModel.Text = "";
            InputType.Text = "";
            InputBadgeId.Text = "";
            InputVehicleType.Text = "";
            listViewVehicles.SelectedItems.Clear();
            btnModify.Enabled = false;

        }

        //bouton modifier
        private void btnModify_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (InputNumber.Text == "" | InputBrand.Text == "" | InputModel.Text == "" | InputType.Text == "" | InputBadgeId.Text == "" | InputVehicleType.Text == "")
            {
                MessageBox.Show("Please fill in all the Inputs ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var countNumber = contextF.vehicles.Count(v => v.VehicleNumber == InputNumber.Text);
            if (countNumber == 1 && vehicleNumber.VehicleNumber != InputNumber.Text)
            {
                MessageBox.Show("The VehicleNumber is already in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InputVehicleType.Text != "Car" && InputVehicleType.Text != "MotorCycle" && InputVehicleType.Text != "Truck")
            {
                MessageBox.Show("Invalid Vehicle Type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var vehicle = contextF.vehicles
                .Include(v => v.Badge)
                .Where(v => v.VehicleNumber == vehicleNumber.VehicleNumber)
                .FirstOrDefault();
            
            vehicle.VehicleNumber = InputNumber.Text;
            vehicle.Brand = InputBrand.Text;
            vehicle.Model = InputModel.Text;
            vehicle.Type = InputType.Text;
            vehicle.Badge.Id = Convert.ToInt32(InputBadgeId.Text);
            vehicle.VehicleType = InputVehicleType.Text;
            contextF.SaveChanges();

            MessageBox.Show("Well-established modification", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InputNumber.Text = "";
            InputBrand.Text = "";
            InputModel.Text = "";
            InputType.Text = "";
            InputBadgeId.Text = "";
            InputVehicleType.Text = "";
            
            Display();
        }

        //action pour une selection
        private void listViewVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                InputNumber.Text = listView.SubItems[0].Text;
                InputBrand.Text = listView.SubItems[1].Text;
                InputModel.Text = listView.SubItems[2].Text;
                InputType.Text = listView.SubItems[3].Text;
                InputBadgeId.Text = listView.SubItems[4].Text;
                InputVehicleType.Text = listView.SubItems[5].Text;

            }
            vehicleNumber.VehicleNumber = InputNumber.Text;

        }

        private void VehiclesManagement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.vehicule;

        }
    }
}
