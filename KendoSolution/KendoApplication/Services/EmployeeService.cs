using KendoApplication.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace KendoApplication.Services
{
    public class EmployeeService
    {
        public readonly string _ConnectionString;

        public EmployeeService(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public List<Employee> GetData()
        {
            List<Employee> getResult = new List<Employee>();
            Employee employee;
            try
            {
                using (var conn = new SqlConnection(_ConnectionString))
                {
                    conn.Open();
                    using (var command = conn.CreateCommand())
                    {
                        SqlCommand cmd = new SqlCommand("proc_employee");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        SqlDataAdapter daEmployee = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        daEmployee.Fill(ds, "Employee");
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            employee = new Employee();
                            employee.EmpId = Convert.ToInt32(dr[0]);
                            employee.EmpName = dr[1].ToString();
                            employee.EmpSalary = Convert.ToDouble(dr[2]);
                            employee.EmpDOB = Convert.ToDateTime(dr[3]);
                            employee.EmpAddress = dr[4].ToString();
                            employee.EmpStatus = dr[5].ToString();
                            getResult.Add(employee);
                        }
                    }
                }
            }
            catch (Exception SqlException)
            {
                throw SqlException;
            }
            return getResult;
        }
    }
}
