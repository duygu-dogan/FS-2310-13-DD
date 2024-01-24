﻿using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductManager(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO)
        {
            var product = _mapper.Map<Product>(addProductDTO);
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            var createdProduct = await _repository.CreateAsync(product);
            if (createdProduct == null)
            {
                return Response<ProductDTO>.Fail("Bir hata oluştu", 404);
            }

            createdProduct.ProductCategories = addProductDTO
                .CategoryList.Select(c => new ProductCategory
                {
                    ProductId = createdProduct.Id,
                    CategoryId = c.Id
                }).ToList();
            await _repository.UpdateAsync(createdProduct);
            var createdProductDTO = _mapper.Map<ProductDTO>(createdProduct);
            return Response<ProductDTO>.Success(createdProductDTO, 200);
        }

        public async Task<Response<List<ProductDTO>>> GetAllAsync()
        {
            var productList = await _repository.GetAllAsync();
            if (productList == null)
            {
                return Response<List<ProductDTO>>.Fail("Hiç ürün bulunamadı.", 301);
            }
            var productDTOList = _mapper.Map<List<ProductDTO>>(productList);
            return Response<List<ProductDTO>>.Success(productDTOList, 200);
        }

        public async Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync()
        {
            var response = await _repository.GetAllProductsWithCategoriesAsync();
            if(response == null)
            {
                return Response<List<ProductDTO>>.Fail("Hiç ürün bulunamadı.", 301);
            }
            var productDTOList = _mapper.Map<List<ProductDTO>>(response);
            return Response<List<ProductDTO>>.Success(productDTOList, 200);

        }

        public async Task<Response<ProductDTO>> GetByIdAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı.", 404);
            }
            var productDTO = _mapper.Map<ProductDTO>(product);
            return Response<ProductDTO>.Success(productDTO, 200);
        }

        public async Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var productList= await _repository.GetProductsByCategoryIdAsync(categoryId);
            if (productList == null)
            {
                return Response<List<ProductDTO>>.Fail("Bu kategoride hiç ürün bulunamadı.", 301);
            }
            var productDTOList = _mapper.Map<List<ProductDTO>>(productList);
            return Response<List<ProductDTO>>.Success(productDTOList, 200);
        }

        public async Task<Response<ProductDTO>> GetProductWithCategoriesAsync(int id)
        {
            var product = await _repository.GetProductWithCategoriesAsync(id);
            if (product == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı.", 404);
            }
            var productDTO = _mapper.Map<ProductDTO>(product);
            return Response<ProductDTO>.Success(productDTO, 200);
            
        }

        public async Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.", 404);
            }
            await _repository.HardDeleteAsync(product);
            return Response<NoContent>.Success(200);
        
        }

        public async Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı.", 404);
            }
            if(product.IsDeleted)
            {
                return Response<NoContent>.Fail("Bu ürün zaten silinmiş.", 404);
            }
            product.IsDeleted = !product.IsDeleted;
            product.IsActive = false;
            product.ModifiedDate = DateTime.Now;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<ProductDTO>> UpdateAsync(EditProductDTO EditProductDTO)
        {
       
        var editedProduct = _mapper.Map<Product>(EditProductDTO);
            if (editedProduct == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı.", 404);
            }
            editedProduct.ModifiedDate = DateTime.Now;
           await _repository.UpdateAsync(editedProduct);
            var resultProduct = _mapper.Map<ProductDTO>(editedProduct);
            return Response<ProductDTO>.Success(resultProduct, 200);
        }
    }
}
