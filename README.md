<p align="center">
    <img width="8%" height="8%" src="media/logo.png" href="https://github.com/oqo0/extended-string/">
    <br>
</p>
<p align="center">
    A set of extensions to the default String in .NET which I was missing
</p>
<p align="center">
    <a>
        <img alt="Commit activity" src="https://img.shields.io/github/commit-activity/m/oqo0/extended-string?style=flat-square">
    </a>
    <a>
        <img alt="Code size" src="https://img.shields.io/github/languages/code-size/oqo0/extended-string?style=flat-square">
    </a>
    <a>
        <img alt="Last commit" src="https://img.shields.io/github/last-commit/oqo0/extended-string?style=flat-square">
    </a>
</p>

---

## List of methods
- `Between` - Returns a string between external strings or chars.
- `BetweenAll` - Returns all strings between external strings or chars.
- `Center` - Centers a string in a field of given width.
- `CountOccurence` - Counts of a specified string in string.
- `IsEmptyOrWhitespace` - Determines if string is empty or only consists of whitespaces.
- `LeftOf` - Extracts a string left of a specified char \ string.
- `RightOf` - Extracts a string right of a specified char \ string.
- `ReplaceAmount` - Replaces a specified amount of string occurrence.
- `Reverse` - Reverses a string.

## Examples
You can find a variety of minimalistic examples in [tests](ExtendedStringTests/ExtendedStringTests).

### Between()
```c#
str = "#1$ #2$"
Console.WriteLine(
    str.Between('#', '$')
);
```
Result: `"1"`

### BetweenAll()
```c#
str = "#1$ #2$"
Console.WriteLine(
    str.BetweenAll('#', '$')
);
```
Result: `{ "1", "2" }`

### Center()
```c#
str = "Text"
Console.WriteLine(
    str.Center(14)
);
```
Result: `"     Text     "`

### CountOccurence()
```c#
str = "12 12 12"
Console.WriteLine(
    str.CountOccurence("12")
);
```
Result: `3`

### IsEmptyOrWhitespace()
```c#
str = "   "
Console.WriteLine(
    str.IsEmptyOrWhitespace()
);
```
Result: `true`

### LeftOf()
```c#
str = "1234."
Console.WriteLine(
    str.LeftOf('4')
);
```
Result: `123`

### RightOf()
```c#
str = ".1234"
Console.WriteLine(
    str.RightOf('1')
);
```
Result: `234`

### ReplaceAmount()
```c#
str = "Some word for example"
Console.WriteLine(
    str.ReplaceAmount("o", 2)
);
```
Result: `"Sme wrd for example"`

### Reverse()
```c#
str = "123"
Console.WriteLine(
    str.Reverse()
);
```
Result: `"321"`