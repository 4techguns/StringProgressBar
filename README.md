# StringProgressBar
A port of https://github.com/Sparker-99/string-progressbar to .NET

Installation: Install the StringProgressBar NuGet package

Usage:
```cs
using StringProgressBar;

// args: progress, limit, number of characters (size), empty character, filled character
// only progress and limit arguments are required, size defaults to 40
Console.WriteLine(ProgressBar.FilledBar(5, 10, 10, '□', '■').ToString()); // output: ■■■■■□□□□□
Console.WriteLine(ProgressBar.SplitBar(5, 10, 10, '▬', '•').ToString()); // output: ▬▬▬▬•▬▬▬▬▬
```
