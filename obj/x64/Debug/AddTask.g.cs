﻿#pragma checksum "C:\Users\30029307\source\repos\Assignment2\AddTask.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78E434E0B80DA72841AE01A5D562440EC42E4568A82683881877B5841994CF0D"
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
    partial class AddTask : 
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
            case 2: // AddTask.xaml line 42
                {
                    this.gridAddTask = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // AddTask.xaml line 67
                {
                    this.buttonAdd = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonAdd).Click += this.buttonAdd_Click;
                }
                break;
            case 4: // AddTask.xaml line 63
                {
                    this.textBoxTask = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // AddTask.xaml line 64
                {
                    this.datePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 6: // AddTask.xaml line 55
                {
                    this.textBlockFirstLine = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // AddTask.xaml line 56
                {
                    this.textBlockSecondLine = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

