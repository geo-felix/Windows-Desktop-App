using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;

using Windows.UI.ApplicationSettings;
using Windows.UI.Core;
using muxc = Microsoft.UI.Xaml.Controls;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using WinRT.Interop;
using System.Runtime.InteropServices;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CSfieldSync
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "CSfieldSync";
        }
        //private double NavViewCompactModeThresholdWidth
        //{
        //    get
        //    {
        //        return NavView.CompactModeThresholdWidth;
        //    }
        //}

        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        // List of ValueTuple holding the Navigation Tag and the relative Navigation Page
        private readonly List<(string Tag, Type Page)> _pages = new ()
        {
            ("sync", typeof(SyncPage)),
            ("syncset", typeof(SyncSetPage)),
        };

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // You can also add items in code.
           // NavView.MenuItems.Add(new muxc.NavigationViewItemSeparator());
            //NavView.MenuItems.Add(new muxc.NavigationViewItem
            //{
            //    Content = "My content",
            //    //Icon = new SymbolIcon((Symbol)0xF1AD),
            //    Tag = "content"
            //});
            _pages.Add(("Sync", typeof(SyncPage)));
            

            // Add handler for ContentFrame navigation.


            // NavView doesn't load any page by default, so load home page.
            NavView.SelectedItem = NavView.MenuItems[0];
            // If navigation occurs on SelectionChanged, this isn't needed.
            // Because we use ItemInvoked to navigate, we need to call Navigate
            // here to load the home page.
            NavView_Navigate("sync");

            // Listen to the window directly so the app responds
            // to accelerator keys regardless of which element has focus.
            //Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated +=
                //CoreDispatcher_AcceleratorKeyActivated;

            //Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;

            //SystemNavigationManager.GetForCurrentView().BackRequested += System_BackRequested;
        }

        private void NavView_ItemInvoked(muxc.NavigationView sender,
                                         muxc.NavigationViewItemInvokedEventArgs args)
        {
            //if (args.IsSettingsInvoked == true)
            //{
            //    NavView_Navigate("setting");
            //}
            //else
            if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                NavView_Navigate(navItemTag);
            }
        }

    

        private void NavView_Navigate(
            string navItemTag
            //Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo transitionInfo
            )
        {
            Type _page = null;
            if (navItemTag == "syncset")
            {
                _page = typeof(SyncSetPage);
            }
            else
            {
                var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
                _page = item.Page;
            }
            // Get the page type before navigation so you can prevent duplicate
            // entries in the backstack.
            var preNavPageType = ContentFrame.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
                ContentFrame.Navigate(_page, null, new EntranceNavigationTransitionInfo());
            }
        }
    }
}
