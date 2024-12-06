# Babel_Obfuscar

This GitHub repository provides a comprehensive example of how to integrate the Babel Obfuscator to .NET (SDK-style Projects).

Steps to Obfuscate Code:

1. Create a .NET SDK-style project (Android | IOS)

2. Add babel.Obfuscator nuget package to local folder (<a href="https://www.babelfor.net/downloads/">Babel.Obfuscator.10.8.0</a>)

3. Add babel configuration to projects .csproj file

4. Build Project

If project is successfully build then .dll file with given project name is generated on given path

Android : /bin/Release/net8.0-android/Babel_Obfuscar_Android.dll
IOS     : /bin/Release/net8.0-ios/ios-arm64/Babel_Obfuscar_IOS.dll 

Notes:
In Android.csproj file if babel configuration is according to given babel example <a href="https://github.com/babelfornet/android-app-example/">Android Application</a> then application crashed.

References:

Babel Obfuscator is an obuscator for .NET Framework and Mono developed by babelfor.NET
<a href="https://www.babelfor.net/">Babel Obfuscator</a>




