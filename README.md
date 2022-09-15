# How to Use

## From Executable

Download the latest executable from releases here: https://github.com/SteffenBlake/StackedDeckEVLoader/releases/latest

Simply run the executable and it will generate an `output.txt` file beside it by parsing the latest data from poe.ninja.

## Manually Compile and Run

Ensure you have the latest version of .NET  installed from Microsoft: https://dotnet.microsoft.com/en-us/download

Clone this repo via git: `git clone https://github.com/SteffenBlake/StackedDeckEVLoader.git`

`cd` into the `src` folder, and execute `dotnet run`

## Copy into the Google Spreadsheet

Load up your copy of the workbook (original here: https://docs.google.com/spreadsheets/d/182eMBmvqe8ifXEtUmt01DN5OFyNcLrTukwOPKKni0oA/edit?usp=sharing) and copy paste the data from `output.txt` into the `PoeNinja Data` sheet

This should automatically reload the `Expected Val:` value on the `Divination Cards` sheet.
