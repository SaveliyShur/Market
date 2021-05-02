using System;

namespace MarketWorkBd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("Завершение приложения.");
            if (serverThread != null && serverThread.IsAlive)
            {
                try
                {
                    server.Dispose();
                    serverThread.Join();
                    serverThread.Interrupt();
                }
                catch
                {
                    //ignored
                }
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.id_update = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.mistake_label_update = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateTextboxPrice = new System.Windows.Forms.TextBox();
            this.updateTextboxName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mistake_lable_delete = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteTextboxID = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mistake_label = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertTextBoxPrice = new System.Windows.Forms.TextBox();
            this.insertTextBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(679, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStrip});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // updateToolStrip
            // 
            this.updateToolStrip.Name = "updateToolStrip";
            this.updateToolStrip.Size = new System.Drawing.Size(161, 26);
            this.updateToolStrip.Text = "Обновить";
            this.updateToolStrip.Click += new System.EventHandler(this.updateToolStrip_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 374);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxSelect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(671, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.Location = new System.Drawing.Point(2, 2);
            this.listBoxSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(667, 344);
            this.listBoxSelect.TabIndex = 0;
            this.listBoxSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxSelect_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.id_update);
            this.tabPage2.Controls.Add(this.textBoxIdUpdate);
            this.tabPage2.Controls.Add(this.mistake_label_update);
            this.tabPage2.Controls.Add(this.updateButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.updateTextboxPrice);
            this.tabPage2.Controls.Add(this.updateTextboxName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(671, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UPDATE";
            // 
            // id_update
            // 
            this.id_update.AutoSize = true;
            this.id_update.Location = new System.Drawing.Point(32, 37);
            this.id_update.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_update.Name = "id_update";
            this.id_update.Size = new System.Drawing.Size(19, 15);
            this.id_update.TabIndex = 12;
            this.id_update.Text = "ID";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Location = new System.Drawing.Point(52, 34);
            this.textBoxIdUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(54, 20);
            this.textBoxIdUpdate.TabIndex = 11;
            // 
            // mistake_label_update
            // 
            this.mistake_label_update.AutoSize = true;
            this.mistake_label_update.BackColor = System.Drawing.Color.Transparent;
            this.mistake_label_update.ForeColor = System.Drawing.Color.Red;
            this.mistake_label_update.Location = new System.Drawing.Point(197, 76);
            this.mistake_label_update.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mistake_label_update.Name = "mistake_label_update";
            this.mistake_label_update.Size = new System.Drawing.Size(41, 15);
            this.mistake_label_update.TabIndex = 10;
            this.mistake_label_update.Text = "label5";
            this.mistake_label_update.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(422, 30);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 27);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Добавить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя продукта";
            // 
            // updateTextboxPrice
            // 
            this.updateTextboxPrice.Location = new System.Drawing.Point(329, 34);
            this.updateTextboxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateTextboxPrice.Name = "updateTextboxPrice";
            this.updateTextboxPrice.Size = new System.Drawing.Size(76, 20);
            this.updateTextboxPrice.TabIndex = 6;
            // 
            // updateTextboxName
            // 
            this.updateTextboxName.Location = new System.Drawing.Point(200, 34);
            this.updateTextboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateTextboxName.Name = "updateTextboxName";
            this.updateTextboxName.Size = new System.Drawing.Size(76, 20);
            this.updateTextboxName.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.mistake_lable_delete);
            this.tabPage3.Controls.Add(this.deleteButton);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.deleteTextboxID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DELETE";
            // 
            // mistake_lable_delete
            // 
            this.mistake_lable_delete.AutoSize = true;
            this.mistake_lable_delete.BackColor = System.Drawing.Color.Transparent;
            this.mistake_lable_delete.ForeColor = System.Drawing.Color.Red;
            this.mistake_lable_delete.Location = new System.Drawing.Point(50, 72);
            this.mistake_lable_delete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mistake_lable_delete.Name = "mistake_lable_delete";
            this.mistake_lable_delete.Size = new System.Drawing.Size(41, 15);
            this.mistake_lable_delete.TabIndex = 15;
            this.mistake_lable_delete.Text = "label5";
            this.mistake_lable_delete.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(153, 24);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 27);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            // 
            // deleteTextboxID
            // 
            this.deleteTextboxID.Location = new System.Drawing.Point(52, 28);
            this.deleteTextboxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteTextboxID.Name = "deleteTextboxID";
            this.deleteTextboxID.Size = new System.Drawing.Size(76, 20);
            this.deleteTextboxID.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.mistake_label);
            this.tabPage4.Controls.Add(this.changeButton);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.insertTextBoxPrice);
            this.tabPage4.Controls.Add(this.insertTextBoxName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(671, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "INSERT";
            // 
            // mistake_label
            // 
            this.mistake_label.AutoSize = true;
            this.mistake_label.BackColor = System.Drawing.Color.White;
            this.mistake_label.ForeColor = System.Drawing.Color.Red;
            this.mistake_label.Location = new System.Drawing.Point(116, 96);
            this.mistake_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mistake_label.Name = "mistake_label";
            this.mistake_label.Size = new System.Drawing.Size(41, 15);
            this.mistake_label.TabIndex = 5;
            this.mistake_label.Text = "label5";
            this.mistake_label.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(418, 27);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(97, 27);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.insert_button_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя продукта";
            // 
            // insertTextBoxPrice
            // 
            this.insertTextBoxPrice.Location = new System.Drawing.Point(326, 31);
            this.insertTextBoxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertTextBoxPrice.Name = "insertTextBoxPrice";
            this.insertTextBoxPrice.Size = new System.Drawing.Size(76, 20);
            this.insertTextBoxPrice.TabIndex = 1;
            // 
            // insertTextBoxName
            // 
            this.insertTextBoxName.Location = new System.Drawing.Point(196, 31);
            this.insertTextBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertTextBoxName.Name = "insertTextBoxName";
            this.insertTextBoxName.Size = new System.Drawing.Size(76, 20);
            this.insertTextBoxName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 426);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "mainWorkForm";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertTextBoxPrice;
        private System.Windows.Forms.TextBox insertTextBoxName;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateTextboxPrice;
        private System.Windows.Forms.TextBox updateTextboxName;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deleteTextboxID;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label mistake_label;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStrip;
        private System.Windows.Forms.Label mistake_label_update;
        private System.Windows.Forms.Label id_update;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label mistake_lable_delete;
    }
}

