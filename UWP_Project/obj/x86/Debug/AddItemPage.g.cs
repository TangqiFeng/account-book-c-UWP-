﻿#pragma checksum "C:\Labs\App\UWP_Project\UWP_Project\AddItemPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "722FC62A1EC87A5A5BB72B0E242728B4"
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
    partial class AddItemPage : 
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
                    this.spHeader = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.spAdd = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.spFoot = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.btnToHomePage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 75 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnToHomePage).Click += this.btnToHomePage_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnToSetPage = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.calendarDatePicker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 7:
                {
                    this.spChooseType = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.txtDescribe = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.spChooseCurrency = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.btnAddSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddSubmit).Click += this.btnAddSubmit_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btnAddReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddReset).Click += this.btnAddReset_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.txtLocation = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.btnGetLocation = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGetLocation).Click += this.btnGetLocation_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.txtValue = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.cmbChooseCurrency = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 16:
                {
                    this.radPlus = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 31 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radPlus).Checked += this.radPlus_Checked;
                    #line default
                }
                break;
            case 17:
                {
                    this.radMinus = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 32 "..\..\..\AddItemPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.radMinus).Checked += this.radMinus_Checked;
                    #line default
                }
                break;
            case 18:
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
