﻿#pragma checksum "..\..\..\..\UserControls\ucReaderList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51AB0E8D32D398FCC891ADB82AB631D41A0BF97B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryProject.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LibraryProject.UserControls {
    
    
    /// <summary>
    /// ucReaderList
    /// </summary>
    public partial class ucReaderList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\UserControls\ucReaderList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_ReaderList;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\UserControls\ucReaderList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_ReaderCount;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\UserControls\ucReaderList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DeleteUser;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\UserControls\ucReaderList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_UpdateUser;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\UserControls\ucReaderList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryProject;component/usercontrols/ucreaderlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\ucReaderList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\UserControls\ucReaderList.xaml"
            ((LibraryProject.UserControls.ucReaderList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtg_ReaderList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.lb_ReaderCount = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btn_DeleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\..\UserControls\ucReaderList.xaml"
            this.btn_DeleteUser.Click += new System.Windows.RoutedEventHandler(this.btn_DeleteUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_UpdateUser = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\UserControls\ucReaderList.xaml"
            this.btn_UpdateUser.Click += new System.Windows.RoutedEventHandler(this.btn_UpdateUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_AddUser = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\..\UserControls\ucReaderList.xaml"
            this.btn_AddUser.Click += new System.Windows.RoutedEventHandler(this.btn_AddUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

