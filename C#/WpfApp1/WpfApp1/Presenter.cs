using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	class Presenter
	{
		WorkModul instanceModel;
		MainWindow mainWindow;

		public Presenter (MainWindow mainWindow)
		{
			this.mainWindow = mainWindow;
			this.instanceModel = new WorkModul();
			this.mainWindow.FirstEvent += MainWindow_FirstEvent; // Присоединение обработчиков событий. (Подписка на событие)
		}

		private void MainWindow_FirstEvent(object sender, EventArgs e) // Метод обработчик события.
		{
			this.mainWindow.TextBox1.Text = instanceModel.ModText(mainWindow.TextBox1.Text); 
		}
	}
}
