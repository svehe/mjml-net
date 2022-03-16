﻿
using Mjml.Net;
using System.Diagnostics;

public static class Program
{
    public static void Main(string[] args)
    {
        var mjmlRenderer = new MjmlRenderer();

        Console.WriteLine("Many Heroes");

        for (var i = 0; i < 20; i++)
        {
            Run("ManyHeroes.mjml", mjmlRenderer);
        }
    }

    private static void Run(string file, MjmlRenderer mjmlRenderer)
    {
        var text = File.ReadAllText(file);

        var watch = Stopwatch.StartNew();

        var html = mjmlRenderer.Render(text);

        watch.Stop();

        File.WriteAllText($"{file}.html", html);

        Console.WriteLine("* Elapsed after {0}. Length {1}", watch.Elapsed, html.Length);
    }
}
