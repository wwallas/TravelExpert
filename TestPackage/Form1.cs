using LINQ_to_SQL_Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPackage
{
    public partial class Form1 : Form
    {
        public Package currentPackage;
        PackageClassDataContext dbContext = new PackageClassDataContext();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PackageClassDataContext dbContext = new PackageClassDataContext();

            this.cboProducts.SelectedValueChanged -= new System.EventHandler(this.CboProducts_SelectedValueChanged); // disable SelectedValueChanged event
            LoadComboBoxProd();
            this.cboProducts.SelectedValueChanged += new System.EventHandler(this.CboProducts_SelectedValueChanged); // enable it again




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
                var prds = from product in dbContext.Products
                           select new { product.ProductId, product.ProdName };
                cboProducts.DataSource = prds;
                cboProducts.DisplayMember = "ProdName";
                cboProducts.ValueMember = "ProductId";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void LoadComboBoxSupp(int ProId)
        {
            try
            {
                var supp = from supplier in dbContext.Suppliers
                           join prodsupp in dbContext.Products_Suppliers
                           on supplier.SupplierId equals prodsupp.SupplierId
                           where prodsupp.ProductId == ProId
                           select new { supplier.SupplierId, supplier.SupName };
                cboSupplies.DataSource = supp;
                cboSupplies.DisplayMember = "SupName";
                cboSupplies.ValueMember = "SupplierId";
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
            if (Validator.IsPresent(packageIdTextBox) &&
                    Validator.IsCorrectLength(packageIdTextBox, 10) &&
                    IsUniqueCode(packageIdTextBox) && // coded below in this form
                    Validator.IsPresent(pkgNameTextBox) &&
                    Validator.IsCorrectLength(pkgNameTextBox, 50) &&
                    Validator.IsPresent(pkgDescTextBox) &&
                    Validator.IsCorrectLength(pkgDescTextBox, 50) &&
                    Validator.IsPresent(pkgBasePriceTextBox) &&
                    Validator.IsDecimal(pkgBasePriceTextBox) &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox) &&
                    Validator.IsPresent(pkgAgencyCommissionTextBox) &&
                    Validator.IsDecimal(pkgAgencyCommissionTextBox) &&
                    Validator.IsNonNegativeInt(pkgAgencyCommissionTextBox)
                    )
            {
                Package newPckage = new Package // create Package using provided data
                {
                    PackageId = Convert.ToInt32(packageIdTextBox.Text),
                    PkgName = pkgNameTextBox.Text,
                    PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text),
                    PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text),
                    PkgDesc= pkgDescTextBox.Text,
                    PkgBasePrice=Convert.ToDecimal(pkgBasePriceTextBox.Text),
                    PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text),
                };

                int SupId = (int)cboSupplies.SelectedValue;

                int cod=0;
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


                Packages_Products_Supplier newPacksup = new Packages_Products_Supplier
                {
                    PackageId = Convert.ToInt32(packageIdTextBox.Text),
                    ProductSupplierId=cod,
                };
                // insert through data context object from the main form
                dbContext.Packages_Products_Suppliers.InsertOnSubmit(newPacksup);
                dbContext.SubmitChanges(); // submit to the database
                DialogResult = DialogResult.OK;
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

        
    }
}

