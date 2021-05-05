using MarketWorkBd.Loggers;
using MarketWorkBd.Models;
using NLog.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWorkBd.Server
{
    [ThreadSafe]
    public class ServerExecutor
    {
        private IProductsrepository repo = null;

        /// <summary>
        /// Объект для синхронизации разных потоков для создание самого объекта
        /// </summary>
        private static object syncMyLogger = new object();

        private IProductsrepository getRepo()
        {
            if (repo == null)
            {
                lock (syncMyLogger)
                {
                    if (repo == null)
                    {
                        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\С#\MyWork\DatabaseWorks.mdf;Integrated Security=True";
                        repo = new ProductsRepository(connectionString);
                    }
                }
            }
            return repo;
        }
        /// <summary>
        /// Парсит и выполняет запросы от сервера
        /// </summary>
        /// <param name="message">Запрос в виде строки</param>
        public bool execute(string message)
        {
            string[] words = message.Trim().Split(' ');
            if (words.Length == 0)
            {
                MyLogger.getMyLoggerInstance().error("Пустой запрос.");
                return false;
            }
            switch (words[0])
            {
                case "delete":
                    MyLogger.getMyLoggerInstance().info("Запрос удаляния: " + message);
                    if (words.Length >= 3)
                    {
                        return delete(words[1], words[2]);
                    }
                    else
                    {
                        MyLogger.getMyLoggerInstance().info("Неправильный запрос удаления." + message);
                        return false;
                    }

                default:
                    return false;
            } 
        }

        /// <summary>
        /// Удаление из базы данных сущностей
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        private bool delete(string name, string price)
        {
            List<Entity> entities = getRepo().GetUsers();
            List<Entity> deleteEntities = entities.AsEnumerable().Where(x => x.Name == name && x.Price == price).ToList();
            if(deleteEntities.Count > 1) 
                MyLogger.getMyLoggerInstance().error("Для удаления много entities. Удаляю все.");
            if (deleteEntities.Count == 0)
            {
                MyLogger.getMyLoggerInstance().error("Не найдено ни одной entities для удаления.");
                return false;
            }
            foreach(Entity entity in deleteEntities)
            {
                getRepo().Delete(entity.Id);
            }
            return true;
        }
    }
}
