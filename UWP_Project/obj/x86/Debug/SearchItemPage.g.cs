﻿#pragma checksum "C:\Labs\App\UWP_Project\UWP_Project\SearchItemPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CDF44F8C2EE6B88092972CA0FB0866C"
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
    partial class SearchItemPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.StartState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.VisualState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.spHeader = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.spSearch = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.spFoot = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    this.btnToHomePage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 112 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnToHomePage).Click += this.btnToHomePage_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btnToSetPage = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    this.spBody = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11:
                {
                    this.btnSearchSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 96 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSearchSubmit).Click += this.btnSearchSubmit_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.btnSearchReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 98 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSearchReset).Click += this.btnSearchReset_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.spType = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14:
                {
                    this.spItemValue = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15:
                {
                    this.spChooseByYear = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 16:
                {
                    this.spChooseByMonth = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 17:
                {
                    this.spChooseByLocation = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 18:
                {
                    this.txtSearchLocation = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19:
                {
                    this.txtSearchMonth = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.txtSearchYear = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21:
                {
                    this.spSearchType = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 22:
                {
                    this.radSearchByMonth = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 73 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radSearchByMonth).Checked += this.radSearchByMonth_Checked;
                    #line default
                }
                break;
            case 23:
                {
                    this.radSearchByYear = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 74 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radSearchByYear).Checked += this.radSearchByYear_Checked;
                    #line default
                }
                break;
            case 24:
                {
                    this.radSearchByLocation = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 75 "..\..\..\SearchItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radSearchByLocation).Checked += this.radSearchByLocation_Checked;
                    #line default
                }
                break;
            case 25:
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
            return returnValue;
        }
    }
}

