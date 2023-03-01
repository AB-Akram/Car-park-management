using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParking
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            //this.BackgroundImage = Properties.Resources.Background_1;
  
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            this.Hide();
            cm.ShowDialog();
        }

        private void btnTollCollector_Click(object sender, EventArgs e)
        {
            TollCollectorManagement tcm = new TollCollectorManagement();
            this.Hide();
            tcm.ShowDialog();
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            ParkingManagement pm = new ParkingManagement();
            this.Hide();
            pm.ShowDialog();
        }

        private void btnBadges_Click(object sender, EventArgs e)
        {
            BadgesManagement bm = new BadgesManagement();
            this.Hide();
            bm.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            VehiclesManagement vm = new VehiclesManagement();
            this.Hide();
            vm.ShowDialog();
        }
    }
}
