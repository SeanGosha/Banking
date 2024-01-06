using SDG.Banking.BL;
using SDG.Banking.BL.Models;
using SDG.Banking.PL;

namespace SDG.Banking.UI
{
    public partial class frmCustomerInformation : Form
    {
        //Create list of customers, deposits, and withdrawals
        List<Customer> customers = new List<Customer>();
        List<Deposit> deposits = new List<Deposit>();
        List<Deposit> withdrawals = new List<Deposit>();
        public frmCustomerInformation()
        {
            InitializeComponent();
        }

        private void frmCustomerInformation_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;

                //Populate customers
                customers = CustomerManager.Load();

                //Populate listbox with customer names with RefreshCustomers method
                RefreshCustomers();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        //Create method to refresh customer list
        private void RefreshCustomers()
        {
            //Set datasource to customers and set display and value members
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
            //Hide unneeded columns
            dgvCustomers.Columns[1].Visible = false;
            dgvCustomers.Columns[2].Visible = false;
            dgvCustomers.Columns[3].Visible = false;
            dgvCustomers.Columns[4].Visible = false;
            dgvCustomers.Columns[10].Visible = false;
            //format date column
            dgvCustomers.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
        }


        private void btnDisplayDeposits_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if (dgvCustomers.CurrentRow != null)
                {
                    RefreshDeposits();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void RefreshDeposits()
        {
            //Set datasource to the customers deposits
            dgvDeposits.DataSource = null;
            dgvDeposits.DataSource = DepositManager.Load(dgvCustomers.CurrentCell.RowIndex + 1);

            //Hide the ID column
            dgvDeposits.Columns[1].Visible = false;
            dgvDeposits.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvDeposits.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btnDisplayWithdrawals_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if (dgvCustomers.CurrentRow != null)
                {
                    RefreshWithdrawals();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void RefreshWithdrawals()
        {
            //Set datasource to the customers withdrawals
            dgvWithdrawals.DataSource = null;
            dgvWithdrawals.DataSource = WithdrawalManager.Load(dgvCustomers.CurrentCell.RowIndex + 1); ;
            dgvWithdrawals.Columns[1].Visible = false;
            dgvWithdrawals.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvWithdrawals.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btnAddDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Create form object with screenmode enum
                frmDepositAndWithdrawal frmDepositAndWithdrawal = new frmDepositAndWithdrawal(ScreenMode.AddDeposit);

                //Check if customer is selected
                if (dgvCustomers.CurrentRow != null)
                {
                    //Set the customer and show the add deposit form
                    frmDepositAndWithdrawal.Customer = customers[dgvCustomers.CurrentCell.RowIndex];
                    frmDepositAndWithdrawal.ShowDialog();

                    //Refresh the deposit list
                    RefreshDeposits();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnEditDeposit_Click(object sender, EventArgs e)
        {
            try
            { 
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Create form object with screenmode enum
                frmDepositAndWithdrawal frmDepositAndWithdrawal = new frmDepositAndWithdrawal(ScreenMode.EditDeposit);

                //Check if deposit is selected
                if (dgvDeposits.CurrentRow != null)
                { 
                    //Set the customer, deposit id, and show the edit deposit form
                    frmDepositAndWithdrawal.Customer = customers[dgvCustomers.CurrentCell.RowIndex];
                    frmDepositAndWithdrawal.DepositId = dgvDeposits.CurrentRow.Index;
                    frmDepositAndWithdrawal.ShowDialog();
                    //Refresh the deposit list
                    RefreshDeposits();
                }
                else
                {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please select a deposit to edit.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnAddWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Create a form object with screenmode enum
                frmDepositAndWithdrawal frmDepositAndWithdrawal = new frmDepositAndWithdrawal(ScreenMode.AddWithdrawal);

                //Check if customer is selected
                if (dgvCustomers.CurrentRow != null)
                {
                    //Set the customer and show the add withdrawal form
                    frmDepositAndWithdrawal.Customer = customers[dgvCustomers.CurrentCell.RowIndex];
                    frmDepositAndWithdrawal.ShowDialog();

                    //Refresh the withdrawal list
                    RefreshWithdrawals();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnEditWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Create form object with screenmode enum
                frmDepositAndWithdrawal frmDepositAndWithdrawal = new frmDepositAndWithdrawal(ScreenMode.EditWithdrawal);

                //Check if customer is selected
                if (dgvWithdrawals.CurrentRow != null)
                {
                    //Set the customer, withdrawal id, and show the edit withdrawal form
                    frmDepositAndWithdrawal.Customer = customers[dgvCustomers.CurrentCell.RowIndex];
                    frmDepositAndWithdrawal.WithdrawalId = dgvWithdrawals.CurrentRow.Index;
                    frmDepositAndWithdrawal.ShowDialog();
                    //Refresh the withdrawal list
                    RefreshWithdrawals();
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Please select a withdrawal to edit.";
                }               
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Check if a customer is selected
                if(dgvCustomers.CurrentRow != null)
                {
                    //Get the selected customer
                    Customer customer = customers[dgvCustomers.CurrentCell.RowIndex];

                    SetProperties(customer);

                    //Refresh the customer list
                    RefreshCustomers();

                    //Update status label
                    lblStatus.Text = "Customer information saved.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void SetProperties(Customer customer)
        {
            //Update the customer properties
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.SSN = txtSSN.Text;
            customer.BirthDate = dtpBirthDate.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                ClearFields();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }

            //Update status label
            lblStatus.Text = "Customer information cleared.";
        }

        private void ClearFields()
        {
            //Clear textboxes and labels
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSSN.Text = string.Empty;
            lblID.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
            lblAge.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Create a new customer object and set the id
                Customer customer = new Customer();

                if (customers.Count > 0)
                {
                    customer.Id = customers.Max(x => x.Id) + 1;
                }
                else
                {
                    customer.Id = 1;
                }

                SetNewProperties(customer);

                //Add the customer to the list
                customers.Add(customer);

                //Refresh the customer list
                RefreshCustomers();

                //Update status label
                lblStatus.Text = "New customer added.";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private static void SetNewProperties(Customer customer)
        {
            //Set general properties of the customer
            customer.FirstName = "New";
            customer.LastName = "Customer";
            customer.SSN = "000-00-0000";
            customer.BirthDate = DateTime.Now;
            customer.Deposits = new List<Deposit>();
            customer.Withdrawals = new List<Withdrawal>();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Check if a customer is selected
                if (dgvCustomers.CurrentRow != null)
                {
                    //Remove the customer from the list
                    customers.Remove(customers[dgvCustomers.CurrentCell.RowIndex]);

                    //Refresh the customer list and clear the fields if there are no customers
                    RefreshCustomers();
                    if (customers.Count <= 0)
                    {
                        ClearFields();
                    }
                    //Clear the datasource
                    dgvDeposits.DataSource = null;
                    dgvWithdrawals.DataSource = null;

                    //Update status label
                    lblStatus.Text = "Customer deleted.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                if(customers != null)
                {
                    //Save to xml file
                    CustomerManager.Save(customers, "customers.xml");

                    //Update status label
                    lblStatus.Text = "File written.";

                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                //Check if customer is selected
                if (dgvCustomers.CurrentRow != null)
                {
                    //Clear the datasource
                    dgvDeposits.DataSource = null;
                    dgvWithdrawals.DataSource = null;

                    //Get the customer
                    Customer customer = customers[dgvCustomers.CurrentCell.RowIndex];

                    //Display customer information
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtSSN.Text = customer.SSN;
                    lblID.Text = customer.Id.ToString();
                    dtpBirthDate.Value = customer.BirthDate;
                    lblAge.Text = customer.Age.ToString();
                }
                else
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                Customer customer = new Customer();

                //Add id
                customer.Id = 1;

                if(customers.Any())
                    customer.Id = customers.Max(x => x.Id) + 1;

                SetNewProperties(customer);

                customers.Add(customer);

                int results = CustomerManager.Insert(customer);
                RefreshCustomers();

            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                Customer customer = customers[dgvCustomers.CurrentCell.RowIndex];

                SetProperties(customer);
                int results = CustomerManager.Update(customer);
                RefreshCustomers();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = string.Empty;

                Customer customer = customers[dgvCustomers.CurrentCell.RowIndex];
                int results = CustomerManager.Delete(customer);
                customers.Remove(customer);
                RefreshCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
    }
}