using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace STO
{
	public partial class MainPage : MasterDetailPage
	{

        public List<MasterDetailPageItem> menuList { get; set; }

        public MainPage()
		{
			InitializeComponent();

            menuList = new List<MasterDetailPageItem>();


            var page1 = new MasterDetailPageItem() { Title = "Топ СТО", TargetType = typeof(Events) };
            var page2 = new MasterDetailPageItem() { Title = "Мой профиль", TargetType = typeof(Profile) };
            //var page3 = new MasterDetailPageItem() { Title = "События", Icon = "calendar.png", TargetType = typeof(Events) };
            //var page4 = new MasterDetailPageItem() { Title = "Настройки", Icon = "settings.png", TargetType = typeof(Setting) };
            //var page5 = new MasterDetailPageItem() { Title = "О программе", Icon = "aboutprogram.png", TargetType = typeof(About) };
            var page6 = new MasterDetailPageItem() { Title = "Войти",  TargetType = typeof(Reg) };
            var page8 = new MasterDetailPageItem() { Title = "Выйти",  TargetType = typeof(Events) };



            menuList.Add(page1);
            menuList.Add(page2);
            //menuList.Add(page3);
            //menuList.Add(page4);
            //menuList.Add(page5);
            menuList.Add(page6);

            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Events)));


            Detail = new NavigationPage(new Events())
            {
                // Green bar color
                //BarBackgroundColor = Color.FromHex("#67B437")
            };
        }


        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterDetailPageItem)e.SelectedItem;
            //item.BackgroundColor = Color.Pink;
            Type page = item.TargetType;



            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
