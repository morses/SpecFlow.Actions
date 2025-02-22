﻿using SpecFlow.Actions.Configuration;
using SpecFlow.Actions.Selenium.Configuration;
using System.Collections.Generic;

namespace SpecFlow.Actions.Browserstack
{
    public class BrowserstackConfiguration : SeleniumConfiguration
    {
        private readonly ISpecFlowActionsConfiguration _specFlowActionsConfiguration;

        public BrowserstackConfiguration(ISpecFlowActionsConfiguration specFlowActionsConfiguration) : base(specFlowActionsConfiguration)
        {
            _specFlowActionsConfiguration = specFlowActionsConfiguration;
        }

        public Dictionary<string, string> BrowserstackLocalCapabilities =>
            _specFlowActionsConfiguration.GetDictionary("selenium:browserstack:localcapabilities");

        public bool BrowserstackLocalRequired => base.Capabilities["browserstack.local"] == "true";
    }
}