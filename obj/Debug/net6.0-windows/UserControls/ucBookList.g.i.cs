﻿#pragma checksum "..\..\..\..\UserControls\ucBookList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01700036CDA32471F7189EE2035CF6E013F0A585"
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
    /// ucBookList
    /// </summary>
    public partial class ucBookList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_BookList;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SearchBook;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SourceBook;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_BookCount;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SearchAuthor;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SourceAuthor;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DeleteBook;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_UpdateBook;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\UserControls\ucBookList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddBook;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryProject;component/usercontrols/ucbooklist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\ucBookList.xaml"
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
            
            #line 8 "..\..\..\..\UserControls\ucBookList.xaml"
            ((LibraryProject.UserControls.ucBookList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtg_BookList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btn_SearchBook = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\..\UserControls\ucBookList.xaml"
            this.btn_SearchBook.Click += new System.Windows.RoutedEventHandler(this.btn_SearchBook_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_SourceBook = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lb_BookCount = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btn_SearchAuthor = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\..\..\UserControls\ucBookList.xaml"
            this.btn_SearchAuthor.Click += new System.Windows.RoutedEventHandler(this.btn_SearchAuthor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txt_SourceAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_DeleteBook = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\..\UserControls\ucBookList.xaml"
            this.btn_DeleteBook.Click += new System.Windows.RoutedEventHandler(this.btn_DeleteBook_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_UpdateBook = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\..\UserControls\ucBookList.xaml"
            this.btn_UpdateBook.Click += new System.Windows.RoutedEventHandler(this.btn_UpdateBook_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_AddBook = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\..\UserControls\ucBookList.xaml"
            this.btn_AddBook.Click += new System.Windows.RoutedEventHandler(this.btn_AddBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

