using MarketWorkBd.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Server
{
    public class Server : IDisposable
    {
        TcpListener server;

        public void Dispose()
        {
            if(server != null)
            {
                server.Stop();
                Console.WriteLine("вызван метод стопа.");
            }
        }

        public Server(int port)
        {

            server = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            server.Start();
        }

        public void startServerLoop()
        {
            try
            {
                while (true)
                {
                    MyLogger.getMyLoggerInstance().info("Ожидание подключений...");
                    Console.WriteLine("Ожидание подключений... ");
                    // Почти все время висим здесь на блокирующем вызове Listener.AcceptTcpClient(),
                    // ждем соединения
                    using (TcpClient client = server.AcceptTcpClient())
                    {
                        // принимаем соединение, передаем данные
                        Console.WriteLine("Подключен клиент. Выполнение запроса...");
                        MyLogger.getMyLoggerInstance().info("Подключен клиент. Выполнение запроса...");

                        // получаем сетевой поток для чтения и записи
                        NetworkStream stream = client.GetStream();


                        // сообщение для отправки клиенту
                        string response = "Привет мир";
                        // преобразуем сообщение в массив байтов
                        byte[] data = Encoding.UTF8.GetBytes(response);

                        // отправка сообщения
                        stream.Write(data, 0, data.Length);
                        Console.WriteLine("Отправлено сообщение: {0}", response);
                        MyLogger.getMyLoggerInstance().info("Отправлено сообщение: {0}", response);
                        // закрываем поток
                        stream.Close();
                        // закрываем подключение
                        client.Close();
                    }
                }
            }
            catch (System.Net.Sockets.SocketException) {
                Console.WriteLine("Получено исключение для сокетов.");
                MyLogger.getMyLoggerInstance().warning("Получено исключение System.Net.Sockets.SocketException. Сервер остановлен.");
            }
            // При вызове из другого потока Listener.Stop(), возникае исключение WSACancelBlockingCall
            // Ловим это исключение, выходим из цикла и завершаем поток.
        }

    }
}
