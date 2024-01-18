using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ResponseDTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }
        public bool IsSucceeded { get; set; }

        //factory design pattern

        /// <summary>
        /// Bu metot yapılan işlemin başarılı olduğu durumlarda, başarılı bir cevapla birlikte üretilen datayı ve statuscode'u döndürmek için kullanır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200, 201 vb.)</param>
        /// <returns>Response<typeparamref name="T"/></returns>

        public static Response<T> Success(T data, int statusCode) 
        { 
            return new Response<T>
            { Data = data, StatusCode = statusCode,  IsSucceeded=true };
        }
        /// <summary>
        /// İşlemin başarılı olduğunu ifade eden bir statuscode döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod.(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(int statusCode) 
        { 
            return new Response<T>
            {
                Data = default(T), 
                StatusCode = statusCode,
                IsSucceeded = true 
            };
        }
        /// <summary>
        /// Bu metot geriye başarısız bir cevap olarak içinde birden çok hata olan hata listesini döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Hata listesi</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod.(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T> 
            { StatusCode = statusCode, 
              IsSucceeded = false, 
              Errors=errors };
        }
        /// <summary>
        /// Bu metot geriye başarısız bir cevap olarak içinde tek hata olan hata listesini döndürmek için kullanılır.
        /// </summary>
        /// <param name="error">Hata metni</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod.(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode) 
        {
            return new Response<T>
            { StatusCode = statusCode,
                IsSucceeded = false,
                Errors = new List<string> { error }
            };
        }

        
    }
}
