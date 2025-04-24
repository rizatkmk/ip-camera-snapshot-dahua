using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string cameraIp = "192.0.2.20"; // Örnek IP
        string username = "admin";
        string password = "admin123";
        string imageUrl = $"http://{cameraIp}/cgi-bin/snapshot.cgi";
        string savePath = "dahua_snapshot.jpg";

        var handler = new HttpClientHandler
        {
            Credentials = new NetworkCredential(username, password)
        };

        using (HttpClient client = new HttpClient(handler))
        {
            try
            {
                Console.WriteLine("Dahua görüntü alınıyor...");
                var response = await client.GetAsync(imageUrl);
                response.EnsureSuccessStatusCode();
                var image = await response.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync(savePath, image);
                Console.WriteLine("Görüntü kaydedildi: " + savePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }
}
