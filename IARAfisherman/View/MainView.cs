using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IARAfisherman.Controller;

namespace IARAfisherman.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            {
                dgvShip.Rows[0].Cells["insert ship"].Value = txtbxShipName.Text;
               // dgvShip.Rows[0].Cells["UOmDesc"].Value = txtUomDesc.Text
            }

        }

        private void RefreshTable()
        {
           //ataTable table = new.DataTable();
           //able.Rows.Add(1, "ShipTestName", 2012);
           

           dgvShip.DataSource = MainViewController.GetAllShips();
        }

        private void dgvShip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
 /*
  bton insert thing 
Ship ship = new Ship();
ship.Name = txtbxShipName.Text;
            ship.PermitEnds = dtpPermitEnds.Value;
            //MainViewController.InsertShip(ship);
            RefreshTable();
 */
    }
}
