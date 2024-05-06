﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository productRepository;
    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }
}