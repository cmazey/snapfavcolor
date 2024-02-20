using Spectre.Console;

Console.WriteLine("Hello World!");

var snapFavColor = new Table();

snapFavColor.Border = TableBorder.Minimal;

// Columns
snapFavColor.AddColumn("[red]Red[/]"); // Column 1: Red
snapFavColor.AddColumn("[blue]Blue[/]"); // Column 2: Blue
snapFavColor.AddColumn("[green]Green[/]"); // Column 3: Green
snapFavColor.AddColumn("[yellow]Yellow[/]"); // Column 4: Yellow
snapFavColor.AddColumn("[purple]Purple[/]"); // Column 5: Purple
snapFavColor.AddColumn("[orange1]Orange[/]"); // Column 6: Orange
snapFavColor.AddColumn("[pink1]Pink[/]"); // Column 7: Pink
snapFavColor.AddColumn("[black]Black[/]"); // Column 8: Black

// Rows                          Red                      Blue                       Green                        Yellow                      Purple                   Orange                    Pink                     Black
snapFavColor.AddRow("[white]Colton Mazey[/]", "[white]Kiara Pfister[/]", "[white]Max Cremona[/]", "[white]RJ Icke[/]", "[white]Brandon Reed[/]", "[white]Seth Sebold[/]", "[white]Rebecca Sinclare[/]", "[white]Owen Curry[/]"); // Row 1
snapFavColor.AddRow("[white]Anthony Fratini[/]", "Alex Fratini", "[white]Chance Robinson[/]", "[white]Rusto[/]", "[white]Luke Dotson[/]", "[white]Daniel Monahan[/]", "[white]Bradley Sellers[/]", "[white]Brandon Reed[/]"); // Row 2
snapFavColor.AddRow("[white]Rashee MclaurinJr[/]", "[white]John Mazey[/]", "[white]James Cox[/]", "[white]Tyler Valentino[/]", "[white]Daniel Beck[/]", "[white]Anderson Scott[/]", "", "[white]Angel Hillsman[/]"); // Row 3
snapFavColor.AddRow("[white]Wondu Evans[/]", "[white]Bradley Sellers[/]", "[white]Eli Pfister[/]", "", "[white]John Mazey[/]", "", "[white][/]", "[white][/]"); // Row 4
snapFavColor.AddRow("[white]Nolan Meyer[/]", "[white]Ella Pfister[/]", "[white]Jostahn Kuehner[/]"); // Row 5
snapFavColor.AddRow("[white]Tray Buckley[/]", "[white]Danny Barker[/]", "[white]Owen Konjura[/]"); // Row 6
snapFavColor.AddRow("[white]Michael D.[/]", "[white]Aiden Newkirk[/]", ""); // Row 7
snapFavColor.AddRow("", "[white]Londyn Taylor[/]"); // Row 8
snapFavColor.AddRow("", "[white]Ben Gorman[/]"); // Row 9
snapFavColor.AddRow("", "[white]Dante Scott[/]"); // Row 10
snapFavColor.AddRow("", "[white]Daniel Beck[/]"); // Row 11
snapFavColor.AddRow("", "[white]Braeden Barker[/]"); // Row 12

// Render the table to the console
AnsiConsole.Write(snapFavColor);