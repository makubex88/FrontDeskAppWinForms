using FrontDeskApp.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontDeskApp
{
    public partial class frmFrontDeskApp : Form
    {
        public int totalSmallStorage = 48;
        public int totalMediumStorage = 14;
        public int totalLargeStorage = 12;

        public List<Customer> Customers { get; set; }
        public List<Storage> Storages { get; set; }
        public List<StorageTransactionType> StorageTransactionTypes { get; set; }
        public List<StorageTransaction> Transactions { get; set; }

        // public DataGridView dgvCustomers { get; set; }

        public frmFrontDeskApp()
        {
            InitializeComponent();
            Customers = new List<Customer>();
            Storages = new List<Storage>();
            StorageTransactionTypes = new List<StorageTransactionType>();
            Transactions = new List<StorageTransaction>();

            InitializedComboBox();

            InitializedDataGrids();
        }

        #region Events
        private void frmFrontDeskApp_Load(object sender, EventArgs e)
        {

            PrepareSeedData();

            SetCustomerDataGrid();

            // fill the combobox items with customer records
            SetCustomerComboBox(Customers);

            // initialized counters
            InitializedCounters();

            UpdateStorageCapacity();

            SetStorageTransactionDataGrid();
        }        

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Edit Customer Information");
                try
                {

                    btnSave.Text = "Update";
                    var cust = MapDataCustomerRowToEntity(dgvCustomers.CurrentRow, e.ColumnIndex);
                    MapCustomerEntityToForm(cust);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select correct customer");

                }
            }
        }

        private void dgvStorageTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Edit Storage Transaction Information");
                try
                {
                    btnAddStorageTransaction.Text = "Update";
                    var cust = MapDataStorageTransactionRowToEntity(dgvStorageTransaction.CurrentRow, e.ColumnIndex);
                    MapStorageTransactionEntityToForm(cust);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select correct customer");

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Update")
            {
                btnSave.Text = "Add";

                var updateCustomer = MapCustomerFormToEntity();

                Customers.Where(S => S.Id == Convert.ToInt32(txtIdCustomer.Text))
                            .Select(S =>
                            {
                                S.FirstName = updateCustomer.FirstName;
                                S.LastName = updateCustomer.LastName;
                                S.Phone = updateCustomer.Phone;
                                return S;
                            }).ToList();
            }
            else if (btnSave.Text == "Add")
            {
                var newCustomer = new Customer
                {
                    Id = Customers.Max(m => m.Id) + 1,
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Phone = txtPhone.Text,
                };
                Customers.Add(newCustomer);
            }
            SetCustomerDataGrid();
            ResetCustomerForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetCustomerForm();
        }

        private void btnAddStorageTransaction_Click(object sender, EventArgs e)
        {
            if (btnAddStorageTransaction.Text == "Update")
            {
                
                var updateTransaction = MapStorageTransactionFormToEntity();

                if (!CheckStorageCapacity(updateTransaction.LoadSize, updateTransaction.Quantity) && updateTransaction.TransactionType.Name == "Stored")
                {
                    MessageBox.Show("not enough space");
                }
                else
                {
                    Transactions.Where(S => S.Id == updateTransaction.Id)
                            .Select(S =>
                            {
                                S.Customer = updateTransaction.Customer;
                                S.LoadSize = updateTransaction.LoadSize;
                                S.Quantity = updateTransaction.Quantity;
                                S.Storage = updateTransaction.Storage;
                                S.TransactionType = updateTransaction.TransactionType;
                                return S;
                            }).ToList();

                    MessageBox.Show("Successfully Updated the record");
                    btnAddStorageTransaction.Text = "Add";
                    // Update storage capacity
                    UpdateStorageCapacity();
                    ResetStorageTransactionForm();
                }     
            }
            else if (btnAddStorageTransaction.Text == "Add")
            {
                var customerId = (int)((dynamic)cboCustomer.SelectedItem).Value;
                var newTransaction = new StorageTransaction
                {
                    Id = Transactions.Max(m => m.Id) + 1,
                    Customer = Customers.FirstOrDefault(m => m.Id == customerId),
                    LoadSize = cboLoadType.Text,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Storage = Storages.FirstOrDefault(),
                    TransactionType = StorageTransactionTypes.FirstOrDefault(m => m.Name == cboStatus.Text),
                };

                if (!CheckStorageCapacity(newTransaction.LoadSize, newTransaction.Quantity))
                {
                    MessageBox.Show("not enough space");                    
                }
                else
                {
                    // append the record.
                    Transactions.Add(newTransaction);

                    // Update storage capacity
                    UpdateStorageCapacity();
                    ResetStorageTransactionForm();

                    MessageBox.Show("Successfully Added to Storage");
                }
            }

            SetStorageTransactionDataGrid();
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            ResetStorageTransactionForm();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Load all the seed data
        /// </summary>
        private void PrepareSeedData()
        {
            Customers.AddRange(new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Customer",
                    LastName = "LastName",
                    Phone = "32131231321"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Test",
                    LastName = "LastName2",
                    Phone = "765757675"
                }
            });

            Storages.Add(new Storage
            {
                Id = 1,
                StorageName = "Test",
                TotalOfLargeStorage = totalLargeStorage,
                TotalOfMediumStorage = totalMediumStorage,
                TotalOfSmallStorage = totalSmallStorage
            });

            StorageTransactionTypes.AddRange(new List<StorageTransactionType>
            {
                new StorageTransactionType
                {
                    Id = 1,
                    Name = "Stored"
                },
                new StorageTransactionType
                {
                    Id = 2,
                    Name = "Retreived"
                }
            });

            Transactions.Add(new StorageTransaction
            {
                Id = 1,
                Customer = Customers[0],
                Storage = Storages[0],
                TransactionType = StorageTransactionTypes[0],
                LoadSize = "Small",
                Quantity = 4
            });            
        }

        /// <summary>
        /// Set the Customer Data Grid view
        /// </summary>
        private void SetCustomerDataGrid()
        {
            if (dgvCustomers.DataSource != null)
            {
                dgvCustomers.DataSource = null;
                dgvCustomers.Refresh();
            }

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("Phone", typeof(string)));

            foreach (var cust in Customers)
            {
                DataRow dr = dt.NewRow();
                dr[0] = cust.Id;
                dr[1] = cust.LastName;
                dr[2] = cust.FirstName;
                dr[3] = cust.Phone;
                dt.Rows.Add(dr);
            }

            dgvCustomers.DataSource = dt;

            SetCustomerComboBox(Customers);
        }

        /// <summary>
        /// Set the Storage Transaction Data Grid View
        /// </summary>
        private void SetStorageTransactionDataGrid()
        {
            if (dgvStorageTransaction.DataSource != null)
            {
                dgvStorageTransaction.DataSource = null;
                dgvStorageTransaction.Refresh();
            }

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Customer Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Customer Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Load Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));

            foreach (var transaction in Transactions)
            {
                DataRow dr = dt.NewRow();
                dr[0] = transaction.Id;
                dr[1] = transaction.Customer.Id;
                dr[2] = $"{transaction.Customer.LastName} {transaction.Customer.FirstName}";
                dr[3] = transaction.LoadSize;
                dr[4] = transaction.Quantity;
                dr[5] = transaction.TransactionType.Name;
                dt.Rows.Add(dr);
            }

            dgvStorageTransaction.DataSource = dt;
        }

        /// <summary>
        /// Load combobox for customers
        /// </summary>
        /// <param name="customers"></param>
        private void SetCustomerComboBox(List<Customer> customers)
        {
            cboCustomer.Items.Clear();
            //initialized customer combo box
            var cboCustList = Customers.Select(m => new
            {
                Text = $"{m.LastName} {m.FirstName}",
                Value = m.Id
            }).ToArray();
            cboCustomer.Items.AddRange(cboCustList);
        }

        /// <summary>
        /// Load combobox for Load type and Status
        /// </summary>
        private void InitializedComboBox()
        {
            //initialized load type combo box
            cboLoadType.Items.Add(new { Text = "Small", Value = 1 });
            cboLoadType.Items.Add(new { Text = "Medium", Value = 2 });
            cboLoadType.Items.Add(new { Text = "Large", Value = 2 });

            //initialized status
            cboStatus.Items.Add(new { Text = "Stored", Value = 1 });
            cboStatus.Items.Add(new { Text = "Retreived", Value = 1 });
        }

        /// <summary>
        /// Add initial settings of the data grids
        /// </summary>
        private void InitializedDataGrids()
        {
            // initialized of the customer grid cell button
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            dgvCustomers.Columns.Add(btnEdit);
            btnEdit.HeaderText = "Action";
            btnEdit.Text = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;

            // initialized of the customer grid cell button
            DataGridViewButtonColumn btnEditStorageTransaction = new DataGridViewButtonColumn();
            dgvStorageTransaction.Columns.Add(btnEditStorageTransaction);
            btnEditStorageTransaction.HeaderText = "Action";
            btnEditStorageTransaction.Text = "Edit";
            btnEditStorageTransaction.Name = "btnEdit";
            btnEditStorageTransaction.UseColumnTextForButtonValue = true;
        }

        /// <summary>
        /// Get the storage counters for each type of loads
        /// </summary>
        private void InitializedCounters()
        {
            lblSmallTotalCount.Text = Storages.FirstOrDefault().TotalOfSmallStorage.ToString();
            lblMediumTotalCount.Text = Storages.FirstOrDefault().TotalOfMediumStorage.ToString();
            lblLargeTotalCount.Text = Storages.FirstOrDefault().TotalOfLargeStorage.ToString();
        }

        /// <summary>
        /// Update the capacity of the storage facility
        /// </summary>
        private void UpdateStorageCapacity()
        {
            //Update Total counts
            var currentOccupiedSmall = Transactions.Where(m => m.TransactionType.Name == "Stored" && m.LoadSize == "Small").Sum(m => m.Quantity);
            var currentOccupiedMedium = Transactions.Where(m => m.TransactionType.Name == "Stored" && m.LoadSize == "Medium").Sum(m => m.Quantity);
            var currentOccupiedLarge = Transactions.Where(m => m.TransactionType.Name == "Stored" && m.LoadSize == "Large").Sum(m => m.Quantity);

            Storages.Where(S => S.Id == 1)
                            .Select(S =>
                            {
                                S.CurrentOccupiedSmallStorage = currentOccupiedSmall;
                                S.CurrentOccupiedMediumStorage = currentOccupiedMedium;
                                S.CurrentOccupiedLargeStorage = currentOccupiedLarge;
                                return S;
                            }).ToList();

            lblSmallCurrentCount.Text = Storages.FirstOrDefault().CurrentOccupiedSmallStorage.ToString();
            lblMediumCurrentCount.Text = Storages.FirstOrDefault().CurrentOccupiedMediumStorage.ToString();
            lblLargeCurrentCount.Text = Storages.FirstOrDefault().CurrentOccupiedLargeStorage.ToString();
        }

        /// <summary>
        /// check the capacity of the storage facility
        /// </summary>
        /// <param name="loadSize"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        private bool CheckStorageCapacity(string loadSize, int quantity)
        {
            switch (loadSize)
            {
                case "Small":
                    return Storages.FirstOrDefault().CurrentOccupiedSmallStorage + quantity <= Storages.FirstOrDefault().TotalOfSmallStorage;
                case "Medium":
                    return Storages.FirstOrDefault().CurrentOccupiedMediumStorage + quantity <= Storages.FirstOrDefault().TotalOfMediumStorage;
                case "Large":
                    return Storages.FirstOrDefault().CurrentOccupiedLargeStorage + quantity <= Storages.FirstOrDefault().TotalOfLargeStorage;
            }

            return false;
        }

        /// <summary>
        /// Clear the customer form
        /// </summary>
        private void ResetCustomerForm()
        {
            btnSave.Text = "Add";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
        }

        /// <summary>
        /// Clear the storage transaction form
        /// </summary>
        private void ResetStorageTransactionForm()
        {
            cboCustomer.Text = "";
            cboLoadType.Text = "";
            cboStatus.Text = "";
            txtQuantity.Text = "";
            btnAddStorageTransaction.Text = "Add";
        }


        /// <summary>
        /// Map the values from data grid row to Customer model
        /// </summary>
        /// <param name="_dgvRow"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        private Customer MapDataCustomerRowToEntity(DataGridViewRow _dgvRow, int columnIndex)
        {
            var cust = new Customer
            {
                Id = Convert.ToInt32(_dgvRow.Cells[columnIndex + 1].Value.ToString()),
                FirstName = _dgvRow.Cells[columnIndex + 3].Value.ToString(),
                LastName = _dgvRow.Cells[columnIndex + 2].Value.ToString(),
                Phone = _dgvRow.Cells[columnIndex + 4].Value.ToString()
            };

            return cust;
        }

        /// <summary>
        /// Mapp the storage transaction data grid row to entity
        /// </summary>
        /// <param name="_dgvRow"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        private StorageTransaction MapDataStorageTransactionRowToEntity(DataGridViewRow _dgvRow, int columnIndex)
        {
            var customer = Customers.FirstOrDefault(m => m.Id == (int)_dgvRow.Cells[columnIndex + 2].Value);
            var loadSize = 0;
            var transaction = new StorageTransaction
            {
                Id = Convert.ToInt32(_dgvRow.Cells[columnIndex + 1].Value.ToString()),
                Customer = customer,
                LoadSize = _dgvRow.Cells[columnIndex + 4].Value.ToString(),
                Quantity = (int)_dgvRow.Cells[columnIndex + 5].Value,
                Storage = Storages.FirstOrDefault(),
                TransactionType = StorageTransactionTypes.FirstOrDefault(m => m.Name == _dgvRow.Cells[columnIndex + 6].Value.ToString())
            };

            return transaction;
        }

        /// <summary>
        /// Map the customer model to customer form
        /// </summary>
        /// <param name="cust"></param>
        private void MapCustomerEntityToForm(Customer cust)
        {
            txtIdCustomer.Text = cust.Id.ToString();
            txtFirstName.Text = cust.FirstName;
            txtLastName.Text = cust.LastName;
            txtPhone.Text = cust.Phone;
        }

        /// <summary>
        /// Map customer form to customer model
        /// </summary>
        /// <returns></returns>
        private Customer MapCustomerFormToEntity()
        {
            var customer = new Customer
            {
                Id = Convert.ToInt32(txtIdCustomer.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
            };

            return customer;
        }

        /// <summary>
        /// Map storage transaction entity to form
        /// </summary>
        /// <param name="transaction"></param>
        private void MapStorageTransactionEntityToForm(StorageTransaction transaction)
        {
            txtIdTransaction.Text = transaction.Id.ToString();
            var customer = new 
            { 
                Text = $"{transaction.Customer.LastName} {transaction.Customer.FirstName}",
                Value = transaction.Customer.Id
            };
            cboCustomer.SelectedItem = customer;
            var loadTypeVal = 0;
            switch (transaction.LoadSize)
            {
                case "Small":
                    loadTypeVal = 1;
                    break;
                case "Medium":
                    loadTypeVal = 2;
                    break;
                case "Large":
                    loadTypeVal = 3;
                    break;
            }
            var loadType = new
            {
                Text = transaction.LoadSize,
                Value = loadTypeVal
            };
            cboLoadType.SelectedItem = loadType;
            txtQuantity.Text = transaction.Quantity.ToString();
            var status = new
            {
                Text = transaction.TransactionType.Name,
                Value = transaction.TransactionType.Id
            };
            cboStatus.SelectedItem = status;

        }

        /// <summary>
        /// Map the storage transaction form to entity
        /// </summary>
        /// <returns></returns>
        private StorageTransaction MapStorageTransactionFormToEntity()
        {
            var customerId = (int)((dynamic)cboCustomer.SelectedItem).Value;
            var loadSize = (string)((dynamic)cboLoadType.SelectedItem).Text;
            var status = (string)((dynamic)cboStatus.SelectedItem).Text;
            var transaction = new StorageTransaction
            {
                Id = Convert.ToInt32(txtIdTransaction.Text),
                Customer = Customers.FirstOrDefault(m => m.Id == customerId),
                LoadSize = loadSize,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Storage = Storages.FirstOrDefault(),
                TransactionType = StorageTransactionTypes.FirstOrDefault(m => m.Name == status),
            };
            return transaction;
        }
        #endregion
    }
}
