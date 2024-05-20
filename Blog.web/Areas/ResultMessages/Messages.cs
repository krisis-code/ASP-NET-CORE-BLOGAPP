namespace Blog.web.Areas.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName}  isimli kategori başarıyla silinmiştir.";
            }
        }

        public static class User
        {
            public static string Add(string Users)
            {
                return $"{Users} isimli Kullanıcı başarıyla eklenmiştir.";
            }

            public static string Update(string Users)
            {
                return $"{Users} isimli kullanıcı başarıyla güncellenmiştir.";
            }

            public static string Delete(string Users)
            {
                return $"{Users}  isimli kullanıcı başarıyla silinmiştir.";
            }
        }
    }
}
