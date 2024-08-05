using Document_Oriented_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Oriented_Database.Repositories
{
   public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task Create(Customer customer);
    }
}
