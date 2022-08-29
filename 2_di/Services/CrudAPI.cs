using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_di.Services
{
    public class CrudAPI<T> : ICrud<T>
    {
        public void Create(T model)
        {
            /* ... */
            MessageBox.Show("Create API ...");
        }

        public void Detele(int id)
        {
            /* ... */
            MessageBox.Show("Delete API ...");
        }

        public void Update(T model)
        {
            /* ... */
            MessageBox.Show("Update API ..");
        }

        public List<T> Read()
        {
            /* ... */
            MessageBox.Show("Read API ..");
            return new List<T>();
        }
    }
}
