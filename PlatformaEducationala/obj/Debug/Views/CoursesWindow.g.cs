﻿#pragma checksum "..\..\..\Views\CoursesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0DA52F08E66D800D0ACA37EF0EA64F73EDAE30D4B69CB8A1BEAB6631B23F750F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PlatformaEducationala.Converters;
using PlatformaEducationala.ViewModels;
using PlatformaEducationala.Views;
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


namespace PlatformaEducationala.Views {
    
    
    /// <summary>
    /// CoursesWindow
    /// </summary>
    public partial class CoursesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Views\CoursesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid coursesGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\CoursesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCourseButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\CoursesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCourseButton;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\CoursesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ModifyCourseButton;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Views\CoursesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseNameInput;
        
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
            System.Uri resourceLocater = new System.Uri("/PlatformaEducationala;component/views/courseswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CoursesWindow.xaml"
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
            this.coursesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.DeleteCourseButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Views\CoursesWindow.xaml"
            this.DeleteCourseButton.Click += new System.Windows.RoutedEventHandler(this.DeleteCourseButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddCourseButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Views\CoursesWindow.xaml"
            this.AddCourseButton.Click += new System.Windows.RoutedEventHandler(this.AddCourseButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ModifyCourseButton = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Views\CoursesWindow.xaml"
            this.ModifyCourseButton.Click += new System.Windows.RoutedEventHandler(this.ModifyCourseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CourseNameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
