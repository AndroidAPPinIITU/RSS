using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailPageItem : ContentPage
	{
		public MasterDetailPageItem ()
		{
			InitializeComponent ();
		}

        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}