﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using EnvDTE;
using Microsoft.VisualStudio.Web.BrowserLink;

namespace WebAccessibilityChecker
{
    public class CheckerExtension : BrowserLinkExtension
    {
        private Project _project;

        public CheckerExtension(Project project)
        {
            _project = project;
        }

        [BrowserLinkCallback]
        public void ProcessResult(string jsonResult)
        {

        }
    }
}