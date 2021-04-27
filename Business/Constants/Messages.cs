
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string SuccessAdded = "Ekleme işlemi başarılı";
        public static string ErrorAdded = "Ekleme işlemi hatalı";

        public static string SuccessDeleted = "Silme işlemi başarılı";
        public static string ErrorDeleted = "Silme işlemi başarısız";

        public static string SuccessUpdated = "Güncelleme işlemi başarılı";
        public static string ErrorUpdated = "Güncelleme işlemi başarısız";

        public static string SuccessListed = "Listeleme işlemi başarılı";
        public static string ErrorListed = "Listeleme işlemi başarısız";


        
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime ="Sistem bakımda";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied="Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Hatalı Şifre";

        public static string SuccessfulLogin = "Başarılı girişş";

        public static string UserAlreadyExists = "Kullanıcı zaten var";

        public static string AccessTokenCreated = "Token oluştu";

        public static string UserRegistered = "Kullanıcı Kayıtlı";
    }
}
