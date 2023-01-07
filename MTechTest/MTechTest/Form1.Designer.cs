namespace MTechTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB_Name = new System.Windows.Forms.TextBox();
            this.txtB_LastName = new System.Windows.Forms.TextBox();
            this.txtB_RFC = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_OrderByName = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataEmployeesGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTP_BornDate = new System.Windows.Forms.DateTimePicker();
            this.listBox_Status = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BORN DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "STATUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DEV TEST 2: DURÓN DE LUNA OSCAR ALEJANDRO";
            // 
            // txtB_Name
            // 
            this.txtB_Name.Location = new System.Drawing.Point(33, 91);
            this.txtB_Name.Name = "txtB_Name";
            this.txtB_Name.Size = new System.Drawing.Size(100, 20);
            this.txtB_Name.TabIndex = 8;
            // 
            // txtB_LastName
            // 
            this.txtB_LastName.Location = new System.Drawing.Point(154, 91);
            this.txtB_LastName.Name = "txtB_LastName";
            this.txtB_LastName.Size = new System.Drawing.Size(100, 20);
            this.txtB_LastName.TabIndex = 9;
            // 
            // txtB_RFC
            // 
            this.txtB_RFC.Location = new System.Drawing.Point(276, 91);
            this.txtB_RFC.Name = "txtB_RFC";
            this.txtB_RFC.Size = new System.Drawing.Size(100, 20);
            this.txtB_RFC.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(651, 92);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_OrderByName
            // 
            this.btn_OrderByName.Location = new System.Drawing.Point(665, 149);
            this.btn_OrderByName.Name = "btn_OrderByName";
            this.btn_OrderByName.Size = new System.Drawing.Size(75, 26);
            this.btn_OrderByName.TabIndex = 15;
            this.btn_OrderByName.Text = "Name";
            this.btn_OrderByName.UseVisualStyleBackColor = true;
            this.btn_OrderByName.Click += new System.EventHandler(this.btn_OrderByName_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TBD";
            // 
            // dataEmployeesGrid
            // 
            this.dataEmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeesGrid.Location = new System.Drawing.Point(44, 181);
            this.dataEmployeesGrid.Name = "dataEmployeesGrid";
            this.dataEmployeesGrid.ReadOnly = true;
            this.dataEmployeesGrid.Size = new System.Drawing.Size(696, 242);
            this.dataEmployeesGrid.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Order By:";
            // 
            // dateTP_BornDate
            // 
            this.dateTP_BornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTP_BornDate.Location = new System.Drawing.Point(401, 91);
            this.dateTP_BornDate.Name = "dateTP_BornDate";
            this.dateTP_BornDate.Size = new System.Drawing.Size(105, 20);
            this.dateTP_BornDate.TabIndex = 20;
            // 
            // listBox_Status
            // 
            this.listBox_Status.FormattingEnabled = true;
            this.listBox_Status.Items.AddRange(new object[] {
            "Not Set",
            "Active",
            "Inactive"});
            this.listBox_Status.Location = new System.Drawing.Point(533, 91);
            this.listBox_Status.Name = "listBox_Status";
            this.listBox_Status.Size = new System.Drawing.Size(82, 43);
            this.listBox_Status.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Status);
            this.Controls.Add(this.dateTP_BornDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataEmployeesGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_OrderByName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtB_RFC);
            this.Controls.Add(this.txtB_LastName);
            this.Controls.Add(this.txtB_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "MTechSystems";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB_Name;
        private System.Windows.Forms.TextBox txtB_LastName;
        private System.Windows.Forms.TextBox txtB_RFC;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_OrderByName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataEmployeesGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTP_BornDate;
        private System.Windows.Forms.ListBox listBox_Status;
    }
}

