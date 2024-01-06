using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*
    string connectionString = @"Server=DD_PC\SQLEXPRESS;Database=Northwind;user=duygudgn;password=1234;TrustServerCertificate=true";
*/
namespace Proje06_MvcWithSql.Dal
{
    public static class Db
    {
        public static SqlConnection connection = CreateConnection();
        private static SqlConnection CreateConnection(){
            string connectionString = @"Server=KADIRINC\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true";
            return new SqlConnection(connectionString);   
        }
        public static void OpenCn(){
            try
            {
                if(connection.State==ConnectionState.Closed){
                    connection.Open();
                }
                Console.WriteLine("Bağlantı başarıyla kuruldu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CloseCn(){
            try
            {
                if(connection.State==ConnectionState.Open)
                connection.Close();
                Console.WriteLine("Bağlantı kapatıldı...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}