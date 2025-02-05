﻿using System;
using ReportingLibrary;
using SeleniumExtras.PageObjects;

namespace Test
{
    public class Pages
    {
        Browsers _browser { get; }

        ExtentReportsHelper _extentReportsHelper { get; set; }

        public Pages(Browsers browser, ExtentReportsHelper extentReportsHelper)
        {
            _browser = browser;
            _extentReportsHelper = extentReportsHelper;
        }

        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.getDriver);

            PageFactory.InitElements(_browser.getDriver, page);

            return page;
        }

        public Home Home => GetPages<Home>();
        public Computers Computers => GetPages<Computers>();
    }
}
