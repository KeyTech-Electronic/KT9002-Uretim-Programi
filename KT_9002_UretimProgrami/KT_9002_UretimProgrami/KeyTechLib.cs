using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;

public class KeyTechLib : IDisposable
{
    private const int DefaultSemaphoreTimeout = 1000;
    private const int DefaultCommTimeout = 500;

    private readonly string ComPort;
    private readonly int BaudRate;
    public SerialPort mSerial;

    public KeyTechLib(string _ComPort, int _BaudRate)
    {
        if (string.IsNullOrWhiteSpace(_ComPort))
            throw new ArgumentNullException(nameof(_ComPort), "COM port adı boş olamaz.");

        if (_BaudRate <= 0)
            throw new ArgumentOutOfRangeException(nameof(_BaudRate), "Baud rate pozitif bir değer olmalıdır.");

        ComPort = _ComPort;
        BaudRate = _BaudRate;
    }

    public bool OpenConnection()
    {
        try
        {
            // Eğer bağlantı zaten açık ise mesaj ver ve işlemi sonlandır
            if (mSerial != null && mSerial.IsOpen)
            {
                Console.WriteLine("Bağlantı zaten açık.");
                return true;
            }

            // SerialPort nesnesini oluştur
            mSerial = new SerialPort(ComPort, BaudRate, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None,
                ReadTimeout = DefaultCommTimeout,
                WriteTimeout = DefaultCommTimeout
            };

            // Portu aç
            mSerial.Open();
            Console.WriteLine($"Port {ComPort} başarıyla açıldı.");
            /*
            // Bağlantıyı test et
            if (!TestConnection())
            {
                Console.WriteLine("Bağlantı testi başarısız.");
                CloseConnection();
                return false;
            }
            */
            Console.WriteLine("Bağlantı testi başarılı.");
            return true;
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Yetki hatası: Port başka bir uygulama tarafından kullanılıyor. {ex.Message}");
            return false;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Giriş/Çıkış hatası: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bağlantı açılırken beklenmeyen hata: {ex.Message}");
            return false;
        }
    }

    private bool TestConnection()
    {
        try
        {
            Console.WriteLine("Bağlantı testi başlatılıyor...");
            mSerial.WriteLine("OK");
            string response = mSerial.ReadLine();
            Console.WriteLine($"Gelen yanıt: {response}");
            return response.Trim().Equals("OK", StringComparison.OrdinalIgnoreCase);
        }
        catch (TimeoutException ex)
        {
            Console.WriteLine($"Bağlantı testi zaman aşımına uğradı: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bağlantı testi sırasında hata: {ex.Message}");
            return false;
        }
    }

    public bool CloseConnection()
    {
        try
        {
            if (mSerial != null && mSerial.IsOpen)
            {
                mSerial.Close();
                Console.WriteLine($"Port {ComPort} başarıyla kapatıldı.");
            }
            return true;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Port kapatılırken giriş/çıkış hatası: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Port kapatılırken beklenmeyen hata: {ex.Message}");
            return false;
        }
    }

    public static List<string> LoadSerialPortNames()
    {
        try
        {
            var portNames = SerialPort.GetPortNames().ToList();
            Console.WriteLine("Mevcut portlar: " + string.Join(", ", portNames));
            return portNames;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Port isimleri alınırken hata: {ex.Message}");
            return new List<string>();
        }
    }

    public void Dispose()
    {
        if (mSerial != null)
        {
            if (mSerial.IsOpen)
            {
                Console.WriteLine($"Port {ComPort} kapatılıyor...");
                mSerial.Close();
            }
            mSerial.Dispose();
        }
    }
}
