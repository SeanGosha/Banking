using SDG.Banking.BL;
using SDG.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDG.Banking.UI
{
    //Create enum for screenmode
    public enum ScreenMode
    {
        AddDeposit = 0,
        EditDeposit = 1,
        AddWithdrawal = 2,
        EditWithdrawal = 3
    }

    public partial class frmDepositAndWithdrawal : Form
    {
        private ScreenMode screenMode;
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private int depositId;

        public int DepositId
        {
            get { return depositId; }
            set { depositId = value; }
        }

        private int withdrawalId;

        public int WithdrawalId
        {
            get { return withdrawalId; }
            set { withdrawalId = value; }
        }


        public frmDepositAndWithdrawal(ScreenMode screenMode)
        {
            InitializeComponent();
            this.screenMode = screenMode;

            //Set name of form based on screenMode
            if(screenMode == ScreenMode.AddDeposit)
            {
                this.Text = "Add Deposit";
            }
            else if(screenMode == ScreenMode.EditDeposit)
            {
                this.Text = "Edit Deposit";
            }
            else if(screenMode == ScreenMode.AddWithdrawal)
            {
                this.Text = "Add Withdrawal";
            }
            else if(screenMode == ScreenMode.EditWithdrawal)
            {
                this.Text = "Edit Withdrawal";
            }
        }

        private void frmDepositAndWithdrawal_Load(object sender, EventArgs e)
        {
            if(screenMode == ScreenMode.EditDeposit)
            {
                //Get deposit values
                txtAmount.Text = customer.Deposits[depositId].DepositAmount.ToString();
                dtpDate.Value = customer.Deposits[depositId].DepositDate;
            }
            else if(screenMode == ScreenMode.EditWithdrawal)
            {
                //Get withdrawal values
                txtAmount.Text = customer.Withdrawals[withdrawalId].WithdrawalAmount.ToString();
                dtpDate.Value = customer.Withdrawals[withdrawalId].WithdrawalDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (screenMode == ScreenMode.AddDeposit)
                {
                    Deposit deposit = new Deposit();

                    //Create new deposit
                    deposit.DepositId = DepositManager.Load().Count + 1;
                    deposit.CustomerId = customer.Id;
                    deposit.DepositAmount = double.Parse(txtAmount.Text);
                    deposit.DepositDate = dtpDate.Value;

                    //Add deposit to list
                    customer.Deposits.Add(deposit);

                    //Add deposit to db
                    DepositManager.Insert(deposit);

                    this.Close();
                }
                else if (screenMode == ScreenMode.EditDeposit)
                {
                    //Set new deposit values to edited deposit
                    customer.Deposits[depositId].DepositAmount = double.Parse(txtAmount.Text);
                    customer.Deposits[depositId].DepositDate = dtpDate.Value;
                    DepositManager.Update(customer.Deposits[depositId]);

                    this.Close();
                }
                else if (screenMode == ScreenMode.AddWithdrawal)
                {
                    Withdrawal withdrawal = new Withdrawal();

                //Create new withdrawal
                    withdrawal.WithdrawalId = WithdrawalManager.Load().Count + 1;
                    withdrawal.CustomerId = customer.Id;
                    withdrawal.WithdrawalAmount = double.Parse(txtAmount.Text);
                    withdrawal.WithdrawalDate = dtpDate.Value;

                    //Add withdrawal to the list
                    customer.Withdrawals.Add(withdrawal);

                    WithdrawalManager.Insert(withdrawal);
                    this.Close();
                }
                else if (screenMode == ScreenMode.EditWithdrawal)
                {
                    //Set new withdrawal values to edited withdrawal
                    customer.Withdrawals[withdrawalId].WithdrawalAmount = double.Parse(txtAmount.Text);
                    customer.Deposits[depositId].DepositDate = dtpDate.Value;
                    WithdrawalManager.Update(customer.Withdrawals[withdrawalId]);
                    this.Close();
            }
            //}
            /*catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount.");
            }*/
        }
    }
}
