﻿#pragma checksum "C:\Users\Derick\source\repos\Assignment2\Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D613D2810788146CAB31F960DCE25CF84494969E3F4AB70465800B2FC7271B6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_2
{
    partial class Login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Login.xaml line 13
                {
                    this.textBlockLogin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Login.xaml line 21
                {
                    this.textBoxUsername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Login.xaml line 22
                {
                    this.textBoxPass = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // Login.xaml line 24
                {
                    this.buttonLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonLogin).Click += this.buttonLogin_Click;
                }
                break;
            case 6: // Login.xaml line 17
                {
                    global::Windows.UI.Xaml.Documents.Hyperlink element6 = (global::Windows.UI.Xaml.Documents.Hyperlink)(target);
                    ((global::Windows.UI.Xaml.Documents.Hyperlink)element6).Click += this.GoRegister_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
