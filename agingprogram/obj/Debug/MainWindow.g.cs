#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8655AEA2215F2EFFD75C8B9E6E9D865E11C03D81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SerialProgram;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SerialProgram {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxCom;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxBaudrate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxDatabits;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxStopbits;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxParity;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRefresh;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonConnect;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextBox_hex;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTextBox_ascii;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_hexClear;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_hexAnswer;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_asciiClear;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_asciiAnswer;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_hex1;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_hex1;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_hex2;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_hex2;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_hex3;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_hex3;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_ascii1;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ascii1;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_ascii2;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ascii2;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_ascii3;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ascii3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/agingprogram;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\MainWindow.xaml"
            ((SerialProgram.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            ((SerialProgram.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBoxCom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.comboBoxBaudrate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.comboBoxDatabits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.comboBoxStopbits = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.comboBoxParity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.buttonRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.buttonRefresh.Click += new System.Windows.RoutedEventHandler(this.buttonRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonConnect = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.buttonConnect.Click += new System.Windows.RoutedEventHandler(this.buttonConnect_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.richTextBox_hex = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 10:
            this.richTextBox_ascii = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 11:
            this.button_hexClear = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\MainWindow.xaml"
            this.button_hexClear.Click += new System.Windows.RoutedEventHandler(this.button_hexClear_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.button_hexAnswer = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.button_asciiClear = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\MainWindow.xaml"
            this.button_asciiClear.Click += new System.Windows.RoutedEventHandler(this.button_asciiClear_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.button_asciiAnswer = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.textBox_hex1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.textBox_hex1.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_hex1_KeyDown);
            
            #line default
            #line hidden
            return;
            case 16:
            this.button_hex1 = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.button_hex1.Click += new System.Windows.RoutedEventHandler(this.button_hex1_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.textBox_hex2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\MainWindow.xaml"
            this.textBox_hex2.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_hex2_KeyDown);
            
            #line default
            #line hidden
            return;
            case 18:
            this.button_hex2 = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\MainWindow.xaml"
            this.button_hex2.Click += new System.Windows.RoutedEventHandler(this.button_hex2_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.textBox_hex3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.textBox_hex3.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_hex3_KeyDown);
            
            #line default
            #line hidden
            return;
            case 20:
            this.button_hex3 = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.button_hex3.Click += new System.Windows.RoutedEventHandler(this.button_hex3_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.textBox_ascii1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\MainWindow.xaml"
            this.textBox_ascii1.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_ascii1_KeyDown);
            
            #line default
            #line hidden
            return;
            case 22:
            this.button_ascii1 = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\MainWindow.xaml"
            this.button_ascii1.Click += new System.Windows.RoutedEventHandler(this.button_ascii1_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.textBox_ascii2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 112 "..\..\MainWindow.xaml"
            this.textBox_ascii2.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_ascii2_KeyDown);
            
            #line default
            #line hidden
            return;
            case 24:
            this.button_ascii2 = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\MainWindow.xaml"
            this.button_ascii2.Click += new System.Windows.RoutedEventHandler(this.button_ascii2_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.textBox_ascii3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this.textBox_ascii3.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBox_ascii3_KeyDown);
            
            #line default
            #line hidden
            return;
            case 26:
            this.button_ascii3 = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\MainWindow.xaml"
            this.button_ascii3.Click += new System.Windows.RoutedEventHandler(this.button_ascii3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

