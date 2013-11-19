﻿using OpenQA.Selenium;

using Selenium.HtmlElements.Factory;

namespace Selenium.HtmlElements.Elements {

    internal class HtmlLink : HtmlElement {

        public const string TargetBlank = "_blank";
        public const string TargetParent = "_parent";
        public const string TargetSelf = "_self";
        public const string TargetTop = "_top";

        public HtmlLink(IWebElement wrapped) : base(wrapped) {}

        public string Href {
            get { return GetAttribute("href"); }
            set { this.SetAttribute("href", value); }
        }

        public string Target {
            get { return GetAttribute("target"); }
            set { this.SetAttribute("target", value); }
        }

        public TReturn Open<TReturn>() where TReturn : class {
            Click();

            return PageFactory.InitElementsIn<TReturn>(WrappedDriver);
        }

    }

}