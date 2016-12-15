﻿#pragma checksum "C:\Users\Bilel\documents\visual studio 15\Projects\Planner\Planner\ActivitiesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "637D3550BA1782D9DC67454271891D5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planner
{
    partial class ActivitiesPage : 
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
        private class ActivitiesPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IActivitiesPage_Bindings
        {
            private global::Planner.ActivitiesPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj3;
            private global::Windows.UI.Xaml.Controls.ListView obj7;

            public ActivitiesPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IActivitiesPage_Bindings

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
                    this.dataRoot = (global::Planner.ActivitiesPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Planner.ActivitiesPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning(obj.Planning, phase);
                    }
                }
            }
            private void Update_Planning(global::DataLab.Storage.PlanningItemStorage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning_plan(obj.plan, phase);
                    }
                }
            }
            private void Update_Planning_plan(global::DataLab.Data.Planning.Plan obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Planning_plan_Activities(obj.Activities, phase);
                        this.Update_Planning_plan_rpi(obj.rpi, phase);
                    }
                }
            }
            private void Update_Planning_plan_Activities(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.Activity> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                }
            }
            private void Update_Planning_plan_rpi(global::System.Collections.ObjectModel.ObservableCollection<global::DataLab.Data.Planning.RepeatingPlanningItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
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
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 18 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).DoubleTapped += this.Grid_DoubleTapped;
                    #line default
                }
                break;
            case 3:
                {
                    this.listBoxSingleItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 74 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock).SelectionChanged += this.textBlock_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 75 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click_1;
                    #line default
                }
                break;
            case 6:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 8:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.RelativePanel element11 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 117 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element11).ManipulationStarted += this.Grid_ManipulationStarted;
                    #line 117 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element11).ManipulationCompleted += this.Grid_ManipulationCompleted;
                    #line default
                }
                break;
            case 12:
                {
                    this.leftSwipeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.rightSwipeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.repeatingNameHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 88 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.repeatingNameHeader).Tapped += this.repeatingNameHeader_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.repeatingTimeHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 90 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.repeatingTimeHeader).Tapped += this.repeatingTimeHeader_Tapped;
                    #line default
                }
                break;
            case 16:
                {
                    global::Windows.UI.Xaml.Controls.Button element16 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 100 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element16).Click += this.Button_Click_2;
                    #line default
                }
                break;
            case 17:
                {
                    this.singleActivityNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 29 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.singleActivityNameTextBlock).Tapped += this.singleActivityNameTextBlock_Tapped;
                    #line default
                }
                break;
            case 18:
                {
                    this.singleActivityTimeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 30 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.singleActivityTimeTextBlock).Tapped += this.singleActivityTimeTextBlock_Tapped;
                    #line default
                }
                break;
            case 19:
                {
                    global::Windows.UI.Xaml.Controls.RelativePanel element19 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 38 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element19).PointerPressed += this.listBoxSingleItems_PointerPressed;
                    #line default
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.editButton_Click;
                    #line default
                }
                break;
            case 21:
                {
                    global::Windows.UI.Xaml.Controls.Button element21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 64 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element21).Click += this.Button_Click;
                    #line default
                }
                break;
            case 22:
                {
                    global::Windows.UI.Xaml.Controls.Button element22 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 49 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element22).Click += this.button3_Click;
                    #line default
                }
                break;
            case 23:
                {
                    global::Windows.UI.Xaml.Controls.Maps.MapControl element23 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    #line 54 "..\..\..\ActivitiesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)element23).Loaded += this.MapControl_Loaded;
                    #line default
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
                    ActivitiesPage_obj1_Bindings bindings = new ActivitiesPage_obj1_Bindings();
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
