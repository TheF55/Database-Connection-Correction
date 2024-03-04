using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;

/* Project         Module 9 
 * Programmer      Theodore Feldman
 * Date            10/30/2023
 * Description     Through buttons on screan you can fix errors, delete records, look through those deleted records, and resore deleted records in an Acess database
 */

namespace Chapter_11_Database
{
    public partial class DatabaseForm : Form
    {
        string connString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=BarneyBear.accdb";
        DataTable dt = new DataTable();
        int positionInteger = 0;
        int lengthDataInteger;
        int indexInteger;

        string originalFNameString;
        string originalLNameString;
        string correctedString;

        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            positionInteger += 1;

            if(dt.TableName == "Emp_Deleted")
            {
                dt.TableName = "Employees";
                dt.Reset();
                DatabaseForm_Load(sender, e);
            }

            if(positionInteger == dt.Rows.Count)
            {
                positionInteger= 0;
            }
            this.IdNoTextBox.Text = dt.Rows[positionInteger]["IdNo"].ToString();
            this.lnameTextBox.Text = dt.Rows[positionInteger]["LName"].ToString();
            this.fNameTextBox.Text = dt.Rows[positionInteger]["FName"].ToString();
            this.YearsTextBox.Text = dt.Rows[positionInteger]["Years"].ToString();


        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            dt.TableName = "Employees";
            string dataSourceString = "SELECT * From employees";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataSourceString, connString);

            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

