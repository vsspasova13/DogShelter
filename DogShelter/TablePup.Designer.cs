
namespace viliProekt2
{
    partial class TablePup
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
            this.puppiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelterDataSet = new viliProekt2.ShelterDataSet();
            this.puppiesTableAdapter = new viliProekt2.ShelterDataSetTableAdapters.PuppiesTableAdapter();
            this.puppiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new viliProekt2.ShelterDataSetTableAdapters.TableAdapterManager();
            this.shelterDataSet1 = new viliProekt2.ShelterDataSet1();
            this.puppiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.puppiesTableAdapter1 = new viliProekt2.ShelterDataSet1TableAdapters.PuppiesTableAdapter();
            this.tableAdapterManager1 = new viliProekt2.ShelterDataSet1TableAdapters.TableAdapterManager();
            this.puppiesDataGridView = new System.Windows.Forms.DataGridView();
            this.puppiesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // puppiesBindingSource
            // 
            this.puppiesBindingSource.DataMember = "Puppies";
            this.puppiesBindingSource.DataSource = this.shelterDataSetBindingSource;
            // 
            // shelterDataSetBindingSource
            // 
            this.shelterDataSetBindingSource.DataSource = this.shelterDataSet;
            this.shelterDataSetBindingSource.Position = 0;
            // 
            // shelterDataSet
            // 
            this.shelterDataSet.DataSetName = "ShelterDataSet";
            this.shelterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puppiesTableAdapter
            // 
            this.puppiesTableAdapter.ClearBeforeFill = true;
            // 
            // puppiesBindingSource1
            // 
            this.puppiesBindingSource1.DataMember = "Puppies";
            this.puppiesBindingSource1.DataSource = this.shelterDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BreedsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.PuppiesTableAdapter = this.puppiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = viliProekt2.ShelterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shelterDataSet1
            // 
            this.shelterDataSet1.DataSetName = "ShelterDataSet1";
            this.shelterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puppiesBindingSource2
            // 
            this.puppiesBindingSource2.DataMember = "Puppies";
            this.puppiesBindingSource2.DataSource = this.shelterDataSet1;
            // 
            // puppiesTableAdapter1
            // 
            this.puppiesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdoptersTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BreedsTableAdapter = null;
            this.tableAdapterManager1.EmployeesTableAdapter = null;
            this.tableAdapterManager1.PositionsTableAdapter = null;
            this.tableAdapterManager1.PuppiesTableAdapter = this.puppiesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = viliProekt2.ShelterDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // puppiesDataGridView
            // 
            this.puppiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puppiesDataGridView.Location = new System.Drawing.Point(41, 24);
            this.puppiesDataGridView.Name = "puppiesDataGridView";
            this.puppiesDataGridView.RowHeadersWidth = 62;
            this.puppiesDataGridView.RowTemplate.Height = 28;
            this.puppiesDataGridView.Size = new System.Drawing.Size(1134, 819);
            this.puppiesDataGridView.TabIndex = 0;
            this.puppiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.puppiesDataGridView_CellContentClick);
            // 
            // puppiesBindingSource3
            // 
            this.puppiesBindingSource3.DataMember = "Puppies";
            this.puppiesBindingSource3.DataSource = this.shelterDataSetBindingSource;
            // 
            // TablePup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 874);
            this.Controls.Add(this.puppiesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TablePup";
            this.Text = "TablePup";
            this.Load += new System.EventHandler(this.TablePup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puppiesBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource shelterDataSetBindingSource;
        private ShelterDataSet shelterDataSet;
        private System.Windows.Forms.BindingSource puppiesBindingSource;
        private ShelterDataSetTableAdapters.PuppiesTableAdapter puppiesTableAdapter;
        private System.Windows.Forms.BindingSource puppiesBindingSource1;
        private ShelterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ShelterDataSet1 shelterDataSet1;
        private System.Windows.Forms.BindingSource puppiesBindingSource2;
        private ShelterDataSet1TableAdapters.PuppiesTableAdapter puppiesTableAdapter1;
        private ShelterDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView puppiesDataGridView;
        private System.Windows.Forms.BindingSource puppiesBindingSource3;
    }
}