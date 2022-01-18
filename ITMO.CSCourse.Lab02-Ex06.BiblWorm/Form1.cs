using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab02_Ex06.BiblWorm
{

	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{
		
		}
		
		
		public string Author // автор
		{
			get { return textBox1.Text; }
			set { textBox1.Text = value; }
		}
		public string Title // Название
		{
			get { return textBox2.Text; }
			set { textBox2.Text = value; }
		}
		public string PublishHouse // Издательство
		{
			get { return textBox3.Text; }
			set { textBox3.Text = value; }
		}
		public int Page // Количество страниц
		{
			get { return (int)numericUpDown1.Value; }
			set { numericUpDown1.Value = value; }
		}
		public int Year // Год издания
		{
			get { return (int)numericUpDown2.Value; }
			set { numericUpDown2.Value = value; }
		}
		public int InvNumber // Инвентарный номер
		{
			get { return (int)numericUpDown3.Value; }
			set { numericUpDown3.Value = value; }
		}
		public bool Existence // Наличие
		{
			get { return checkBox1.Checked; }
			set { checkBox1.Checked = value; }
		}
		public bool SortInvNumber // Сортировка по инвентарному номеру
		{
			get { return checkBox2.Checked; }
			set { checkBox2.Checked = value; }
		}
		public bool ReturnTime // Возвращение в срок
		{
			get { return checkBox3.Checked; }
			set { checkBox3.Checked = value; }
		}
		public int PeriodUse // Инвентарный номер
		{
			get { return (int)numericUpDown4.Value; }
			set { numericUpDown4.Value = value; }
		}

		// добавляем Properties для Magazine

		public string title // Название
		{
			get { return textBoxTitle.Text; }
			set { textBoxTitle.Text = value; }
		}
		public string volume // Том
		{
			get { return textBoxVolume.Text; }
			set { textBoxVolume.Text = value; }
		}
		public int number // Номер
		{
			get { return (int)numericUpDownNumber.Value; }
			set { numericUpDownNumber.Value = value; }
		}
		public int year // Номер
		{
			get { return (int)numericUpDownYear.Value; }
			set { numericUpDownYear.Value = value; }
		}

		List<Item> its = new List<Item>();

		private void button1_Click(object sender, EventArgs e)
		{
			Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
			if (ReturnTime) b.ReturnSrok(); // Далее в этом обработчике реализуйте проверку возврата книги в срок
			b.PriceBook(PeriodUse);         // И расчет стоимости с учетом срока пользования книгой:
			its.Add(b);                     // Теперь добавьте книгу в список
			/// В конце обработчика очистите поля ввода для новой информации 
			/// (будьте внимательны, укажите значения, входящие в допустимый 
			/// диапазон, который вы настраивали ранее):
			Author = Title = PublishHouse = "";
			Page = InvNumber = PeriodUse = 0;
			Year = 2000;
			Existence = ReturnTime = false;
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			// В обработчике сначала проверьте состояние флажка сортировки и в случае его установки отсортируйте список
			if (SortInvNumber) its.Sort();

			// Для вывода информации создайте строку класса StringBuilder и с помощью цикла
			// постройте строку и информацией о единице хранения
			StringBuilder sb = new StringBuilder();
			foreach (Item item in its)
			{
				sb.Append("\n" + item.ToString());
			}

			// После построения строки выведете ее в элемент richTextBox1:
			richTextBox1.Text = sb.ToString();
		}

		private void buttonAddMagazine_Click(object sender, EventArgs e)
		{
			Magazine b = new Magazine(title, year, volume, number, InvNumber, Existence);
			//if (ReturnTime) b.Return(); // Далее в этом обработчике реализуйте проверку возврата книги в срок
			//b.PriceBook(PeriodUse);         // И расчет стоимости с учетом срока пользования книгой:
			its.Add(b);                     // Теперь добавьте книгу в список
			/// В конце обработчика очистите поля ввода для новой информации 
			/// (будьте внимательны, укажите значения, входящие в допустимый 
			/// диапазон, который вы настраивали ранее):
			title = volume = "";
			InvNumber = number = 0;
			year = 2000;
			Existence = ReturnTime = false;
		}

		private void labelNumber_Click(object sender, EventArgs e)
		{

		}
	}
}