            this.IdNoTextBox.Text = dt.Rows[positionInteger]["IdNo"].ToString();
            this.lnameTextBox.Text= dt.Rows[positionInteger]["LName"].ToString();
            this.fNameTextBox.Text = dt.Rows[positionInteger]["FName"].ToString();
            this.YearsTextBox.Text = dt.Rows[positionInteger]["Years"].ToString();




        }

        private void FixErrorsButton_Click(object sender, EventArgs e)
        {
            //Corrects data entry fields

            //Variables
            int recordCountInteger;
           
            positionInteger = 0;
            indexInteger = 0;
            correctedString = "";
            recordCountInteger = dt.Rows.Count;

            try
            {
                while (positionInteger < recordCountInteger)
                {
                    FixLastName();
                    FixFirstName();
                    positionInteger++;

                    if (positionInteger < recordCountInteger)
                    {
                        this.lnameTextBox.Text = dt.Rows[positionInteger]["LName"].ToString();
                        this.fNameTextBox.Text = dt.Rows[positionInteger]["FName"].ToString();
                    }

                }
                positionInteger--;

                dt.Reset();
                DatabaseForm_Load(sender, e);
                positionInteger = 0;

                this.IdNoTextBox.Text = dt.Rows[positionInteger]["IdNo"].ToString();
                this.lnameTextBox.Text = dt.Rows[positionInteger]["LName"].ToString();
                this.fNameTextBox.Text = dt.Rows[positionInteger]["FName"].ToString();
                this.YearsTextBox.Text = dt.Rows[positionInteger]["Years"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is:" + ex, "Error", MessageBoxButtons.OK);

            }
        }

        private void FixLastName()
        {
            indexInteger = 0;
            correctedString = "";
            lengthDataInteger = this.lnameTextBox.Text.Length;

            while (indexInteger < lengthDataInteger)
            {
                if (this.lnameTextBox.Text.Substring(indexInteger, 1) != "#")
                {
                    if (this.lnameTextBox.Text.Substring(indexInteger, 1) != "&")
                    {
                        if (this.lnameTextBox.Text.Substring(indexInteger, 1) != "$")
                        {
                            if (this.lnameTextBox.Text.Substring(indexInteger, 1) != "*")
                            {
                                correctedString += this.lnameTextBox.Text.Substring(indexInteger, 1);
                            }
                        }
                    }


                }
                indexInteger++;
            }

            //Updates the database

            originalLNameString = this.lnameTextBox.Text.ToString();

            this.lnameTextBox.Text = Convert.ToString(correctedString);

            string dataSourceString = "UPDATE Employees SET LName = '" + this.lnameTextBox.Text + "' WHERE LName = '" + Convert.ToString(originalLNameString) + "'";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataSourceString, connString);

            dt.AcceptChanges();
            dataAdapter.Fill(dt);
            dataAdapter.Update(dt);
        }

        private void FixFirstName()
        {
            indexInteger = 0;
            correctedString = "";
            lengthDataInteger = this.fNameTextBox.Text.Length;

            while (indexInteger < lengthDataInteger)
            {
                if (this.fNameTextBox.Text.Substring(indexInteger, 1) != "#")
                {
                    if (this.fNameTextBox.Text.Substring(indexInteger, 1) != "&")
                    {
                        if (this.fNameTextBox.Text.Substring(indexInteger, 1) != "$")
                        {
                            if (this.fNameTextBox.Text.Substring(indexInteger, 1) != "*")
                            {
                                correctedString += this.fNameTextBox.Text.Substring(indexInteger, 1);
                            }
                        }
                    }


                }
                indexInteger++;
            }

            //Updates the database

            originalFNameString = this.fNameTextBox.Text.ToString();

            this.fNameTextBox.Text = Convert.ToString(correctedString);

            string dataSourceString = "UPDATE Employees SET FName = '" + this.fNameTextBox.Text + "' WHERE FName = '" + Convert.ToString(originalFNameString) + "'";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataSourceString, connString);

            dt.AcceptChanges();
            dataAdapter.Fill(dt);
            dataAdapter.Update(dt);
        }


            private void label3_Click(object sender, EventArgs e)
        {
            //******************Ignore********************
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Moves the current record into the deleted table - Emp_Deleted

            DataTable dtDel = new DataTable();

            try
            {
                dtDel.TableName = "Emp_Deleted";
                connString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = BarneyBear.accdb";

                string dataInsertString = "INSERT INTO Emp_Deleted (IdNo, LName, FName, Years) VALUES ('" + this.IdNoTextBox.Text + "', '"
                    + this.lnameTextBox.Text + "', '"
                    + this.fNameTextBox.Text + "', '"
                    + this.YearsTextBox.Text + "')";

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataInsertString, connString);

                dataAdapter.Fill(dtDel);
                dataAdapter.Dispose();

                

                dataInsertString = "DELETE * FROM Employees WHERE IdNo = '" + this.IdNoTextBox.Text + "'";

                dataAdapter = new OleDbDataAdapter(dataInsertString, connString);
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                positionInteger= 0;
                dt.Reset();
                DatabaseForm_Load(sender, e);

                MessageBox.Show("Record Deleted", "Deletion Report", MessageBoxButtons.OK);


            }
            catch (Exception theException) 
            {
                MessageBox.Show("Error: " + theException, "Error", MessageBoxButtons.OK);
            }
        }

        private void displayDataGridButton_Click(object sender, EventArgs e)
        {
            dt.TableName = "Emp_Deleted";

            int recordCountInteger; 

            connString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = BarneyBear.accdb";
            string dataSourceString = "SELECT * FROM Emp_Deleted";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataSourceString, connString);

            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

            recordCountInteger = dt.Rows.Count;

            if(recordCountInteger <= 0)
            {
                this.MessageLabel.Visible = true;
                this.deletedDataGridView.Visible= false;
                this.restoreButton.Visible = false;
            }
            else
            {
                this.deletedDataGridView.DataSource = dt;
                this.deletedDataGridView.Visible = true;

                this.restoreButton.Visible = true;
                MessageLabel.Visible = false;
            }

            
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = this.deletedDataGridView.CurrentRow;

            this.IdNoTextBox.Text = currentRow.Cells[0].Value.ToString();
            this.lnameTextBox.Text = currentRow.Cells[1].Value.ToString();
            this.fNameTextBox.Text = currentRow.Cells[2].Value.ToString();
            this.YearsTextBox.Text = currentRow.Cells[3].Value.ToString();

            dt.TableName = "Employees";
            connString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = BarneyBear.accdb";

            string dataInsertString = "INSERT INTO Employees (IdNo, LName, FName, Years) VALUES ('" + this.IdNoTextBox.Text + "', '"
                    + this.lnameTextBox.Text + "', '"
                    + this.fNameTextBox.Text + "', '"
                    + this.YearsTextBox.Text + "')";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataInsertString, connString);

            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

            DeleteFromDeleted();

            this.displayDataGridButton.PerformClick();
        }

        private void DeleteFromDeleted()
        {
            dt.TableName = "Emp_Deleted";

            string dataDeleteString = "DELETE * FROM Emp_Deleted WHERE IdNo = '" + this.IdNoTextBox.Text + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataDeleteString, connString);

            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();


        }
    }
}
