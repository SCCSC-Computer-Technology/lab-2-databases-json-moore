// Jason Moore
// CPT206 - Lab 2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasonMoore_CPT206_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit button
            this.Close();
        }


        // Sort by ascendin, descending, and by city name
        private void btnAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationAsc(this.cityDBDataSet.City);
        }
        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationDesc(this.cityDBDataSet.City);
        }

        private void btnCityName_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityNameAsc(this.cityDBDataSet.City);
        }


        // Show highest, lowest, total, and average population
        private void btnHighPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Population: " + this.cityTableAdapter.HighestPopulation());
        }

        private void btnLowPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest Population: " + this.cityTableAdapter.LowestPopulation());
        }

        private void btnTotalPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population: " + this.cityTableAdapter.TotalPopulation());
        }

        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population: " + this.cityTableAdapter.AveragePopulation());
        }
    }
}
