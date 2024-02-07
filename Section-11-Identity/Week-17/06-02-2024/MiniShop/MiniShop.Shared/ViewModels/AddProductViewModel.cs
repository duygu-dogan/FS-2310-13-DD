using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class AddProductViewModel
    {
        [JsonPropertyName("Name")]
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [MinLength(5, ErrorMessage = "{0} alanına uzunluğu {1} karakterden az değer girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alanına uzunluğu {1} karakterden fazla değer girilemez.")]
        public string Name { get; set; }


        [DisplayName("Ürün Özellikleri")]
        [JsonPropertyName("Properties")]
        //[Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        //[MinLength(25, ErrorMessage = "{0} alanına uzunluğu {1} karakterden az değer girilemez.")]
        public string Properties { get; set; }


        [JsonPropertyName("Price")]
        [DisplayName("Fiyat")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        public decimal? Price { get; set; }


        [JsonPropertyName("ImageUrl")]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; } = "";


        [JsonPropertyName("Url")]
        public string Url { get; set; }


        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif Ürün")]
        public bool IsActive { get; set; }


        [JsonPropertyName("IsHome")]
        [DisplayName("Anasayfa Ürünü")]
        public bool IsHome { get; set; }


        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; } = new List<int>();


        [JsonPropertyName("Categories")]
        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }
    }
}
