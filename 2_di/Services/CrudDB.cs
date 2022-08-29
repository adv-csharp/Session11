using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_di.Services
{
    public class CrudDB<T> : ICrud<T>
    {
        public void Create(T model)
        {
            /* ... */
            MessageBox.Show("Create DB ...");
        }

        public void Detele(int id)
        {
            /* ... */
            MessageBox.Show("Delete DB ...");
        }

        public void Update(T model)
        {
            /* ... */
            MessageBox.Show("Update DB ..");
        }

        public List<T> Read()
        {
            /* ... */
            MessageBox.Show("Read DB ..");
            return new List<T>();
        }
    }
}
