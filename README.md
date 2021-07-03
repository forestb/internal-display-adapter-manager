# internal-display-adapter-manager<!-- omit in toc -->

A simple console application used to restart a device (in this case, the integrated graphics adapter) in the Windows 10 Device Manager list.

## Table of Contents<!-- omit in toc -->
- [Description](#description)
- [Getting Started](#getting-started)
  - [Dependencies](#dependencies)
  - [Executing program](#executing-program)
- [Version History](#version-history)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Description

Some machines have both an (a) integrated graphics adapter and a (b) discreet, hardware GPU. Things can get a bit funky when...

* The Windows 10 system goes in/out of sleep mode (e.g. power saving mode) and/or...
* The attached monitor support multiple refresh rates (e.g. 60hz and 120hz)

I purchased a Razor Blade Studio laptop, but there are times, when operating in "second screen only" mode (`Win + P`) that the "current refresh rate" in the display adapter does not sync. I've been unable to troubleshoot the issue beyond either (1) a computer restart or (2) disabling/re-enabling the integrated graphics adapter.

This console app makes it easy to do (2).

## Getting Started

### Dependencies

* Developed and built using Visual Studio 2019
* Tested on Windows 10

### Executing program

* Simply run `InternalDisplayAdapterManagerApp.exe`

## Version History

* 1.0
    * First working version
* 0.1
    * First commit

## License

This project is licensed under the MIT License - see the LICENSE.md file for details

## Acknowledgments

* [StackOverflow Post](https://stackoverflow.com/questions/1438371/win32-api-function-to-programmatically-enable-disable-device)