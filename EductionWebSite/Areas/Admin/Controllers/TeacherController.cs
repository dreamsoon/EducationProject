﻿using Eduction.Core.Extension;
using Eduction.Service.Catalog.Teacher;
using Eduction.Service.DTOs.Teacher;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EductionWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController: AdminController
    {
        private readonly ITeacherService _teacherService = null;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public  IActionResult Index() 
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public async Task<IActionResult> List(TeacherListItemDTO dTO) 
        {
            return View(await _teacherService.SearchTeacheryAsync(dTO.TeacherSearchName)); 
        }
        [HttpGet]
        public async Task<IActionResult> GetTeachers(string TeacherSearchName)
        {
            var _list = await _teacherService.SearchTeacheryAsync(TeacherSearchName);
            var list = _list.Teachers.ToList();
            return new OkObjectResult(list);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int? id)
        {
            TeacherDTO dTO = new TeacherDTO();        
            var teacher =await _teacherService.SearchTeacherByIdAsync(id);
            dTO.BirthDay = DateTime.Now;
            if (teacher != null)
                dTO= await _teacherService.SearchTeacherByIdAsync(id);
            return View (dTO);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TeacherDTO dTO)
        {
            dTO.Sex = 1;
           
            if (!ModelState.IsValid)
                return View(dTO);
            if (dTO.ID != 0)
                await _teacherService.UpdateCategoryAsync(dTO);
            else
                await _teacherService.RegisterTeacheryAsync(dTO);
            return RedirectToAction("List");


        }
        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await _teacherService.RemoveTeacherAsync(id);
            return Ok();
        }
    }
}
