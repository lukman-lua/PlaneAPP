
namespace PlaneAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Auth = new System.Windows.Forms.Button();
            this.plane_appDataSet = new PlaneAPP.plane_appDataSet();
            this.schedule_planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedule_planeTableAdapter = new PlaneAPP.plane_appDataSetTableAdapters.schedule_planeTableAdapter();
            this.tableAdapterManager = new PlaneAPP.plane_appDataSetTableAdapters.TableAdapterManager();
            this.schedule_planeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleToolStrip = new System.Windows.Forms.ToolStrip();
            this.scheduleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.chartDataGridView = new System.Windows.Forms.DataGridView();
            this.my_Chart1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.my_Chart1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plane_appDataSet1 = new PlaneAPP.plane_appDataSet1();
            this.chartTableAdapter = new PlaneAPP.plane_appDataSet1TableAdapters.chartTableAdapter();
            this.tableAdapterManager1 = new PlaneAPP.plane_appDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.plane_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_planeDataGridView)).BeginInit();
            this.scheduleToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataGridView)).BeginInit();
            this.my_Chart1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane_appDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Auth
            // 
            this.Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Auth.Location = new System.Drawing.Point(44, 38);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(97, 37);
            this.Auth.TabIndex = 0;
            this.Auth.Text = "Login or Register";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // plane_appDataSet
            // 
            this.plane_appDataSet.DataSetName = "plane_appDataSet";
            this.plane_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedule_planeBindingSource
            // 
            this.schedule_planeBindingSource.DataMember = "schedule_plane";
            this.schedule_planeBindingSource.DataSource = this.plane_appDataSet;
            this.schedule_planeBindingSource.CurrentChanged += new System.EventHandler(this.schedule_planeBindingSource_CurrentChanged);
            // 
            // schedule_planeTableAdapter
            // 
            this.schedule_planeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.schedule_planeTableAdapter = this.schedule_planeTableAdapter;
            this.tableAdapterManager.UpdateOrder = PlaneAPP.plane_appDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // schedule_planeDataGridView
            // 
            this.schedule_planeDataGridView.AllowUserToAddRows = false;
            this.schedule_planeDataGridView.AllowUserToDeleteRows = false;
            this.schedule_planeDataGridView.AllowUserToOrderColumns = true;
            this.schedule_planeDataGridView.AutoGenerateColumns = false;
            this.schedule_planeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_planeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.schedule_planeDataGridView.DataSource = this.schedule_planeBindingSource;
            this.schedule_planeDataGridView.Location = new System.Drawing.Point(12, 264);
            this.schedule_planeDataGridView.Name = "schedule_planeDataGridView";
            this.schedule_planeDataGridView.ReadOnly = true;
            this.schedule_planeDataGridView.Size = new System.Drawing.Size(784, 342);
            this.schedule_planeDataGridView.TabIndex = 2;
            this.schedule_planeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_planeDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_schedule";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maskapai";
            this.dataGridViewTextBoxColumn2.HeaderText = "Maskapai";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "flight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Schedule";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "asal";
            this.dataGridViewTextBoxColumn4.HeaderText = "From";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tujuan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "capacity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "people";
            this.dataGridViewTextBoxColumn8.HeaderText = "Booking";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // scheduleToolStrip
            // 
            this.scheduleToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.scheduleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripButton});
            this.scheduleToolStrip.Location = new System.Drawing.Point(254, 224);
            this.scheduleToolStrip.Name = "scheduleToolStrip";
            this.scheduleToolStrip.Size = new System.Drawing.Size(71, 25);
            this.scheduleToolStrip.TabIndex = 3;
            this.scheduleToolStrip.Text = "scheduleToolStrip";
            // 
            // scheduleToolStripButton
            // 
            this.scheduleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scheduleToolStripButton.Name = "scheduleToolStripButton";
            this.scheduleToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.scheduleToolStripButton.Text = "Schedule";
            this.scheduleToolStripButton.Click += new System.EventHandler(this.scheduleToolStripButton_Click);
            // 
            // chartDataGridView
            // 
            this.chartDataGridView.AllowUserToAddRows = false;
            this.chartDataGridView.AllowUserToDeleteRows = false;
            this.chartDataGridView.AllowUserToOrderColumns = true;
            this.chartDataGridView.AutoGenerateColumns = false;
            this.chartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.chartDataGridView.DataSource = this.chartBindingSource;
            this.chartDataGridView.Location = new System.Drawing.Point(680, 38);
            this.chartDataGridView.Name = "chartDataGridView";
            this.chartDataGridView.ReadOnly = true;
            this.chartDataGridView.Size = new System.Drawing.Size(443, 220);
            this.chartDataGridView.TabIndex = 3;
            // 
            // my_Chart1ToolStrip
            // 
            this.my_Chart1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.my_Chart1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.my_Chart1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_Chart1ToolStripButton});
            this.my_Chart1ToolStrip.Location = new System.Drawing.Point(680, 10);
            this.my_Chart1ToolStrip.Name = "my_Chart1ToolStrip";
            this.my_Chart1ToolStrip.Size = new System.Drawing.Size(71, 25);
            this.my_Chart1ToolStrip.TabIndex = 4;
            this.my_Chart1ToolStrip.Text = "my_Chart1ToolStrip";
            // 
            // my_Chart1ToolStripButton
            // 
            this.my_Chart1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.my_Chart1ToolStripButton.Name = "my_Chart1ToolStripButton";
            this.my_Chart1ToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.my_Chart1ToolStripButton.Text = "My_Chart1";
            this.my_Chart1ToolStripButton.Click += new System.EventHandler(this.my_Chart1ToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_chart";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_chart";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn10.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id_schedule";
            this.dataGridViewTextBoxColumn11.HeaderText = "id_schedule";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // chartBindingSource
            // 
            this.chartBindingSource.DataMember = "chart";
            this.chartBindingSource.DataSource = this.plane_appDataSet1;
            // 
            // plane_appDataSet1
            // 
            this.plane_appDataSet1.DataSetName = "plane_appDataSet1";
            this.plane_appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartTableAdapter
            // 
            this.chartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.chartTableAdapter = this.chartTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PlaneAPP.plane_appDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 626);
            this.Controls.Add(this.my_Chart1ToolStrip);
            this.Controls.Add(this.chartDataGridView);
            this.Controls.Add(this.scheduleToolStrip);
            this.Controls.Add(this.schedule_planeDataGridView);
            this.Controls.Add(this.Auth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plane_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_planeDataGridView)).EndInit();
            this.scheduleToolStrip.ResumeLayout(false);
            this.scheduleToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataGridView)).EndInit();
            this.my_Chart1ToolStrip.ResumeLayout(false);
            this.my_Chart1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane_appDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Auth;
        private plane_appDataSet plane_appDataSet;
        private System.Windows.Forms.BindingSource schedule_planeBindingSource;
        private plane_appDataSetTableAdapters.schedule_planeTableAdapter schedule_planeTableAdapter;
        private plane_appDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView schedule_planeDataGridView;
        private System.Windows.Forms.ToolStrip scheduleToolStrip;
        private System.Windows.Forms.ToolStripButton scheduleToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private plane_appDataSet1 plane_appDataSet1;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private plane_appDataSet1TableAdapters.chartTableAdapter chartTableAdapter;
        private plane_appDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView chartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolStrip my_Chart1ToolStrip;
        private System.Windows.Forms.ToolStripButton my_Chart1ToolStripButton;
    }
}

