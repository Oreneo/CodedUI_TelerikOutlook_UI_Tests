﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Telerik.Outlook.Infrastructure.UIMaps.CalendarHomeBarUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class CalendarHomeBarUIMap
    {
        
        #region Properties
        public UIMarktelerikdomaincomWindow UIMarktelerikdomaincomWindow
        {
            get
            {
                if ((this.mUIMarktelerikdomaincomWindow == null))
                {
                    this.mUIMarktelerikdomaincomWindow = new UIMarktelerikdomaincomWindow();
                }
                return this.mUIMarktelerikdomaincomWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIMarktelerikdomaincomWindow mUIMarktelerikdomaincomWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIMarktelerikdomaincomWindow : WpfWindow
    {
        
        public UIMarktelerikdomaincomWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "mark@telerikdomain.com - calendar";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIItemCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIItemCustom : WpfCustom
    {
        
        public UIItemCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.MainView";
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public UIRadRibbonViewTabList UIRadRibbonViewTabList
        {
            get
            {
                if ((this.mUIRadRibbonViewTabList == null))
                {
                    this.mUIRadRibbonViewTabList = new UIRadRibbonViewTabList(this);
                }
                return this.mUIRadRibbonViewTabList;
            }
        }
        #endregion
        
        #region Fields
        private UIRadRibbonViewTabList mUIRadRibbonViewTabList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIRadRibbonViewTabList : WpfTabList
    {
        
        public UIRadRibbonViewTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "richTextBoxRibbonUI";
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public UIHomeTabPage UIHomeTabPage
        {
            get
            {
                if ((this.mUIHomeTabPage == null))
                {
                    this.mUIHomeTabPage = new UIHomeTabPage(this);
                }
                return this.mUIHomeTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIHomeTabPage mUIHomeTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomeTabPage : WpfTabPage
    {
        
        public UIHomeTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Home";
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public UIAppointmentGroup UIAppointmentGroup
        {
            get
            {
                if ((this.mUIAppointmentGroup == null))
                {
                    this.mUIAppointmentGroup = new UIAppointmentGroup(this);
                }
                return this.mUIAppointmentGroup;
            }
        }
        
        public UIViewsGroup UIViewsGroup
        {
            get
            {
                if ((this.mUIViewsGroup == null))
                {
                    this.mUIViewsGroup = new UIViewsGroup(this);
                }
                return this.mUIViewsGroup;
            }
        }
        #endregion
        
        #region Fields
        private UIAppointmentGroup mUIAppointmentGroup;
        
        private UIViewsGroup mUIViewsGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIAppointmentGroup : WpfGroup
    {
        
        public UIAppointmentGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.Name] = "Appointment";
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public WpfButton UIDeleteappointmentButton
        {
            get
            {
                if ((this.mUIDeleteappointmentButton == null))
                {
                    this.mUIDeleteappointmentButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIDeleteappointmentButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "DeleteAppointment";
                    this.mUIDeleteappointmentButton.WindowTitles.Add("mark@telerikdomain.com - calendar");
                    #endregion
                }
                return this.mUIDeleteappointmentButton;
            }
        }
        
        public WpfButton UICreateappointmentButton
        {
            get
            {
                if ((this.mUICreateappointmentButton == null))
                {
                    this.mUICreateappointmentButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICreateappointmentButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "CreateAppointment";
                    this.mUICreateappointmentButton.WindowTitles.Add("mark@telerikdomain.com - calendar");
                    #endregion
                }
                return this.mUICreateappointmentButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIDeleteappointmentButton;
        
        private WpfButton mUICreateappointmentButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIViewsGroup : WpfGroup
    {
        
        public UIViewsGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.Name] = "Views";
            this.WindowTitles.Add("mark@telerikdomain.com - calendar");
            #endregion
        }
        
        #region Properties
        public WpfButton UISetstheschedulersvieButton
        {
            get
            {
                if ((this.mUISetstheschedulersvieButton == null))
                {
                    this.mUISetstheschedulersvieButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISetstheschedulersvieButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "SetDayViewMode";
                    this.mUISetstheschedulersvieButton.WindowTitles.Add("mark@telerikdomain.com - calendar");
                    #endregion
                }
                return this.mUISetstheschedulersvieButton;
            }
        }
        
        public WpfButton UIRadRibbonButtonButton
        {
            get
            {
                if ((this.mUIRadRibbonButtonButton == null))
                {
                    this.mUIRadRibbonButtonButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIRadRibbonButtonButton.SearchProperties[WpfButton.PropertyNames.HelpText] = "RadRibbonButton";
                    this.mUIRadRibbonButtonButton.WindowTitles.Add("mark@telerikdomain.com - calendar");
                    #endregion
                }
                return this.mUIRadRibbonButtonButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUISetstheschedulersvieButton;
        
        private WpfButton mUIRadRibbonButtonButton;
        #endregion
    }
}
