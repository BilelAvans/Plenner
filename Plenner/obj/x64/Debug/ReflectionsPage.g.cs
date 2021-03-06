﻿#pragma checksum "C:\Users\Bilel\Documents\Visual Studio 2017\Projects\Plenner\Plenner\ReflectionsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "45BA3CA28F5EC6557C20D5D32E34AAAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plenner
{
    partial class ReflectionsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class ReflectionsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IReflectionsPage_Bindings
        {
            private global::Plenner.ReflectionsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj4;

            public ReflectionsPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IReflectionsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Plenner.ReflectionsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Plenner.ReflectionsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_plan(obj.plan, phase);
                    }
                }
            }
            private void Update_plan(global::DataLab.Storage.PlanningItemStorage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_plan_plan(obj.plan, phase);
                    }
                }
            }
            private void Update_plan_plan(global::DataLab.Data.Planning.Plan obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_plan_plan_Reflections(obj.Reflections, phase);
                    }
                }
            }
            private void Update_plan_plan_Reflections(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Reflection> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.RelativePanel element2 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 22 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element2).ManipulationCompleted += this.RelativePanel_ManipulationCompleted;
                    #line default
                }
                break;
            case 3:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.addReflectionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 103 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.addReflectionButton).Click += this.addReflectionButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.showJournalButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 108 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.showJournalButton).Click += this.showJournalButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.nameHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 40 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.nameHeaderTextBlock).Tapped += this.nameHeaderTextBlock_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.feelingHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 43 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.feelingHeaderTextBlock).Tapped += this.feelingHeaderTextBlock_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.RelativePanel element10 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 48 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element10).PointerPressed += this.listViewRelativePanel_PointerPressed;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 91 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.deleteReflectionButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.Maps.MapControl element12 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    #line 70 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)element12).MapTapped += this.MapControl_MapTapped;
                    #line 70 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)element12).Loaded += this.MapControl_Loaded;
                    #line 70 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)element12).MapElementClick += this.MapControl_MapElementClick;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 71 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.button3_Click;
                    #line default
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.button4_Click;
                    #line default
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.Flyout element15 = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    #line 56 "..\..\..\ReflectionsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)element15).Opened += this.Flyout_Opened;
                    #line default
                }
                break;
            case 16:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 17:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ReflectionsPage_obj1_Bindings bindings = new ReflectionsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

