// See https://aka.ms/new-console-template for more information
using HarmonyData;
using HarmonyLib;
using HarmonyPatchLib;

Console.WriteLine("Hello, World!");

Harmony harmony = new("com.example.harmonypatch");
harmony.PatchAll(typeof(HumanPatch).Assembly);

Human human = new()
{
    Name = "yinyonxian",
    Age = 18
};
var greeting = human.Greet();
Console.WriteLine(greeting);

Console.ReadLine();


