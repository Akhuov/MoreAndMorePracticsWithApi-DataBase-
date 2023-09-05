using Domain.Models;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IStaffRepository
    {
        public Task CreateAsync(CreateStaffDto staffDto);
        public Task UpdateAsync(int id, CreateStaffDto staffDto);
        public Task DeleteAsync(int id);
        public Task<List<Staff>> GetAllAsync();
        public Task<Staff> GetByIdAsync(int id);
    }
}
