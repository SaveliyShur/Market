using MarketWorkBd.Loggers;
using MarketWorkBd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace MarketWorkBd
{
    public partial class Form1 : Form
    {
        IProductsrepository repo = null;
        Thread serverThread = null;
        MarketWorkBd.Server.Server server = null;

        public Form1()
        {
            MyLogger.getMyLoggerInstance().info("Запуск программы.");
            InitializeComponent();
        }

        //Метод загрузки приложения
        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\С#\MyWork\DatabaseWorks.mdf;Integrated Security=True";

            repo = new ProductsRepository(connectionString);

            try
            {
                List<Entity> products =  repo.GetUsers();

                foreach (Entity product in products)
                {
                    listBoxSelect.Items.Add(product.Id + " " + product.Name + " " + product.Price);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            MyLogger.getMyLoggerInstance().info("Запуск сервера для приема сообщений в отдельном потоке.");
            try
            {
                server = new Server.Server();
                serverThread = new Thread(new ThreadStart(server.Listen));
                serverThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }

        private void insert_button_click(object sender, EventArgs e)
        {
            if (mistake_label.Visible)
                mistake_label.Visible = false;
            if (!string.IsNullOrEmpty(insertTextBoxName.Text) && !string.IsNullOrEmpty(insertTextBoxPrice.Text) &&
                !string.IsNullOrWhiteSpace(insertTextBoxPrice.Text) && !string.IsNullOrWhiteSpace(insertTextBoxName.Text) )
            {

                Entity product = new Entity();
                product.Name = insertTextBoxName.Text;
                product.Price = insertTextBoxPrice.Text;

                repo.Create(product);

                insertTextBoxName.Clear();
                insertTextBoxPrice.Clear();
            }
            else
            {
                mistake_label.Visible = true;
                mistake_label.Text = "Поля ввода пустые";
            }
        }

        private void updateToolStrip_Click(object sender, EventArgs e)
        {
            listBoxSelect.Items.Clear();

            try
            {
                List<Entity> products = repo.GetUsers();

                foreach (Entity product in products)
                {
                    listBoxSelect.Items.Add(product.Id + " " + product.Name + " " + product.Price);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private  void updateButton_Click(object sender, EventArgs e)
        {
            if (mistake_label_update.Visible)
                mistake_label_update.Visible = false;
            if (!string.IsNullOrEmpty(updateTextboxName.Text) && !string.IsNullOrWhiteSpace(updateTextboxName.Text) &&
                !string.IsNullOrEmpty(updateTextboxPrice.Text) && !string.IsNullOrWhiteSpace(updateTextboxPrice.Text) &&
                !string.IsNullOrEmpty(textBoxIdUpdate.Text) && !string.IsNullOrWhiteSpace(textBoxIdUpdate.Text))
            {

                Entity entity = new Entity(int.Parse(textBoxIdUpdate.Text), updateTextboxName.Text, updateTextboxPrice.Text);

                repo.Update(entity);

                updateTextboxName.Clear();
                updateTextboxPrice.Clear();
                textBoxIdUpdate.Clear();
            }
            else
            {
                mistake_label_update.Visible = true;
                mistake_label_update.Text = "Поля ввода пустые";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (mistake_lable_delete.Visible)
                mistake_lable_delete.Visible = false;
            if (!string.IsNullOrEmpty(deleteTextboxID.Text) && !string.IsNullOrWhiteSpace(deleteTextboxID.Text))
            {
                repo.Delete(int.Parse(deleteTextboxID.Text));

                deleteTextboxID.Clear();
            }
            else
            {
                mistake_lable_delete.Visible = true;
                mistake_lable_delete.Text = "Поля ввода пустые";
            }
        }

        private void listBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelect.Items.Clear();

            try
            {
                List<Entity> products = repo.GetUsers();

                foreach (Entity product in products)
                {
                    listBoxSelect.Items.Add(product.Id + " " + product.Name + " " + product.Price);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
