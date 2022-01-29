using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.SQL_App
{
	public partial class Form1 : Form
	{
		Button m_LoadButton;
		DataGridView m_GiftsGrid;

		public Form1()
		{
			InitializeComponent();

			// размер формы при загрузке
			this.Size = new Size(520,400);

			// свойства кнопки
			m_LoadButton = new Button();
			m_LoadButton.Location = new Point(10, 10);
			m_LoadButton.Text = "Load/Загрузка";
			m_LoadButton.AutoSize = true;
			

			// свойства Grid
			m_GiftsGrid = new DataGridView();
			m_GiftsGrid.Location = new Point(10, 50);
			m_GiftsGrid.Size = new Size(480, 250);

			// добавляем элементы управления к вышестоящим ЭУ
			this.Controls.Add(m_LoadButton);
			this.Controls.Add(m_GiftsGrid);

			m_LoadButton.Click += new EventHandler(OnLoadData);
		
		}

		public void OnLoadData(Object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			ds.ReadXml("GiftsDataSet.xml");
			m_GiftsGrid.DataSource = ds.Tables[0];
		}
	}
}
