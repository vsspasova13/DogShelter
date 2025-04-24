
namespace viliProekt2
{
    partial class Shelter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shelter));
            this.Adoptt = new System.Windows.Forms.Button();
            this.Empp = new System.Windows.Forms.Button();
            this.Pupp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adoptt
            // 
            this.Adoptt.Location = new System.Drawing.Point(927, 466);
            this.Adoptt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adoptt.Name = "Adoptt";
            this.Adoptt.Size = new System.Drawing.Size(190, 97);
            this.Adoptt.TabIndex = 2;
            this.Adoptt.Text = "Adopters";
            this.Adoptt.UseVisualStyleBackColor = true;
            this.Adoptt.Click += new System.EventHandler(this.Adoptt_Click);
            // 
            // Empp
            // 
            this.Empp.Location = new System.Drawing.Point(513, 466);
            this.Empp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Empp.Name = "Empp";
            this.Empp.Size = new System.Drawing.Size(190, 97);
            this.Empp.TabIndex = 3;
            this.Empp.Text = "Employees";
            this.Empp.UseVisualStyleBackColor = true;
            this.Empp.Click += new System.EventHandler(this.Empp_Click);
            // 
            // Pupp
            // 
            this.Pupp.Location = new System.Drawing.Point(81, 466);
            this.Pupp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pupp.Name = "Pupp";
            this.Pupp.Size = new System.Drawing.Size(190, 97);
            this.Pupp.TabIndex = 4;
            this.Pupp.Text = "Puppies";
            this.Pupp.UseVisualStyleBackColor = true;
            this.Pupp.Click += new System.EventHandler(this.Pupp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::viliProekt2.Properties.Resources.happy_couple_petting_dog_100622_aba23ecfa8804ba9b88afb50ec9e7567;
            this.pictureBox3.Location = new System.Drawing.Point(828, 138);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 266);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::viliProekt2.Properties.Resources.Capture;
            this.pictureBox2.Location = new System.Drawing.Point(424, 138);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::viliProekt2.Properties.Resources.VIER_PFOTEN_2019_03_15_001_2886x1999_1920x1330;
            this.pictureBox1.Location = new System.Drawing.Point(16, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(1088, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Adoptt);
            this.Controls.Add(this.Empp);
            this.Controls.Add(this.Pupp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shelter";
            this.Text = "Shelter";
            this.Load += new System.EventHandler(this.Shelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Adoptt;
        private System.Windows.Forms.Button Empp;
        private System.Windows.Forms.Button Pupp;
        private System.Windows.Forms.Button button1;
    }
}

