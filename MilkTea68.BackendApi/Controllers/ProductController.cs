﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkTea68.Application.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkTea68.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductController (IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products =await _publicProductService.GetAll();
            return Ok(products);
        }
    }
}
