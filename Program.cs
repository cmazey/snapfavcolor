using Spectre.Console;

Console.WriteLine("Press anything to start program...");
Console.ReadKey();
Console.Clear();

Console.WriteLine("[SYS] Snapfavcolor : STARTED\n");
Thread.Sleep(1000);

var snapFavColor = new Table();
Console.WriteLine();
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

    snapFavColor.AddRow("[white]Anthony Fratini[/]", "[white]Alex Fratini[/]", "[white]Chance Robinson[/]", "[white]Rusto[/]", "[white]Luke Dotson[/]", "[white]Daniel Monahan[/]", "[rgb(255,182,193)]Bradley Sellers[/]", "[white]Jack Chalmers[/]"); // Row 2
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Rashee MclaurinJr[/]", "[white]Braeden Barker[/]", "[white]James Cox[/]", "[white]Tyler Valentino[/]", "[rgb(78,81,128)]Daniel Beck[/]", "[white]Anderson Scott[/]", "", "[white]Angel Hillsman[/]"); // Row 3
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Wondu Evans[/]", "[white]Scotty N.[/]", "[white]Eli Pfister[/]", "[white]Nick Zarlinga[/]", "[white]John Mazey[/]", "", "", ""); // Row 4
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Nolan Meyer[/]", "[white]Ella Pfister[/]", "[rgb(1,50,32)]Jostahn Kuehner[/]", "", "Sean D."); // Row 5
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[white]Tray Buckley[/]", "[white]Danny Barker[/]", "[white]Owen Konjura[/]"); // Row 6
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("[rgb(195,33,72)]Michael D.[/]", "[white]Aiden Newkirk[/]", "[white]Leo Mazey[/]"); // Row 7
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Londyn Taylor[/]", "[rgb(178,172,136)]Helen Gerrity[/]"); // Row 8
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Ben Gorman[/]"); // Row 9
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", "[white]Dante Scott[/]"); // Row 10
    ctx.Refresh();
    await Task.Delay(100);

    snapFavColor.AddRow("", ""); // Row 11 (Emptied)
    ctx.Refresh();
    await Task.Delay(100);

    // Cusom Border
    snapFavColor.Border = TableBorder.MinimalHeavyHead;
    ctx.Refresh();
    await Task.Delay(1000);
});

// AnsiConsole.Write(new BarChart()
//    .Width(60)
//    .Label("[yellow bold underline]Friends on Snap[/]")
//    .CenterLabel()
//    .AddItem("Total Friends", 56, Color.Yellow)
//    .AddItem("Boys", 48, Color.Blue1)
//    .AddItem("Girls", 8, Color.Pink1));

Console.WriteLine("\n[SYS] Snapfavcolor : ENDED");
Console.ReadKey();