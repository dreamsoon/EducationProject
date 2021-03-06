﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eduction.Data;
using EductionWeb.Areas.Admin.Models;
using Eduction.Service.Catalog.Category;
using Eduction.Service.DTOs.Category;


namespace EductionWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : AdminController
    {

        #region field
        private readonly ICategoryService _categoryService = null;

        public CategoryController(ICategoryService categoryService)
        {

            _categoryService = categoryService;
        }
        #endregion
        public IActionResult Index()
        {
            return RedirectToAction("List");

        }
        [HttpGet]
        public async Task<IActionResult> List(CategoryListItemDTO dTO)
        {

            return View(await _categoryService.SearchCategoryAsync(dTO.CategorySearchName));
        }
        [HttpGet]
        public async Task<IActionResult> GetCategory(string CategorySearchName)
        {
            var _list = await _categoryService.SearchCategoryAsync(CategorySearchName);     
            var list = _list.categories.ToList();
            return new ObjectResult(list);
        }
        [HttpGet]
        public async Task<IActionResult> Create(int? id)
        {
            CategoryDTO DTO = new CategoryDTO();
            var Category = await _categoryService.SearchCategoryByIdAsync(id);
            if (Category != null)
                DTO = await _categoryService.SearchCategoryByIdAsync(id);           
            return View(DTO);
        }
        [HttpGet]
        public async Task<IActionResult> ModalCreate(int? id)
        {          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO DTO)
        {
            if (!ModelState.IsValid)
                return View(DTO);
            if (DTO.ID != 0)
                await _categoryService.UpdateCategoryAsync(DTO);
            else
                await _categoryService.RegisterCategoryAsync(DTO);
            return RedirectToAction("List");
        }
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _categoryService.RemoveCategoryAsync(id);
            return Ok();
        }
    }
}