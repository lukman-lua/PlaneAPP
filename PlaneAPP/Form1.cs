using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth login = new Auth();
            login.ShowDialog();
        }

        private void schedule_planeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schedule_planeBindingSource.EndEdit();

        }

        private void schedule_planeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void schedule_planeBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void schedule_planeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schedule_planeTableAdapter.FillBy(this.plane_appDataSet.schedule_plane);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schedule_planeTableAdapter.FillBy1(this.plane_appDataSet.schedule_plane);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scheduleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schedule_planeTableAdapter.Schedule(this.plane_appDataSet.schedule_plane);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void schedule_planeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plane_appDataSet1.chart' table. You can move, or remove it, as needed.
            this.chartTableAdapter.Fill(this.plane_appDataSet1.chart);

        }

        private void my_ChartToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartTableAdapter.My_Chart(this.plane_appDataSet1.chart);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chartToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartTableAdapter.Chart(this.plane_appDataSet1.chart);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void my_Chart1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartTableAdapter.My_Chart1(this.plane_appDataSet1.chart);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
