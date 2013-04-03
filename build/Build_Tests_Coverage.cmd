REM ..\src\.nuget\nuget.exe update ..\src\RConDevServer.sln
rmdir /S /Q ..\_Artifacts
SET NET_DIRECTORY=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\
%NET_DIRECTORY%\msbuild ..\src\RConDevServer.sln /t:clean,rebuild
mkdir ..\_Artifacts\reports\
mkdir ..\_Artifacts\reports\coverage
tools\OpenCover.4.0.1128\OpenCover.Console.exe -target:"tools\nunit-console\bin\nunit-console-x86.exe" -targetdir:..\_Artifacts\Tests\ -targetargs:"RConDevServer.Core.Tests.dll RConDevServer.Protocol.Dice.Battlefield3.Tests.dll" -register:user "tools\OpenCover.4.0.804\x86\OpenCover.Profiler.dll" -output:"..\_Artifacts\reports\coverage\coverage.xml" -filter:"+[RConDevServer*]* -[*Tests*]*"
tools\ReportGenerator.1.7.2.0\ReportGenerator.exe "..\_Artifacts\reports\coverage\coverage.xml" "..\_Artifacts\reports\coverage\html"
pause