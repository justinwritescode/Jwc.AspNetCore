# Range\.Regex\(\) Method

[Home](../../../README.md)

**Containing Type**: JustinWritesCode\.Payloads\.[Range](../README.md)

**Assembly**: JustinWritesCode\.Payloads\.dll

```csharp
[System.CodeDom.Compiler.GeneratedCode("System.Text.RegularExpressions.Generator", "7.0.7.6804")]
[System.Text.RegularExpressions.GeneratedRegex("items\\s(?<Start>[0-9]+)\\-(?:(?<End>[0-9]+)?|[\\*])", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Compiled)]
public static System.Text.RegularExpressions.Regex Regex()
```

### Returns

System\.Text\.RegularExpressions\.[Regex](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex)

### Attributes

* System\.CodeDom\.Compiler\.[GeneratedCodeAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.codedom.compiler.generatedcodeattribute)
* System\.Text\.RegularExpressions\.[GeneratedRegexAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.generatedregexattribute)

## Remarks

Pattern explanation:

```
○ Match a character in the set [Ii].
○ Match a character in the set [Tt].
○ Match a character in the set [Ee].
○ Match a character in the set [Mm].
○ Match a character in the set [Ss].
○ Match a whitespace character.
○ "Start" capture group.
    ○ Match '0' through '9' atomically at least once.
○ Match '-'.
○ Match with 2 alternative expressions, atomically.
    ○ Optional (greedy).
        ○ "End" capture group.
            ○ Match '0' through '9' atomically at least once.
    ○ Match '*'.
```

