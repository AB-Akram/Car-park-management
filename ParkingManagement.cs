using GestionParking.Data;
using GestionParking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GestionParking
{
    public partial class ParkingManagement : Form
    {
        public static int NombrePlaceFirstFloor = 10; 
        public static int NombrePlaceGroundFloor = 10; 
        public static int NombrePlaceBasement = 10;

        public static int rowFirstFloor;
        public static int rowGroundFloor;
        public static int rowBasement;

        public static int badge_list  ;
        public ParkingManagement()
        {
            InitializeComponent();
            DisplayVehicles();
            DisplayFirstFloor();
            DisplayGroundFloor();
            DisplayBasement();

        rowFirstFloor = listViewFirstFloor.Items.Count;
        rowGroundFloor = listViewGroundFloor.Items.Count;
        rowBasement = listViewBasement.Items.Count;

        lblFirstFloor.Text = "Places[" + (NombrePlaceFirstFloor - rowFirstFloor) + "/10]";
        lblGroundFloor.Text = "Places[" + (NombrePlaceGroundFloor - rowGroundFloor) + "/10]";
        lblBasement.Text = "Places[" + (NombrePlaceBasement - rowBasement) + "/10]";
        }

        //retour à la page d'accueil
        private void LogoParking_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.ShowDialog();

        }


        private void listViewBasement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayVehicles()
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            var vehicles = contextF.vehicles
                .Include(v => v.Badge);

            List<Vehicle> list = vehicles.ToList();

            //vider la liste
            foreach (ListViewItem item in listViewVehicles.Items)
            {
                listViewVehicles.Items.Remove(item);
            }
            //affichage
            foreach (Vehicle vehicle in list)
            {
                ListViewItem item = new ListViewItem(vehicle.VehicleNumber);
                item.SubItems.Add(vehicle.Badge.Id.ToString());
                item.SubItems.Add(vehicle.VehicleType);
                listViewVehicles.Items.Add(item);
            }


        }

        //selection la liste des vehicules
        private void listViewVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnET_FirstFloor.Enabled = false;
 
            InputDE_FirstFloor.PlaceholderText = DateTime.Now.ToString();

            btnET_GroundFloor.Enabled = false;

            InputDE_GroundFloor.PlaceholderText = DateTime.Now.ToString();

            btnET_Basement.Enabled = false;

            InputDE_Basement.PlaceholderText = DateTime.Now.ToString();

            string ItemType = "";
            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                ItemType = listView.SubItems[2].Text;

            }

            if(ItemType == "Car")
            {
                btnET_GroundFloor.Enabled = true;
                InputDE_GroundFloor.PlaceholderText = DateTime.Now.ToString();

            }else if (ItemType == "MotorCycle")
            {
                btnET_FirstFloor.Enabled = true;
                InputDE_FirstFloor.PlaceholderText = DateTime.Now.ToString();

            }
            else if (ItemType == "Truck")
            {
                btnET_Basement.Enabled = true;
                InputDE_Basement.PlaceholderText = DateTime.Now.ToString();

            }


            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                badge_list = Convert.ToInt32(listView.SubItems[1].Text);
               
                    
            }




        }

        private void Panel_Click(object sender, EventArgs e)
        {
            InputDE_FirstFloor.PlaceholderText = DateTime.Now.ToString();
            btnET_FirstFloor.Enabled = false;
            btnEX_FirstFloor.Enabled = false;
 

            InputDE_GroundFloor.PlaceholderText = DateTime.Now.ToString();
            btnET_GroundFloor.Enabled = false;
            btnEX_GroundFloor.Enabled = false;


            InputDE_Basement.PlaceholderText = DateTime.Now.ToString();
            btnET_Basement.Enabled = false;
            btnEX_Basement.Enabled = false;

           

            listViewVehicles.SelectedItems.Clear();
        }

        //bouton d'entrer pour le premier etage
        private void btnET_FirstFloor_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();
            
            if(rowFirstFloor == 10)
            {
                MessageBox.Show("Space is not available", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            string ItemList = "";
            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                ItemList= listView.SubItems[0].Text;

            }
           
        var vehicle = contextF.vehicles
                .Where (v => v.VehicleNumber == ItemList)
                .FirstOrDefault();
        var firstFloor = contextF.firstFloors
                .Where(ff => ff.Type == "FirstFloor")
                .FirstOrDefault();
            
            ParkingTime parkingTime = new ParkingTime()
            {
                VehicleId = vehicle.Id,
                FloorId = firstFloor.Id,
                DateEntry = DateTime.Now,
                Price = 0
            };
            contextF.parkingTimes.Add(parkingTime);
            contextF.SaveChanges();

            MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayFirstFloor();
            rowFirstFloor = listViewFirstFloor.Items.Count;
            lblFirstFloor.Text = "Places[" + (NombrePlaceFirstFloor - rowFirstFloor) + "/10]";


            InputDE_FirstFloor.PlaceholderText = DateTime.Now.ToString();
            btnET_FirstFloor.Enabled = false;


            listViewVehicles.SelectedItems.Clear();


        }

        //bouton sortie premier étage
        private void btnEX_FirstFloor_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            string dateEntry = "";
            string ItemList = "";
            
            if (listViewFirstFloor.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewFirstFloor.SelectedItems[0];
                ItemList = listView.SubItems[0].Text;
                dateEntry = listView.SubItems[1].Text;

            }

            DateTime d1 = Convert.ToDateTime(dateEntry);
            TimeSpan d2 = DateTime.Now - d1;

            var vehicle = contextF.vehicles
                    .Where(v => v.VehicleNumber == ItemList)
                    .FirstOrDefault();
            var firstFloor = contextF.firstFloors
                    .Where(ff => ff.Type == "FirstFloor")
                    .FirstOrDefault();

            var parkingTime = contextF.parkingTimes
                .Where(pt => pt.VehicleId == vehicle.Id)
                .FirstOrDefault();

            parkingTime.ReleaseDate = DateTime.Now;

            if(Convert.ToInt32(d2.Hours) <= 4)
            {
               

                var badgeCustomer = contextF.badges
                    .Where(b => b.Id == badge_list)
                    .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 5.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else if (Convert.ToInt32(d2.Hours) <= 6 && Convert.ToInt32(d2.Hours) >= 4 )
            {
                
                var badgeCustomer = contextF.badges
                    .Include(b => b.Customer)
                    .Where(b => b.Id == badge_list)
                    .FirstOrDefault();
                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 10.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else
            {
                
                var badgeCustomer = contextF.badges
                        .Include(b => b.Customer)
                        .Where(b => b.Id == badge_list)
                        .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 15.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }
            }

            MessageBox.Show("Well-established exiting", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InputDE_FirstFloor.PlaceholderText = DateTime.Now.ToString();
            btnEX_FirstFloor.Enabled = false;
            InputPrice_FirstFloor.Text = parkingTime.Price.ToString();
            InputRD_FirstFloor.Text = parkingTime.ReleaseDate.ToString();

            listViewFirstFloor.SelectedItems.Clear();
            contextF.Remove(parkingTime);
            contextF.SaveChanges();
            DisplayFirstFloor();
            rowFirstFloor = listViewFirstFloor.Items.Count;
            lblFirstFloor.Text = "Places[" + (NombrePlaceFirstFloor - rowFirstFloor) + "/10]";

        }

        //bouton ajouter de rez de chausse
        private void btnET_GroundFloor_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (rowGroundFloor == 10)
            {
                MessageBox.Show("Space is not available", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ItemList = "";
            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                ItemList = listView.SubItems[0].Text;

            }

            var vehicle = contextF.vehicles
                    .Where(v => v.VehicleNumber == ItemList)
                    .FirstOrDefault();
            var groundFloor = contextF.groundFloors
                    .Where(gg => gg.Type == "GroundFloor")
                    .FirstOrDefault();

            ParkingTime parkingTime = new ParkingTime()
            {
                VehicleId = vehicle.Id,
                FloorId = groundFloor.Id,
                DateEntry = DateTime.Now,
                Price = 0
            };
            contextF.parkingTimes.Add(parkingTime);
            contextF.SaveChanges();

            MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayGroundFloor();
            rowGroundFloor = listViewGroundFloor.Items.Count;
            lblGroundFloor.Text = "Places[" + (NombrePlaceGroundFloor - rowGroundFloor) + "/10]";

            InputDE_GroundFloor.PlaceholderText = DateTime.Now.ToString();
            btnET_GroundFloor.Enabled = false;


            listViewVehicles.SelectedItems.Clear();


        }
        //bouton pour supprimer ground floor
        private void btnEX_GroundFloor_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            string dateEntry = "";
            string ItemList = "";

            if (listViewGroundFloor.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewGroundFloor.SelectedItems[0];
                ItemList = listView.SubItems[0].Text;
                dateEntry = listView.SubItems[1].Text;

            }

            DateTime d1 = Convert.ToDateTime(dateEntry);
            TimeSpan d2 = DateTime.Now - d1;

            var vehicle = contextF.vehicles
                    .Where(v => v.VehicleNumber == ItemList)
                    .FirstOrDefault();
            var groundFloor = contextF.groundFloors
                    .Where(gg => gg.Type == "GroundFloor")
                    .FirstOrDefault();

            var parkingTime = contextF.parkingTimes
                .Where(pt => pt.VehicleId == vehicle.Id)
                .FirstOrDefault();

            parkingTime.ReleaseDate = DateTime.Now;

            if (Convert.ToInt32(d2.Hours) <= 4)
            {
                
                var badgeCustomer = contextF.badges
                   .Where(b => b.Id == badge_list)
                   .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 5.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else if (Convert.ToInt32(d2.Hours) <= 6 && Convert.ToInt32(d2.Hours) >= 4)
            {
                var badgeCustomer = contextF.badges
                    .Where(b => b.Id == badge_list)
                    .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 10.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else
            {
                var badgeCustomer = contextF.badges
                    .Where(b => b.Id == badge_list)
                    .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 15.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }
            }

            MessageBox.Show("Well-established exiting", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InputDE_GroundFloor.PlaceholderText = DateTime.Now.ToString();
      
            InputPrice_GroundFloor.Text = parkingTime.Price.ToString();
            InputRD_GroundFloor.Text = parkingTime.ReleaseDate.ToString();

            listViewGroundFloor.SelectedItems.Clear();
            contextF.Remove(parkingTime);
            contextF.SaveChanges();
            DisplayGroundFloor();
            rowGroundFloor = listViewGroundFloor.Items.Count;
            lblGroundFloor.Text = "Places[" + (NombrePlaceGroundFloor - rowGroundFloor) + "/10]";
            btnEX_GroundFloor.Enabled = false;

        }
        //bouton d'entre pour le sous - sol
        private void btnET_Basement_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            if (rowBasement == 10)
            {
                MessageBox.Show("Space is not available", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ItemList = "";
            if (listViewVehicles.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewVehicles.SelectedItems[0];
                ItemList = listView.SubItems[0].Text;

            }

            var vehicle = contextF.vehicles
                    .Where(v => v.VehicleNumber == ItemList)
                    .FirstOrDefault();
            var basement = contextF.basements
                    .Where(b => b.Type == "Basement")
                    .FirstOrDefault();

            ParkingTime parkingTime = new ParkingTime()
            {
                VehicleId = vehicle.Id,
                FloorId = basement.Id,
                DateEntry = DateTime.Now,
                Price = 0
            };
            contextF.parkingTimes.Add(parkingTime);
            contextF.SaveChanges();

            MessageBox.Show("Well-established addition", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayBasement();
            rowBasement = listViewBasement.Items.Count;
            lblBasement.Text = "Places[" + (NombrePlaceBasement- rowBasement) + "/10]";

            InputDE_Basement.PlaceholderText = DateTime.Now.ToString();
            btnET_Basement.Enabled = false;


            listViewVehicles.SelectedItems.Clear();

        }
        //bouton de supprimer pour le sous -sol
        private void btnEX_Basement_Click(object sender, EventArgs e)
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            string dateEntry = "";
            string ItemList = "";

            if (listViewBasement.SelectedItems.Count > 0)
            {
                ListViewItem listView = listViewBasement.SelectedItems[0];
                ItemList = listView.SubItems[0].Text;
                dateEntry = listView.SubItems[1].Text;

            }

            DateTime d1 = Convert.ToDateTime(dateEntry);
            TimeSpan d2 = DateTime.Now - d1;

            var vehicle = contextF.vehicles
                    .Where(v => v.VehicleNumber == ItemList)
                    .FirstOrDefault();
            var basement = contextF.basements
                    .Where(b => b.Type == "Basement")
                    .FirstOrDefault();

            var parkingTime = contextF.parkingTimes
                .Where(pt => pt.VehicleId == vehicle.Id)
                .FirstOrDefault();

            parkingTime.ReleaseDate = DateTime.Now;

            if (Convert.ToInt32(d2.Hours) <= 4)
            {
                var badgeCustomer = contextF.badges
                   .Where(b => b.Id == badge_list)
                   .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 5.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else if (Convert.ToInt32(d2.Hours) <= 6 && Convert.ToInt32(d2.Hours) >= 4)
            {
                var badgeCustomer = contextF.badges
                   .Where(b => b.Id == badge_list)
                   .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 10.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }

            }
            else
            {
                var badgeCustomer = contextF.badges
                   .Where(b => b.Id == badge_list)
                   .FirstOrDefault();

                if (badgeCustomer.Point < 100)
                {
                    parkingTime.Price = 15.00;
                    badgeCustomer.Point = badgeCustomer.Point + 1;
                }
                else
                {
                    parkingTime.Price = 0.00;
                    badgeCustomer.Point = 0;
                    InputPrice_FirstFloor.PlaceholderText = "0";

                }
            }

            MessageBox.Show("Well-established exiting", "HIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InputDE_Basement.PlaceholderText = DateTime.Now.ToString();

            InputPrice_Basement.Text = parkingTime.Price.ToString();
            InputRD_Basement.Text = parkingTime.ReleaseDate.ToString();

            listViewBasement.SelectedItems.Clear();
            contextF.Remove(parkingTime);
            contextF.SaveChanges();

            DisplayBasement();
            rowBasement = listViewBasement.Items.Count;
            lblBasement.Text = "Places[" + (NombrePlaceBasement - rowBasement) + "/10]";
            btnEX_Basement.Enabled = false;

        }

        // affichage premier étage
        private void DisplayFirstFloor()
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            var parkingtime = contextF.parkingTimes
                .Include(pt => pt.Vehicle)
                .Include(pt => pt.Floor)
                .Where(pt => pt.Floor.Type == "FirstFloor");

            List<ParkingTime> list = parkingtime.ToList();

            //vider la liste
            foreach (ListViewItem item in listViewFirstFloor.Items)
            {
                listViewFirstFloor.Items.Remove(item);
            }
            DateTime dateDefault = Convert.ToDateTime("0001-01-01 00:00:00.000000");
            //affichage
            foreach (ParkingTime pt in list)
            {
                if (pt.ReleaseDate.CompareTo(dateDefault) == 0)
                {
                    ListViewItem item = new ListViewItem(pt.Vehicle.VehicleNumber);
                    item.SubItems.Add(pt.DateEntry.ToString());
                    item.SubItems.Add(pt.ReleaseDate.ToString());
                    item.SubItems.Add(pt.Price.ToString());

                    listViewFirstFloor.Items.Add(item);

                }
              

            }

        }

        // affichage rez - de chausse
        private void DisplayGroundFloor()
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            var parkingtime = contextF.parkingTimes
                .Include(pt => pt.Vehicle)
                .Include(pt => pt.Floor)
                .Where(pt => pt.Floor.Type == "GroundFloor");

            List<ParkingTime> list = parkingtime.ToList();
            //vider la liste
            foreach (ListViewItem item in listViewGroundFloor.Items)
            {
                listViewGroundFloor.Items.Remove(item);
            }
            //affichage

            foreach (ParkingTime pt in list)
            {
                ListViewItem item = new ListViewItem(pt.Vehicle.VehicleNumber);
                item.SubItems.Add(pt.DateEntry.ToString());
                item.SubItems.Add(pt.ReleaseDate.ToString());
                item.SubItems.Add(pt.Price.ToString());

                listViewGroundFloor.Items.Add(item);

            }

        }
        // affichage sous sol
        private void DisplayBasement()
        {
            using ParkingDbContext contextF = new ParkingDbContext();

            var parkingtime = contextF.parkingTimes
                .Include(pt => pt.Vehicle)
                .Include(pt => pt.Floor)
                .Where(pt => pt.Floor.Type == "Basement");

            List<ParkingTime> list = parkingtime.ToList();
            //vider la liste
            foreach (ListViewItem item in listViewBasement.Items)
            {
                listViewBasement.Items.Remove(item);
            }
            //affichage

            foreach (ParkingTime pt in list)
            {
                ListViewItem item = new ListViewItem(pt.Vehicle.VehicleNumber);
                item.SubItems.Add(pt.DateEntry.ToString());
                item.SubItems.Add(pt.ReleaseDate.ToString());
                item.SubItems.Add(pt.Price.ToString());

                listViewBasement.Items.Add(item);

            }

        }

        // la selection de la list first floor
        private void listViewFirstFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEX_FirstFloor.Enabled = true;
            InputRD_FirstFloor.PlaceholderText = "ReleaseDate";
            InputPrice_FirstFloor.PlaceholderText = "Price";

        }

        // la selection de la list ground floor

        private void listViewGroundFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEX_GroundFloor.Enabled = true;
            InputRD_GroundFloor.PlaceholderText = "ReleaseDate";
            InputPrice_GroundFloor.PlaceholderText = "Price";

        }

        // la selection de la liste sous sol
        private void listViewBasement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnEX_Basement.Enabled = true;
            InputRD_Basement.PlaceholderText = "ReleaseDate";
            InputPrice_Basement.PlaceholderText = "Price";

        }

        private void ParkingManagement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.parking_background;

        }
    }
}
