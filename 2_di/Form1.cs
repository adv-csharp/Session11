using _2_di.Models;
using _2_di.Services;

namespace _2_di
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Interface
             *  Faqat tarif method
             *  field ham nadare
             *  * -> (c# 9 be bad) default implementation
             * 
             * 
             * Dependency Injection - DI
             *  hadaf-> Hazfe Vabastegi Beyene Class ha
             *  
             * DI ~ Inversion of Control - IoC
             * 
             * 
             * IoC Container
             *  autofac
             *  ninject
             *  unity
             * 
             *  map (jadval)
             *      ICrud -> CrudDB
             */
        }

        private void btnCrudDB_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(new CrudDB<Product>());
            //FormProduct formProduct = Ioc.getService<FormProduct>();
            formProduct.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(new CrudAPI<Product>());
            formProduct.ShowDialog();
        }
    }
}