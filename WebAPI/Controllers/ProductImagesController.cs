﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private IProductImageService _imagesService;

        public ProductImageController(IProductImageService productImageService)
        {
            _imagesService = productImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProductImage images)
        {
            var result = _imagesService.Add(file, images);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _imagesService.GetImagesByProductId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imagesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesById([FromForm(Name = ("CarId"))] int carId)
        {
            var result = _imagesService.GetImagesByProductId(carId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}