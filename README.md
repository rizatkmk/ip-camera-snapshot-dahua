# ip-camera-snapshot-dahua
Bu örnek uygulama, Dahua marka IP kameraların CGI arayüzü üzerinden anlık görüntü alınmasını sağlar.

# Dahua IP Kamera Görüntü Alma

Bu örnek uygulama, Dahua marka IP kameraların CGI arayüzü üzerinden anlık görüntü alınmasını sağlar.

## Gereksinimler

- .NET 6.0 veya üzeri
- Kamera IP'si
- Kamera kullanıcı adı ve şifresi

## Kullanım

1. `Program.cs` dosyasındaki `cameraIp`, `username` ve `password` alanlarını kendi kamera bilgilerinize göre düzenleyin.
2. Konsol uygulamasını çalıştırın.
3. `dahua_snapshot.jpg` adında bir dosya oluşturulacaktır.

## Not

Bu örnek sadece anlık görüntü alma (snapshot) içindir. RTSP veya video stream için farklı yollar izlenmelidir.
