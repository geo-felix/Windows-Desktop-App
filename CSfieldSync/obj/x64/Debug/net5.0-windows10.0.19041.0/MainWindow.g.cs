﻿#pragma checksum "C:\Users\fodhiambo1\source\repos\CSfieldSync\CSfieldSync\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3A34BA65A31A1E8A0C2C5C83C72E3BF6A10E18CE18782474791210DD8021835"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace CSfieldSync
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 15
                {
                    this.NavView = target.As<Microsoft.UI.Xaml.Controls.NavigationView>();
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavView).ItemInvoked += this.NavView_ItemInvoked;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                }
                break;
            case 3: // MainWindow.xaml line 30
                {
                    this.ContentFrame = target.As<Microsoft.UI.Xaml.Controls.Frame>();
                    ((global::Microsoft.UI.Xaml.Controls.Frame)this.ContentFrame).NavigationFailed += this.ContentFrame_NavigationFailed;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

