﻿using System;
using FAEmlak.Business.Abstract;
using FAEmlak.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FAEmlak.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IPropertyService _propertyService;

        public CategoryController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public IActionResult ListCategories(string propertyType, string propertyCategory)
        {
            try
            {
                PropertyType type = (PropertyType)Enum.Parse(typeof(PropertyType), propertyType);
                PropertyCategory category = (PropertyCategory)Enum.Parse(typeof(PropertyCategory), propertyCategory);

                var properties = _propertyService.GetPropertiesByTypeAndCategory(type, category);


                return View();
            }
            catch (Exception ex)
            {
                return View();
            }

        }
    }
}