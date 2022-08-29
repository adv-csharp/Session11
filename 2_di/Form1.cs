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
             */
        }

        private void btnCrudDB_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }
    }
}