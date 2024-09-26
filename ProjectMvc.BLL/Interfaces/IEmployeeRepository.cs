﻿using ProjectMvc.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMvc.BLL.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee>GetAll();
        Employee GetById(int id);
        int Add(Employee employee);
        int Update(Employee employee);
        int Delete(Employee employee);
    }
}