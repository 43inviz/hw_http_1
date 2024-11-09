

using System.Net;

namespace HW_http
{
    //internal class Program
    //{
    //    private static HttpClient _httpClient = new HttpClient();
    //    static void Main(string[] args)
    //    {
    //        string inmgUrl = "https://upload.wikimedia.org/wikipedia/en/f/f4/Hotline_Miami_cover.png";

    //        WebClient client = new WebClient();

    //        using (Stream stream = client.OpenRead(inmgUrl))
    //        {
    //            using (FileStream fileStream = File.Create(@"C:\Users\Max\Desktop\img.jpg"))
    //            {
    //                stream.CopyTo(fileStream);
    //            }
    //        }
    //    }
    //}

    internal class Program
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            string imgUrl = "https://upload.wikimedia.org/wikipedia/en/f/f4/Hotline_Miami_cover.png";
            string filePath = @"C:\\Users\\User\\Desktop\\img.jpg";

            try
            {
                // Получаем данные изображения как байты
                byte[] imageBytes = await _httpClient.GetByteArrayAsync(imgUrl);

                // Сохраняем байты в файл
                await File.WriteAllBytesAsync(filePath, imageBytes);

                Console.WriteLine("Изображение успешно загружено и сохранено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке изображения: {ex.Message}");
            }
        }
    }
}

///"C:\Users\User\Desktop\img.jpg"
