using Minerva.UI.Controls;
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

namespace Minerva.UI.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MnvNavigationWindows
    {
        public MainWindow()
        {
            InitializeComponent();
            //CreateMenu();
        }

        private void CreateMenu()
        {
            // 1. Create global navigator
            //MainFrame.Source = _NavigationFrame;
            var menu1 = new NavigationMenuItem()
            {
                Content = "대시보드",
                //NormalSource = "/Kaiser.UI;component/Resources/Icons/Menu/home_icon.png",
                //ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/home_activated_icon.png",
                IsChecked = true
            };

            var menu2 = new NavigationMenuItem()
            {
                Content = "대시보드2",
                //NormalSource = "/Kaiser.UI;component/Resources/Icons/Menu/home_icon.png",
                //ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/home_activated_icon.png",
            };

            NavigationBar.MenuItems = new Controls.Menus.NavigationMenuCollection
            {
                //menu1,
                //menu2
            };

            // 2. Add Menus

            //NavigationBar.MenuItems = new List<KaiserMenuItem>
            //{
            //    new KaiserMenuItem()
            //    {
            //        Content         = "대시보드",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/home_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/home_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "대시보드",
            //                Navigator = _NavigationFrame,
            //                Page      = new DashBoardPage(_logger)
            //            },
            //            new KaiserSubMenuItem()
            //            {
            //                Title = "데이터 컬렉터",
            //                Navigator = _NavigationFrame,
            //                Page = new CollectorPage(_logger)
            //            }
            //        },
            //        IsChecked = true
            //    },
            //    new KaiserMenuItem()
            //    {
            //        Content         = "입찰관리",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/management_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/management_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "입찰관리",
            //                Navigator = _NavigationFrame,
            //                Page      = new CampaignManagingPage(_logger)
            //            },
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "즐겨찾기",
            //                Navigator = _NavigationFrame,
            //                Page      = new FavoriteGroupPage()
            //            }
            //        }
            //    },
            //    new KaiserMenuItem()
            //    {
            //        Content         = "키워드 동기화",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/keword_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/keword_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "동기화 관리",
            //                Navigator = _NavigationFrame,
            //                Page      = new CampaignSyncPage(_logger)
            //            }
            //        }
            //    },
            //    new KaiserMenuItem()
            //    {
            //        Content         = "보고서 관리",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/report_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/report_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "통합 보고서 생성",
            //                Navigator = _NavigationFrame,
            //                Page      = new ReportRegisterPage()
            //            },
            //            new KaiserSubMenuItem()
            //            {
            //                Title = "보고서 관리"
            //            }
            //        }
            //    },
            //    new KaiserMenuItem()
            //    {
            //        Content         = "설정",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/setting_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/setting_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title     = "설정",
            //                Navigator = _NavigationFrame,
            //                PageUri   = new Uri("/Kaiser.Client;component/View/Pages/ucDashBoard.xaml", UriKind.Relative)
            //            }
            //        }
            //    },
            //    new KaiserMenuItem()
            //    {
            //        Content         = "내정보",
            //        NormalSource    = "/Kaiser.UI;component/Resources/Icons/Menu/myinfo_icon.png",
            //        ActivatedSource = "/Kaiser.UI;component/Resources/Icons/MenuActivated/myinfo_activated_icon.png",
            //        SubMenuItems    = new List<KaiserSubMenuItem>
            //        {
            //            new KaiserSubMenuItem()
            //            {
            //                Title = "내정보"
            //            }
            //        }
            //    }
            //};
        }
    }
}
