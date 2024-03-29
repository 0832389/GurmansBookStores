﻿using GurmanBookStores.Models;
using GurmansBookStores.DataAccess.Repository.IRepository;
using GurmansBookStores.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GurmansBookStores.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(UnitOfWork unitOfWork)
        {
            _unitOfWork = (IUnitOfWork)unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            CategoryController category = new Category();
            if(id == null)
            {
                return View(category);
            }

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    _unitOfWork.save();
                }
                else
                {
                    _unitOfWork.Category.Update(category);

                }
                _unitOfWork.Category.Update(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();

            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
}
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFormDb = _unitOfWork.Category.Get(id);
            if (objFormDb == null)
            {
                return Json(new { success = false, message = "Delete successfull" });
            }

        }

        public static implicit operator CategoryController(Category v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
