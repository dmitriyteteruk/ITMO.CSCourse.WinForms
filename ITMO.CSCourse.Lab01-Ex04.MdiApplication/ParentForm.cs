// в этом коде есть Lab01-04 и Lab02-03.
// код Lab02-03 дополнительно прокоментирован
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab01_Ex04.MdiApplication
{
	public partial class ParentForm : Form
	{
		public ParentForm()
		{
			InitializeComponent();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}

		private void WindowTileMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}

		private void NewMenuItem_Click(object sender, EventArgs e)
		{
			ChildForm newChild = new ChildForm();
			newChild.MdiParent = this;
			newChild.Show();
			newChild.Text = newChild.Text + " " + ++openDocuments; // добавляем номер документа новому окну
		}

		private int openDocuments = 0;

		private void ParentForm_Load(object sender, EventArgs e)
		{

		}

		// ниже код из Lab02-Ex03
		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			switch (e.ClickedItem.Tag.ToString())
			{
				case "NewDoc":
					ChildForm newChild = new ChildForm();
					newChild.MdiParent = this;
					newChild.Show();
					newChild.Text = newChild.Text + " " + ++openDocuments;
					break;
					case "Cascade":
					this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
					break;
					case "Title":
					this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
					break;
			}
		}
	}
}
