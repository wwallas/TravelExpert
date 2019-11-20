using LINQ_to_SQL_Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace TestPackage
{
    public partial class frmPack : Form
    {
        public Package currentPackage;
        PackageClassDataContext dbContext = new PackageClassDataContext();

        BindingList<Product> CandidatesDetails = new BindingList<Product>();
        public frmPack()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    PackageClassDataContext dbContext = new PackageClassDataContext();

        //    this.cboProducts.SelectedValueChanged -= new System.EventHandler(this.CboProducts_SelectedValueChanged); // disable SelectedValueChanged event
        //    LoadComboBoxProd();
        //    this.cboProducts.SelectedValueChanged += new System.EventHandler(this.CboProducts_SelectedValueChanged); // enable it again




        //}

        private void FrmPack_Load(object sender, EventArgs e)
        {
            PackageClassDataContext dbContext = new PackageClassDataContext();

            this.cboProducts.SelectedValueChanged -= new System.EventHandler(this.CboProducts_SelectedValueChanged); // disable SelectedValueChanged event
            LoadComboBoxProd();
            this.cboProducts.SelectedValueChanged += new System.EventHandler(this.CboProducts_SelectedValueChanged); // enable it again

        }

        private void FrmPack_Load_1(object sender, EventArgs e)
        {
           
        }
        private void CboProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            //string value = ((KeyValuePair<int, string>)cboProducts.SelectedItem).Value.ToString();
            //MessageBox.Show("" + value);
            //int key = (int)cboProducts.SelectedValue;
            //MessageBox.Show("" + key);

            //MessageBox.Show(cboProducts.SelectedValue.ToString());

            int prodID = (int) cboProducts.SelectedValue;
            LoadComboBoxSupp(prodID);


        }

        private void CboSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           // int SupId =(int)cboSupplies.SelectedValue;
           //// int codprosup = 
           //     LoadproSup(SupId);
        }

        private void LoadComboBoxProd()
        {
            try {
                var prds =( from product in dbContext.Products
                           select new { product.ProductId, product.ProdName }).ToList();
                    prds.Insert(0, new { ProductId=0, ProdName="Select Product" });

                cboProducts.DataSource = prds;
                cboProducts.DisplayMember = "ProdName";
                cboProducts.ValueMember = "ProductId";               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void LoadComboBoxSupp(int ProId)
        {
            try
            {
                if (ProId != 0)
                {
                    var supp =( from supplier in dbContext.Suppliers
                               join prodsupp in dbContext.Products_Suppliers
                               on supplier.SupplierId equals prodsupp.SupplierId
                               where prodsupp.ProductId == ProId
                               select new { supplier.SupplierId, supplier.SupName }).ToList();
                    supp.Insert(0, new { SupplierId = 0, SupName = "Select Supplier" });
                    cboSupplies.DataSource = supp;
                    cboSupplies.DisplayMember = "SupName";
                    cboSupplies.ValueMember = "SupplierId";

                    
                }
                else
                {
                    MessageBox.Show("Select a Product");
                    cboProducts.Focus();

                }
                
               // MessageBox.Show(ProId.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }        

        private void LoadproSup(int SupId)
        {
            try
            {
                
                var codprosup = from prosup in dbContext.Products_Suppliers
                                join supplier in dbContext.Suppliers
                                on prosup.SupplierId equals supplier.SupplierId
                                where prosup.SupplierId == SupId
                                select new { prosup.ProductSupplierId };
                foreach (var item in codprosup)
                    Convert.ToInt32(item);
                 
                //MessageBox.Show(s);
                //return codprosup.ElementAtOrDefault;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddPack_Click(object sender, EventArgs e)
        {
            try
            {
                if (//Validator.IsPresent(packageIdTextBox) &&
                    //Validator.IsCorrectLength(packageIdTextBox, 10) &&
                    //IsUniqueCode(packageIdTextBox) && // coded below in this form
                    Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                    Validator.IsPresent(pkgDescTextBox) &&
                    Validator.IsCorrectLength(pkgDescTextBox, 50) &&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsPresent(pkgAgencyCommissionTextBox) &&
                    Validator.IsDecimal(pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeInt(pkgAgencyCommissionTextBox) &&
                    //validate comission
                    ValidateCommission(pkgAgencyCommissionTextBox, pkgBasePriceTextBox) &&
                    //validate Endate
                    ValidateEndDate(pkgEndDateDateTimePicker, pkgStartDateDateTimePicker)&&
                    ValidateProducts(cboProducts)
                    )
                {
                    Package newPckage = new Package // create Package using provided data
                    {
                        //PackageId = Convert.ToInt32(packageIdTextBox.Text),
                        PkgName = pkgNameTextBox.Text,
                        PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text),
                        PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text),
                        PkgDesc = pkgDescTextBox.Text,
                        PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text),
                        PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text),
                    };

                    int SupId = (int)cboSupplies.SelectedValue;

                    int cod = 0;
                    var codprosup = from prosup in dbContext.Products_Suppliers
                                    join supplier in dbContext.Suppliers
                                    on prosup.SupplierId equals supplier.SupplierId
                                    where prosup.SupplierId == SupId
                                    select new { prosup.ProductSupplierId };
                    foreach (var item in codprosup)
                        cod = item.ProductSupplierId;
                    // MessageBox.Show(cod.ToString());
                    //LoadproSup(SupId);

                    // insert through data context object from the main form
                    dbContext.Packages.InsertOnSubmit(newPckage);
                    dbContext.SubmitChanges(); // submit to the database

                    foreach (DataGridViewRow dgvRenglon in dgvProducts.Rows)
                    {
                        if(dgvRenglon.Cells[0].Value.ToString()!=null)
                        MessageBox.Show(dgvRenglon.Cells[0].Value.ToString());

                        Packages_Products_Supplier newPacksup = new Packages_Products_Supplier
                        {
                            PackageId = newPckage.PackageId,
                            ProductSupplierId = Convert.ToInt32( dgvRenglon.Cells[0].Value.ToString()),
                        };
                        dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPacksup);
                        dbContext.SubmitChanges();
                    }
                   
                    //Packages_Products_Supplier newPacksup = new Packages_Products_Supplier
                    //{
                    //    PackageId = GetKeyPack(),
                    //    ProductSupplierId = cod,
                    //};
                    // insert through data context object from the main form


                    //using (var scope = new TransactionScope())
                    //{
                    //    dbContext.SubmitChanges(); // submit to the database

                    //    scope.Complete();
                    //} 

                    DialogResult = DialogResult.OK;

                    MessageBox.Show("Package was entry");
                    this.Refresh();
                    cleanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool IsUniqueCode(TextBox packageIdTextBox)
        {
            Package pack = null;

            pack = (from p in dbContext.Packages
                        where p.PackageId ==Convert.ToInt32( packageIdTextBox.Text)
                    select p).SingleOrDefault();

                //dbContext.Products.Single(p => p.ProductCode == productCodeTextBox.Text);
                if (pack != null) // there is another product with same code
                {
                    MessageBox.Show("Packet code must be unique", "Entry Error");
                    return false;
                }
                else
                    return true;
        }

        private bool ValidateCommission(TextBox pkgAgencyCommissionTextBox, TextBox pkgBasePriceTextBox)
        {
            decimal commission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
            decimal price = Convert.ToDecimal(pkgBasePriceTextBox.Text);
            if (commission > price)
            {
                MessageBox.Show("Commission can be greater than the price", "Entry Error");
                pkgBasePriceTextBox.Focus();
                return false;
            }
            else
                return true;
        }

        private bool ValidateEndDate(DateTimePicker pkgEndDateDateTimePicker, DateTimePicker pkgStartDateDateTimePicker)
        {
            DateTime endDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text);
            DateTime Start = Convert.ToDateTime(pkgStartDateDateTimePicker.Text);
            int result = DateTime.Compare(endDate, Start);
            if (result<0)
            {
                MessageBox.Show("End date must be later than Start Date", "Entry Error");
                pkgEndDateDateTimePicker.Focus();
                return false;
            }
            else
                return true;
        }

        private bool ValidateProducts(ComboBox cboProducts)
        {
            int vlPro = (int)cboProducts.SelectedValue;
            if (vlPro != 0)
            {

                return true;
            }
            else
            {
                MessageBox.Show("Should Select a product", "Entry Error");
                cboProducts.Focus();
                return false;
            }      
            
        }

        private void cleanForm()
        {
            pkgNameTextBox.Text = "";
            pkgDescTextBox.Text = "";
            pkgBasePriceTextBox.Text= "";
            pkgAgencyCommissionTextBox.Text= "";
            pkgStartDateDateTimePicker.CustomFormat= "HH:mm:ss";
            pkgStartDateDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            pkgEndDateDateTimePicker.CustomFormat = "HH:mm:ss";
            pkgEndDateDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //cboProducts.
            //Me.Nombre_TablaBindingSource.Position = X
        }

        //private int GetKeyPack()
        //{               
        //      var packId = ( from max in dbContext.Packages.OrderByDescending(i => i.PackageId)
        //                     select new {  max }).First();
        //    return packId;
        //}

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            //Load Products and supplies from produc_supplies table
            LoadDataGridView((int)cboProducts.SelectedValue, (int)cboSupplies.SelectedValue);         
        }

        private void LoadDataGridView(int proID,int supId )
        {
            try
            {
                if (proID != 0 && supId!=0)
                {
                    dgvProducts.ColumnCount = 3;

                    dgvProducts.Columns[0].Name = "Proid";
                    dgvProducts.Columns[1].Name = "Product";                    
                    dgvProducts.Columns[2].Name = "Supplier";

                    //foreach (DataGridViewRow dgvRenglon in dgvProducts.Rows)
                    //{
                    //    string valpro = dgvRenglon.Cells[0].Value.ToString();
                        
                    //    if (valpro != null )
                    //    {

                    //        if (Convert.ToInt32(valpro) == proID )
                    //        {
                    //            MessageBox.Show("This record already exist");
                    //            cboProducts.Focus();
                    //        }
                    //    }
                    //}


                    var supp = (from supplier in dbContext.Suppliers
                                join prodsupp in dbContext.Products_Suppliers                                
                                on supplier.SupplierId equals prodsupp.SupplierId
                                join product in dbContext.Products
                                on prodsupp.ProductId equals product.ProductId
                                where prodsupp.ProductId == proID && prodsupp.SupplierId== supId
                                select new { prodsupp.ProductSupplierId, product.ProdName, supplier.SupName }).ToList();

                    // select new { prodsupp.ProductId, product.ProdName, supplier.SupplierId, supplier.SupName }).ToList();

                    //dgvProducts.DataSource= supp;

                    if (supp.Count()>0)
                    {
                        foreach (var x in supp)
                        {
                           // if(!dgvProducts.Rows.Equals(x.ProductSupplierId))
                            dgvProducts.Rows.Add(x.ProductSupplierId,x.ProdName,x.SupName); 
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Product");
                    cboProducts.Focus();
                }

                // MessageBox.Show(ProId.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}

