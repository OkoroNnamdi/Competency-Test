using AspNetCoreHero.Results;
using RelationDataBaseSystem.Model;
using RelationDataBaseSystem.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationDataBaseSystem.Repository
{
    // this is the interfac design
    public  interface IProductRepository
    {
     
        Task<Result<string>> AddProductAsync(productDto product);
        Task <Result<IEnumerable <Product>>> GetAllAsync();
    }
}
