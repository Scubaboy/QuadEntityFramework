﻿set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=1.0.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)
 
set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

%nuget% restore

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild QuadEntityFramework.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=diag /nr:false
 
mkdir Build
mkdir Build\lib
mkdir Build\lib\net40
 
%nuget% pack "QuadEntityFramework\QuadEntityFramework.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"