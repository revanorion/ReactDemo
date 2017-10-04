using CodeTables.Data.Repositories;
//using InventoryManager.Data.DTOs;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CodeTables.Data.Context;
using CodeTables.Data.Entities;

namespace InventoryManager.Controllers
{
    [Route("api/[controller]")]
    public class ExternalPaymentTypeController : Controller
    {
        private readonly IRepository repository;

        public ExternalPaymentTypeController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public JsonResult Create()
        {
            ExternalPaymentType externalPaymentType = new ExternalPaymentType();
            
            return Json(new { success = true, model = externalPaymentType });
        }

        [HttpPost]
        public JsonResult Create(ExternalPaymentType externalPaymentType)
        {
            if (ModelState.IsValid)
            {
                repository.Add(externalPaymentType);
                repository.Commit();
                return Json(new { success = true, model = externalPaymentType });
            }
            return Json(new { success = false, model = externalPaymentType });

        }
      

        [HttpGet]
        public JsonResult Edit(int id)
        {
            var externalPaymentType = repository.GetSet<ExternalPaymentType>().Where(x => x.PaymentTypeSeq == id);
            return Json(new { success = true, model = externalPaymentType });
        }

        [HttpPost]
        public JsonResult Edit(ExternalPaymentType externalPaymentType)
        {
            if (ModelState.IsValid)
            {
                repository.Update(externalPaymentType);
                repository.Commit();
                return Json(new { success = true, model = externalPaymentType });
            }
            return Json(new { success = false, model = externalPaymentType });
        }

        [HttpGet]
        public JsonResult Delete(int? id, ExternalPaymentType externalPaymentType = null)
        {
            if (id != null)
                return Json(new { success = false, model = repository.GetSet<ExternalPaymentType>().Where(x => x.PaymentTypeSeq == id) });
            if (ModelState.IsValid)
                return Json(new { success = true, model = externalPaymentType });
            return Json(new { success = false, model = externalPaymentType });
        }
        [HttpPost]
        public JsonResult Delete(ExternalPaymentType externalPaymentType)
        {
            ModelState.Remove("IsActive");
            ModelState.Remove("Description");
            if (ModelState.IsValid)
            {
                repository.Delete(externalPaymentType);
                repository.Commit();

                return Json(new { success = true, model = externalPaymentType });
            }
            return Json(new { success = false, model = externalPaymentType });
        }

        [HttpGet("[action]")]
        public JsonResult GetExternalPaymentTypes(int index)
        {
            var externalPaymentTypes = repository.GetSet<ExternalPaymentType>()
                .Select(x => new { x.PaymentTypeSeq, x.PaymentTypeDescription });
                //.Skip(index);
            return Json(new { success = true, model = externalPaymentTypes });
        }
    }
}