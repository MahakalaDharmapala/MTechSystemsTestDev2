using MTechTest.Data;
using MTechTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MTechTest
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        DataEmployees employee = new DataEmployees();

        public Form1()
        {
            InitializeComponent();
            InitializeGridView();
            FillingGrid(employee.OrderDataByBornDate());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
         Create the columns of the Grid, in 
        order to fit to our Employee's model 
        features
         */
        private void InitializeGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("RFC");
            dataTable.Columns.Add("Born Date");
            dataTable.Columns.Add("Status");

            dataEmployeesGrid.DataSource = dataTable;
        }

        /*
         Saves the employee's data. This is a modular method
        so it should not be used without validations before calling
         */
        private void SaveEmployee()
        {
            Employee worker = new Employee()
            {
                ID = employee.RetrieveNewID(),
                Name = txtB_Name.Text,
                LastName = txtB_LastName.Text,
                RFC = txtB_RFC.Text,
                BornDate = DateTime.Parse(dateTP_BornDate.Value.ToString()),
                Status = (EmployeeStatus) listBox_Status.SelectedIndex,
            };
            employee.InsertData(worker);
        }

        /*
         Flexible method. Fills the grid with the data inside of 
        the employees list.
         */
        private void FillingGrid(List<Employee> variableList)
        {
            foreach (var worker in variableList)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = worker.ID;
                row["Name"] = worker.Name;
                row["Last Name"] = worker.LastName;
                row["RFC"] = worker.RFC;
                row["Born Date"] = worker.BornDate;
                row["Status"] = worker.Status;
                dataTable.Rows.Add(row);
            }
        }

        /*
         Save button click event, it triggers some validations
        and methods to save the employees info
         */
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtB_RFC.Text != null &&
                txtB_RFC.Text.Length != 0 &&
                txtB_RFC.Text != " " &&
                employee.ValidateRFCFormatAndLength(txtB_RFC.Text) &&
                employee.ValidateUniquenessRFC(txtB_RFC.Text) &&
                employee.ValidString(txtB_Name.Text) &&
                employee.ValidString(txtB_LastName.Text) &&
                listBox_Status.SelectedIndex != -1
                )
            {
                SaveEmployee();
                InitializeGridView();
                FillingGrid(employee.OrderDataByBornDate());

            }
            else if (
                txtB_RFC == null ||
                !employee.ValidateUniquenessRFC(txtB_RFC.Text) == true || 
                !employee.ValidateRFCFormatAndLength(txtB_RFC.Text) == true
                )
                MessageBox.Show("PLEASE, CHECK THE RFC");
            else
                MessageBox.Show("FILL ALL THE ASKED DATA, PLEASE");
        }

       
        /*
         Order by name click event, it sorts the list by name
         */
        private void btn_OrderByName_Click(object sender, EventArgs e)
        {
            InitializeGridView();
            FillingGrid(employee.OrderDataByName());
        }
    }
}
