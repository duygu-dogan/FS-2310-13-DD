using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            Db.OpenCn();
            string queryString = @"select 
                                    c.CategoryID as ID,
                                    c.CategoryName as Name,
                                    c.Description as Description
                                from Categories c";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            CategoryViewModel categoryViewModel = null;
            foreach (DataRow categoryRow in dataTable.Rows)
            {
                categoryViewModel = new CategoryViewModel{
                    Id = Convert.ToInt32(categoryRow["ID"]),
                    Name = categoryRow["Name"].ToString(),
                    Description = categoryRow["Description"].ToString()
                };
                categories.Add(categoryViewModel);

                // categories.Add(new CategoryViewModel{
                //     Id=Convert.ToInt32(categoryRow["ID"]),
                //     Name = Convert.ToString(categoryRow["Name"]),
                //     Description=categoryRow["Description"].ToString()
                // });
            }

            return View(categories);
        }

    }
}