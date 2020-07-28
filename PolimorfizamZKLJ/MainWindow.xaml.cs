using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolimorfizamZKLJ
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Kvadrat k = new Kvadrat();
			k.a = 5;
			MessageBox.Show(k.Povrsina().ToString());

			Pravougaonik pg = new Pravougaonik();
			pg.a = 5;
			pg.b = 2;

			MessageBox.Show(pg.Povrsina().ToString());

			List<Figura> pgo = new List<Figura>();
			pgo.Add(pg);
			pgo.Add(k);

			Krug kj = new Krug();
			pgo.Add(kj);
			
			foreach (Figura pp in pgo)
				MessageBox.Show(pp.Povrsina().ToString());
			
		}
	}

	public abstract class Figura
	{
		//public abstract int x { get; set; }

		public abstract decimal Povrsina();
		
	}

	public class Kvadrat : Pravougaonik
	{
		public override decimal Povrsina() => a * a;
		public override decimal Obim() => 4*a;
	}

	public class Pravougaonik : Figura
	{
		public decimal a;
		public decimal b;

// public override int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public override  decimal Povrsina() => a * b;
		public virtual decimal Obim() => 2*a+2*b;
	}

	public class Krug : Figura
	{
		public decimal poluprecnik;

		public override decimal Povrsina() => poluprecnik * poluprecnik * (decimal)Math.PI;
		public decimal Obim() => 2 * poluprecnik * (decimal)Math.PI;
	}
}
