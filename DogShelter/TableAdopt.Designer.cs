
namespace viliProekt2
{
    partial class TableAdopt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adoptersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelterDataSet = new viliProekt2.ShelterDataSet();
            this.shelterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adoptersTableAdapter = new viliProekt2.ShelterDataSetTableAdapters.AdoptersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(964, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adoptersBindingSource
            // 
            this.adoptersBindingSource.DataMember = "Adopters";
            this.adoptersBindingSource.DataSource = this.shelterDataSet;
            // 
            // shelterDataSet
            // 
            this.shelterDataSet.DataSetName = "ShelterDataSet";
            this.shelterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shelterDataSetBindingSource
            // 
            this.shelterDataSetBindingSource.DataSource = this.shelterDataSet;
            this.shelterDataSetBindingSource.Position = 0;
            // 
            // adoptersTableAdapter
            // 
            this.adoptersTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 692);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TableAdopt";
            this.Text = "TableAdopt";
            this.Load += new System.EventHandler(this.TableAdopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelterDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource shelterDataSetBindingSource;
        private ShelterDataSet shelterDataSet;
        private System.Windows.Forms.BindingSource adoptersBindingSource;
        private ShelterDataSetTableAdapters.AdoptersTableAdapter adoptersTableAdapter;
    }
}