using Microsoft.AspNetCore.Mvc;
//using ViewModels.Services;


namespace ViewModels.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeService _employeeService = new();
        
        public async Task<IActionResult> IndexAsync()
        {
            //get data from data storage
            var employees = await _employeeService.ReadAllAsync();
            //create view model based sa data
            var viewModel = new EmployeelistViewModel(Employees: employees.Select(employee => new EmployeelistitemViewModel(Id: employee.Id, Name: employee.Name, CommCount: employee.Comm.Count())));
            return View(viewModel);
        }


    }



}
