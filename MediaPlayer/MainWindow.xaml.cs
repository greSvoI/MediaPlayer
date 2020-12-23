using System;
using System.IO.Packaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaPlayer
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.SizeToContent = SizeToContent.Manual;
			SizeChanged += MainWindow_SizeChanged;
			media.Source = new Uri(@"E:\Zona Downloads\7elf1ess.2015.D.WEB-DL.1080p.mkv");
		}


		private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			
			media.Stretch = Stretch.Fill;
			media.StretchDirection = StretchDirection.Both;
			
		}

	}
}
