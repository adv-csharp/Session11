using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_di.Services
{
    public class Crud<T>
    {
        public void Create(T model)
        {
            /* ... */
            MessageBox.Show("Create ...");
        }

        public void Detele(int id)
        {
            /* ... */
            MessageBox.Show("Delete ...");
        }

        public void Update(T model)
        {
            /* ... */
            MessageBox.Show("Update ..");
        }

        public List<T> Read()
        {
            /* ... */
            MessageBox.Show("Read ..");
            return new List<T>();
        }
    }
}
