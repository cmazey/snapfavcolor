using Spectre.Console;

Console.WriteLine("Hello World!");

var snapFavColor = new Table();

await AnsiConsole.Live(snapFavColor)
.StartAsync(async ctx =>
{
    // Columns

    snapFavColor.AddColumn("[red]Red[/]"); // Column 1: Red
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[blue]Blue[/]"); // Column 2: Blue
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[green]Green[/]"); // Column 3: Green
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[yellow]Yellow[/]"); // Column 4: Yellow
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[purple]Purple[/]"); // Column 5: Purple
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[orange1]Orange[/]"); // Column 6: Orange
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[pink1]Pink[/]"); // Column 7: Pink
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddColumn("[black]Black[/]"); // Column 8: Black
    ctx.Refresh();
    await Task.Delay(1000);

    // Rows

    snapFavColor.AddRow("[white]Colton Mazey[/]", "[white]Kiara Pfister[/]", "[white]Max Cremona[/]", "[white]RJ Icke[/]", "[white]Brandon Reed[/]", "[white]Seth Sebold[/]", "[white]Rebecca Sinclare[/]", "[white]Owen Curry[/]"); // Row 1
    ctx.Refresh();
    await Task.Delay(100);
    
    snapFavColor.AddRow("[white]Anthony Fratini[/]", "Alex Fratini", "[white]Chance Robinson[/]", "[white]Rusto[/]", "[white]Luke Dotson[/]", "[white]Daniel Monahan[/]", "[white]Bradley Sellers[/]", "[white]Brandon Reed[/]"); // Row 2
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Rashee MclaurinJr[/]", "[white]John Mazey[/]", "[white]James Cox[/]", "[white]Tyler Valentino[/]", "[white]Daniel Beck[/]", "[white]Anderson Scott[/]", "", "[white]Angel Hillsman[/]"); // Row 3
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Wondu Evans[/]", "[white]Bradley Sellers[/]", "[white]Eli Pfister[/]", "", "[white]John Mazey[/]", "", "", "[white]Jack Chalmers[/]"); // Row 4
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Nolan Meyer[/]", "[white]Ella Pfister[/]", "[white]Jostahn Kuehner[/]"); // Row 5
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Tray Buckley[/]", "[white]Danny Barker[/]", "[white]Owen Konjura[/]"); // Row 6
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Michael D.[/]", "[white]Aiden Newkirk[/]", "[white]Leo Mazey[/]"); // Row 7
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Londyn Taylor[/]"); // Row 8
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Ben Gorman[/]"); // Row 9
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Dante Scott[/]"); // Row 10
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Daniel Beck[/]"); // Row 11
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Braeden Barker[/]"); // Row 12
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Scotty N.[/]"); // Row 13
    ctx.Refresh();
    await Task.Delay(100);

    // Cusom Border
    snapFavColor.Border = TableBorder.MinimalHeavyHead;
    ctx.Refresh();
    await Task.Delay(1000);
});

AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label("[yellow bold underline]Friends on Snap[/]")
    .CenterLabel()
    .AddItem("Total Friends", 57, Color.Yellow)
    .AddItem("Boys", 47, Color.Blue1)
    .AddItem("Girls", 10, Color.Pink1));

Console.ReadKey();