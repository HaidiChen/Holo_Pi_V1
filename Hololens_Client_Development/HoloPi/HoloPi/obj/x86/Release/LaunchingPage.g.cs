﻿#pragma checksum "C:\Users\chenh\source\repos\HoloPi\HoloPi\LaunchingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "329E33E38CF3AB12C84EF8B44AE775ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoloPi
{
    partial class LaunchingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // LaunchingPage.xaml line 27
                {
                    this.pring = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 3: // LaunchingPage.xaml line 56
                {
                    this.ConnectBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConnectBtn).Click += this.ConnectBtn_Click;
                }
                break;
            case 4: // LaunchingPage.xaml line 60
                {
                    this.TxtError = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // LaunchingPage.xaml line 71
                {
                    this.debug = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // LaunchingPage.xaml line 66
                {
                    this.HCList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7: // LaunchingPage.xaml line 34
                {
                    this.IP1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // LaunchingPage.xaml line 41
                {
                    this.IP2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // LaunchingPage.xaml line 46
                {
                    this.IP3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // LaunchingPage.xaml line 51
                {
                    this.IP4 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

