using Microsoft.AspNetCore.Mvc;
using ProjectMvc.BLL.Interfaces;
using ProjectMvc.BLL.Repositories;
using ProjectMvc.DAL.Models;

namespace ProjectMvc.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentController( IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var department = _departmentRepository.GetAll();
            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Add(department);
                return RedirectToAction(nameof(Index));
            }

            return View(department);
        }

        public IActionResult Details(int? id, string ViewName= "Details")
        {
            if (id is null)
                return BadRequest();
            var department = _departmentRepository.GetById(id.Value);
            if (department is null)
                return NotFound();
            return View(ViewName , department);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            //if (id is null)
            //    return BadRequest();
            //var department = _departmentRepository.GetById(id.Value);
            //if (department is null)
            //    return NotFound();
            return Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Department department, [FromRoute] int id)
        {
            if (id != department.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    _departmentRepository.Update(department);
                    return RedirectToAction(nameof(Index));

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }

            return View(department);
        }

        public IActionResult Delete(int? id)
        {
            //if (id is null)
            //    return BadRequest();
            //var department = _departmentRepository.GetById(id.Value);
            //if (department is null)
            //    return NotFound();
            return Details(id, "Delete");
        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Delete(department);
                return RedirectToAction(nameof(Index));
            }

            return View(department);
        }
    }
}
