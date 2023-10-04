namespace ViewModels;

public record class EmployeelistViewModel(IEnumerable<EmployeelistitemViewModel> Employees);

public record class EmployeelistitemViewModel(int Id, string Name, int CommCount);




