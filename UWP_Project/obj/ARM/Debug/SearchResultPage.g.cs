﻿#pragma checksum "C:\Labs\App\UWP_Project\UWP_Project\SearchResultPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C81237B555D3EFF869CBA5E2541781AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_Project
{
    partial class SearchResultPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class SearchResultPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISearchResultPage_Bindings
        {
            private global::UWP_Project.SearchResultPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj17;

            private SearchResultPage_obj1_BindingsTracking bindingsTracking;

            public SearchResultPage_obj1_Bindings()
            {
                this.bindingsTracking = new SearchResultPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // ISearchResultPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // SearchResultPage_obj1_Bindings

            public void SetDataRoot(global::UWP_Project.SearchResultPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UWP_Project.SearchResultPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_items(obj.items, phase);
                    }
                }
            }
            private void Update_items(global::System.Collections.Generic.List<global::UWP_Project.services.Item> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj17, obj, null);
                }
            }

            private class SearchResultPage_obj1_BindingsTracking
            {
                global::System.WeakReference<SearchResultPage_obj1_Bindings> WeakRefToBindingObj; 

                public SearchResultPage_obj1_BindingsTracking(SearchResultPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<SearchResultPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.StartState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.VisualState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.spHeader = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.spHistory = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.spFoot = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.btnToHomePage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 133 "..\..\..\SearchResultPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnToHomePage).Click += this.btnToHomePage_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btnToSetPage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 136 "..\..\..\SearchResultPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnToSetPage).Click += this.btnToSetPage_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.scrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 11:
                {
                    this.spTotal = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12:
                {
                    this.spTotalValue = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13:
                {
                    this.resultEURO = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.resultUSD = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.resultGBP = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.resultRMB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.grvSelectItem = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 18:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element18 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 78 "..\..\..\SearchResultPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element18).Tapped += this.TextBlock_Tapped;
                    #line default
                }
                break;
            case 19:
                {
                    this.tblTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SearchResultPage_obj1_Bindings bindings = new SearchResultPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

