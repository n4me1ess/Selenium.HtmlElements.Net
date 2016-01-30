﻿using HtmlElements.Extensions;
using OpenQA.Selenium;

namespace HtmlElements.Elements {

    public class HtmlSelectOption : HtmlControl {

        public HtmlSelectOption(IWebElement webDriverOrWrapper) : base(webDriverOrWrapper) {}

        public new bool Selected {
            get { return base.Selected; }
            set { this.Do(e => e.Click()).Until(e => (e as IWebElement).Selected == value); }
        }

    }

}