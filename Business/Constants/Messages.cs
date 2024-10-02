using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string RentalAdded = "Araç Kiralandı";
        public static string RentalError = "Araç Kiralanamadı";
        public static string CarDetailsListed = "Araba detayları başarıyla getirildi.";

        public static string FileUploadError = "Dosya yüklenirken bir hata oluştu.";
        public static string InvalidFile = "Geçersiz dosya.";
        public static string ImageAdded = "Resim başarıyla eklendi.";
        public static string ImageDeleted = "Resim başarıyla silindi.";
        public static string ImageUpdated = "Resim başarıyla güncellendi.";
        public static string CarImageLimitReached = "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarDetailsNotFound = "Araba detayları bulunamadı.";
    }
}
