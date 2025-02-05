﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumBase;

namespace Widgets
{
    internal class Accordian : SelActions
    {
        public void start(bool chain)
        {
            open("https://demoqa.com/accordian");

            openCloseFirst();
            openCloseSecond();
            openCloseThird();

            exit();

            if (chain)
            {
                new AutoComplete().start(chain);
            }
        }

        private void openCloseThird()
        {
            oac("section3Heading");
        }

        private void openCloseSecond()
        {
            oac("section2Heading");
        }

        private void openCloseFirst()
        {
            oac("section1Heading");
        }

        private void oac(string id)
        {
            FindID(id).Click();
            Thread.Sleep(1000);
            FindID(id).Click();
        }
    }
}
