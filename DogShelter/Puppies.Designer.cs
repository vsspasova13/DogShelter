
namespace viliProekt2
{
    partial class Puppies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puppies));
            this.txtBreedName = new System.Windows.Forms.TextBox();
            this.brname = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtBreedId = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.BreedId = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.addnew = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.showtable = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBreedName
            // 
            this.txtBreedName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedName.Location = new System.Drawing.Point(662, 108);
            this.txtBreedName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(244, 51);
            this.txtBreedName.TabIndex = 27;
            // 
            // brname
            // 
            this.brname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.brname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brname.Location = new System.Drawing.Point(662, 41);
            this.brname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brname.Name = "brname";
            this.brname.Size = new System.Drawing.Size(93, 57);
            this.brname.TabIndex = 26;
            this.brname.Text = "Breed Name:";
            this.brname.UseVisualStyleBackColor = false;
            this.brname.Click += new System.EventHandler(this.brname_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(532, 240);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(94, 51);
            this.txtAge.TabIndex = 25;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(532, 174);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(223, 51);
            this.txtColor.TabIndex = 24;
            // 
            // txtBreedId
            // 
            this.txtBreedId.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedId.Location = new System.Drawing.Point(532, 108);
            this.txtBreedId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBreedId.Name = "txtBreedId";
            this.txtBreedId.Size = new System.Drawing.Size(94, 51);
            this.txtBreedId.TabIndex = 23;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDate.Location = new System.Drawing.Point(214, 240);
            this.txtBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(196, 51);
            this.txtBirthDate.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(214, 174);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 51);
            this.txtName.TabIndex = 21;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(214, 108);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(94, 51);
            this.txtId.TabIndex = 20;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(437, 240);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(88, 45);
            this.Age.TabIndex = 18;
            this.Age.Text = "Age:";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(418, 178);
            this.Color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(107, 45);
            this.Color.TabIndex = 19;
            this.Color.Text = "Color:";
            // 
            // BreedId
            // 
            this.BreedId.AutoSize = true;
            this.BreedId.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreedId.Location = new System.Drawing.Point(363, 112);
            this.BreedId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BreedId.Name = "BreedId";
            this.BreedId.Size = new System.Drawing.Size(166, 45);
            this.BreedId.TabIndex = 17;
            this.BreedId.Text = "Breed Id:";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(22, 243);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(189, 45);
            this.BirthDate.TabIndex = 16;
            this.BirthDate.Text = "Birth Date:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(94, 178);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(115, 45);
            this.labelname.TabIndex = 15;
            this.labelname.Text = "Name:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(141, 120);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(66, 45);
            this.Id.TabIndex = 14;
            this.Id.Text = "Id:";
            // 
            // addnew
            // 
            this.addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.Location = new System.Drawing.Point(382, 386);
            this.addnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(147, 82);
            this.addnew.TabIndex = 12;
            this.addnew.Text = "Add New";
            this.addnew.UseVisualStyleBackColor = true;
            this.addnew.Click += new System.EventHandler(this.addnew_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(30, 386);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(147, 82);
            this.search.TabIndex = 11;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(204, 386);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(147, 82);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(382, 477);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(147, 82);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // showtable
            // 
            this.showtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtable.Location = new System.Drawing.Point(204, 477);
            this.showtable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showtable.Name = "showtable";
            this.showtable.Size = new System.Drawing.Size(147, 82);
            this.showtable.TabIndex = 8;
            this.showtable.Text = "Show Table";
            this.showtable.UseVisualStyleBackColor = true;
            this.showtable.Click += new System.EventHandler(this.showtable_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(30, 477);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(147, 82);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(862, 545);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(95, 48);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::viliProekt2.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(548, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Puppies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(967, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBreedName);
            this.Controls.Add(this.brname);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtBreedId);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.BreedId);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showtable);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Puppies";
            this.Text = "Puppies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBreedName;
        private System.Windows.Forms.Button brname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtBreedId;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label BreedId;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button showtable;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}