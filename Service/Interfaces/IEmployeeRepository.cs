using Domain.Models;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task CreateAsync(CreateEmployeeDto employeeDto);
        public Task UpdateAsync(int id, CreateEmployeeDto employeeDto);
        public Task DeleteAsync(int id);
        public Task<List<Employee>> GetAllAsync();
        public Task<Employee> GetByIdAsync(int id);
    }
}
