using AspNetCoreHero.Results;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RelationDataBaseSystem.Infrastructure;
using RelationDataBaseSystem.Model;
using RelationDataBaseSystem.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace RelationDataBaseSystem.Repository
{
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// save the product to the database
        /// Display all the records in the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private readonly IProductRepository _repository;
        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(IProductRepository productRepository, ProductDbContext context, IMapper mapper)
        {
            _repository = productRepository;
            _context = context;
            _mapper = mapper;

        }

        public async Task<Result<string>> AddProductAsync(productDto product)
        {
            try
            {
                var newProduct = _mapper.Map<Product>(product);
                await _context.AddAsync(newProduct);
                await _context.SaveChangesAsync();
                return Result<string>.Success("Product Add Sucessful");
            }catch (Exception ex)
            {
                return Result<string>.Fail(ex.Message);
            }
        }

        public async  Task<Result<IEnumerable<Product>>> GetAllAsync()
        {
            try
            {
                 var result =  await    _context.Products.ToListAsync();
                return Result<IEnumerable<Product>>.Success(result);
            }catch (Exception ex)
            {
                return Result<IEnumerable <Product>>.Fail(ex.Message); 
            }
        }
    }

 }
