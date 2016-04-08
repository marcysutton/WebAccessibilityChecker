# Web Accessibility Checker

[![Build status](https://ci.appveyor.com/api/projects/status/q0xapaawd7mfxfby?svg=true)](https://ci.appveyor.com/project/madskristensen/webaccessibilitychecker)

Download the extension at the
[VS Gallery](https://visualstudiogallery.msdn.microsoft.com/46eef4d9-045b-4596-bd7f-eee980bb5450)
or get the
[CI build](http://vsixgallery.com/extension/25a79d25-0fff-4748-afaa-3a67ed116bc9/)

------------------------------------------

The easiest way to perform accessibility checks
on any ASP.NET web application. Fully customizable
and support all the major international accessibility standards.

## Features

- Uses Browser Link to test the running website
- Tests the actual DOM
- Integrates with the Visual Studio error list
- Supported accessibility standards
  - WCAG Level A
  - WCAG Level AA
  - Section 508
  - Other best practices
- All rules can be customzied per project/solution

### Connect with Browser Link

For this extension to work, make sure that Visual Studio's
Browser Link is up and running. Do that by running an
ASP.NET application from Visual Studio in one or more
browsers.

Hovering over the Browser Link button on the Standard
toolbar lets you know if Browser Link is connected.

![Browser Link Tooltip](art/browser-link-tooltip.png)

### Enable Web Accessibility Checker
Make sure Web Accessibility Checker is enabled, but clicking
the _Enable Accessibility Checker_ button in the Browser Link
dropdown menu.

![Dropdown menu](art/dropdown-menu.png)

### Accessibility rules
This extensions uses the [axe-core](https://github.com/dequelabs/axe-core)
library to perform the accessibility analysis.

All rules are completely customizable and can follow the
project or solution. 

See the full 
[list of rules](https://dequeuniversity.com/rules/axe/1.1)

### Error list
Errors found on the page will automatically populate the
Error List in Visual Studio.

![Error List integration](art/error-list.png)

In some cases it is known exactly where in the source code
the issue is and double-clicking the error take you straight
to the location.

### Settings
Some global settings can be configured in the option dialog.

![Options dialog](art/options.png)

## Contribute
Check out the [contribution guidelines](.github/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure 
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE) 