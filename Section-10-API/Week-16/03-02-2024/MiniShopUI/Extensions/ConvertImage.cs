namespace MiniShop.MVC.Extensions
{
    public static class ConvertImage 
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            //extension için genişleteceğimiz class'ı this ile belirtiyoruz. Yazılacak class da metot da static olmalı.
            //her bir parçaya buffer deniyor, 16 kb'lık parçalar halinde gönderim tercih ediliyor.
            byte[] buffer = new byte[16 * 1024];
            using(MemoryStream ms = new MemoryStream()) 
            {
                int read;
                while((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
            
        }
    }
}
