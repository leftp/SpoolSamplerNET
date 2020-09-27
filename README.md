# SpoolSamplerNET

Implementation of [SpoolSample](https://github.com/leechristensen/SpoolSample) from @leechristensen in C# without a rDLL.

Most/all of the code is from the excellent project [PingCastle](https://github.com/vletoux/pingcastle) of @vletoux who also wrote [SpoolScanner](https://github.com/vletoux/SpoolerScanner) in ps1 / c#.

Just added the "captureserver" in RpcRemoteFindFirstPrinterChangeNotificationEx pszLocalMachine

## Usage
```
SpoolSamplerNET.exe \\\\listener \\\\PrinterHost
```
