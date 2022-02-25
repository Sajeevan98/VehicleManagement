namespace VehicleManagement
{
    partial class AddDetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVehicleId = new System.Windows.Forms.Label();
            this.labelVehicleName = new System.Windows.Forms.Label();
            this.labelVehicleCompany = new System.Windows.Forms.Label();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.labelVehicleImage = new System.Windows.Forms.Label();
            this.pictureBoxVehicleImageAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxVehicleNumber = new System.Windows.Forms.TextBox();
            this.textBoxVehicleType = new System.Windows.Forms.TextBox();
            this.textBoxVehicleCompany = new System.Windows.Forms.TextBox();
            this.textBoxVehicleColour = new System.Windows.Forms.TextBox();
            this.buttonVehicleImage = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleImageAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox1.Location = new System.Drawing.Point(-1, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(1068, 67);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // labelVehicleId
            // 
            this.labelVehicleId.AutoSize = true;
            this.labelVehicleId.BackColor = System.Drawing.Color.Turquoise;
            this.labelVehicleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleId.ForeColor = System.Drawing.Color.Blue;
            this.labelVehicleId.Location = new System.Drawing.Point(56, 102);
            this.labelVehicleId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleId.Name = "labelVehicleId";
            this.labelVehicleId.Size = new System.Drawing.Size(162, 25);
            this.labelVehicleId.TabIndex = 2;
            this.labelVehicleId.Text = "Vehicle Number :";
            this.labelVehicleId.UseWaitCursor = true;
            this.labelVehicleId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVehicleName
            // 
            this.labelVehicleName.AutoSize = true;
            this.labelVehicleName.BackColor = System.Drawing.Color.Turquoise;
            this.labelVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleName.ForeColor = System.Drawing.Color.Blue;
            this.labelVehicleName.Location = new System.Drawing.Point(56, 156);
            this.labelVehicleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleName.Name = "labelVehicleName";
            this.labelVehicleName.Size = new System.Drawing.Size(138, 25);
            this.labelVehicleName.TabIndex = 4;
            this.labelVehicleName.Text = "Vehicle Type :";
            this.labelVehicleName.UseWaitCursor = true;
            this.labelVehicleName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelVehicleCompany
            // 
            this.labelVehicleCompany.AutoSize = true;
            this.labelVehicleCompany.BackColor = System.Drawing.Color.Turquoise;
            this.labelVehicleCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleCompany.ForeColor = System.Drawing.Color.Blue;
            this.labelVehicleCompany.Location = new System.Drawing.Point(56, 207);
            this.labelVehicleCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleCompany.Name = "labelVehicleCompany";
            this.labelVehicleCompany.Size = new System.Drawing.Size(108, 25);
            this.labelVehicleCompany.TabIndex = 6;
            this.labelVehicleCompany.Text = "Company :";
            this.labelVehicleCompany.UseWaitCursor = true;
            this.labelVehicleCompany.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.BackColor = System.Drawing.Color.Turquoise;
            this.labelVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleType.ForeColor = System.Drawing.Color.Blue;
            this.labelVehicleType.Location = new System.Drawing.Point(56, 260);
            this.labelVehicleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(151, 25);
            this.labelVehicleType.TabIndex = 8;
            this.labelVehicleType.Text = "Vehicle Colour :";
            this.labelVehicleType.UseWaitCursor = true;
            this.labelVehicleType.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelVehicleImage
            // 
            this.labelVehicleImage.AutoSize = true;
            this.labelVehicleImage.BackColor = System.Drawing.Color.Turquoise;
            this.labelVehicleImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleImage.ForeColor = System.Drawing.Color.Blue;
            this.labelVehicleImage.Location = new System.Drawing.Point(56, 314);
            this.labelVehicleImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVehicleImage.Name = "labelVehicleImage";
            this.labelVehicleImage.Size = new System.Drawing.Size(147, 25);
            this.labelVehicleImage.TabIndex = 10;
            this.labelVehicleImage.Text = "Vehicle Image :";
            this.labelVehicleImage.UseWaitCursor = true;
            this.labelVehicleImage.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBoxVehicleImageAdd
            // 
            this.pictureBoxVehicleImageAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBoxVehicleImageAdd.Location = new System.Drawing.Point(217, 314);
            this.pictureBoxVehicleImageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxVehicleImageAdd.Name = "pictureBoxVehicleImageAdd";
            this.pictureBoxVehicleImageAdd.Size = new System.Drawing.Size(444, 148);
            this.pictureBoxVehicleImageAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehicleImageAdd.TabIndex = 11;
            this.pictureBoxVehicleImageAdd.TabStop = false;
            this.pictureBoxVehicleImageAdd.UseWaitCursor = true;
            this.pictureBoxVehicleImageAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "ADD VEHICLE DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleManagement.Properties.Resources.GAIN;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // textBoxVehicleNumber
            // 
            this.textBoxVehicleNumber.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxVehicleNumber.Location = new System.Drawing.Point(216, 106);
            this.textBoxVehicleNumber.Name = "textBoxVehicleNumber";
            this.textBoxVehicleNumber.Size = new System.Drawing.Size(443, 22);
            this.textBoxVehicleNumber.TabIndex = 37;
            this.textBoxVehicleNumber.UseWaitCursor = true;
            this.textBoxVehicleNumber.TextChanged += new System.EventHandler(this.textBoxVehicleNumber_TextChanged);
            // 
            // textBoxVehicleType
            // 
            this.textBoxVehicleType.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxVehicleType.Location = new System.Drawing.Point(216, 160);
            this.textBoxVehicleType.Name = "textBoxVehicleType";
            this.textBoxVehicleType.Size = new System.Drawing.Size(443, 22);
            this.textBoxVehicleType.TabIndex = 38;
            this.textBoxVehicleType.UseWaitCursor = true;
            // 
            // textBoxVehicleCompany
            // 
            this.textBoxVehicleCompany.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxVehicleCompany.Location = new System.Drawing.Point(216, 211);
            this.textBoxVehicleCompany.Name = "textBoxVehicleCompany";
            this.textBoxVehicleCompany.Size = new System.Drawing.Size(443, 22);
            this.textBoxVehicleCompany.TabIndex = 39;
            this.textBoxVehicleCompany.UseWaitCursor = true;
            // 
            // textBoxVehicleColour
            // 
            this.textBoxVehicleColour.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxVehicleColour.Location = new System.Drawing.Point(216, 264);
            this.textBoxVehicleColour.Name = "textBoxVehicleColour";
            this.textBoxVehicleColour.Size = new System.Drawing.Size(443, 22);
            this.textBoxVehicleColour.TabIndex = 40;
            this.textBoxVehicleColour.UseWaitCursor = true;
            // 
            // buttonVehicleImage
            // 
            this.buttonVehicleImage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonVehicleImage.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonVehicleImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleImage.ForeColor = System.Drawing.Color.White;
            this.buttonVehicleImage.Location = new System.Drawing.Point(579, 435);
            this.buttonVehicleImage.Name = "buttonVehicleImage";
            this.buttonVehicleImage.Size = new System.Drawing.Size(82, 27);
            this.buttonVehicleImage.TabIndex = 41;
            this.buttonVehicleImage.Text = "Choose";
            this.buttonVehicleImage.UseVisualStyleBackColor = false;
            this.buttonVehicleImage.UseWaitCursor = true;
            this.buttonVehicleImage.Click += new System.EventHandler(this.buttonVehicleImage_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddCancel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddCancel.Location = new System.Drawing.Point(503, 495);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(156, 37);
            this.btnAddCancel.TabIndex = 42;
            this.btnAddCancel.Text = "Back";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.UseWaitCursor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(217, 495);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 37);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.buttonVehicleImage);
            this.Controls.Add(this.textBoxVehicleColour);
            this.Controls.Add(this.textBoxVehicleCompany);
            this.Controls.Add(this.textBoxVehicleType);
            this.Controls.Add(this.textBoxVehicleNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxVehicleImageAdd);
            this.Controls.Add(this.labelVehicleImage);
            this.Controls.Add(this.labelVehicleType);
            this.Controls.Add(this.labelVehicleCompany);
            this.Controls.Add(this.labelVehicleName);
            this.Controls.Add(this.labelVehicleId);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDetails";
            this.Text = "AddDetails";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.AddDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicleImageAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVehicleId;
        private System.Windows.Forms.Label labelVehicleName;
        private System.Windows.Forms.Label labelVehicleCompany;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.Label labelVehicleImage;
        private System.Windows.Forms.PictureBox pictureBoxVehicleImageAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxVehicleNumber;
        private System.Windows.Forms.TextBox textBoxVehicleType;
        private System.Windows.Forms.TextBox textBoxVehicleCompany;
        private System.Windows.Forms.TextBox textBoxVehicleColour;
        private System.Windows.Forms.Button buttonVehicleImage;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}