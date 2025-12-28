// See https://aka.ms/new-console-template for more information
using HarmonyData;
using HarmonyLib;
using HarmonyPatchLib;
using System.Reflection;

Console.WriteLine("Hello, World!");

Harmony harmony = new("com.example.harmonypatch");
//harmony.PatchAll(typeof(HumanPatch).Assembly);

var original = typeof(Human).GetMethod("Greet");

const BindingFlags BindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
HarmonyMethod prefix = new(typeof(HumanPatch).GetMethod("Prefix", BindingAttr));
HarmonyMethod postfix = new(typeof(HumanPatch).GetMethod("Postfix", BindingAttr));
harmony.Patch(original, prefix, postfix, null, null);

Human human = new()
{
    Name = "yinyonxian",
    Age = 18
};
var greeting = human.Greet();
Console.WriteLine(greeting);

Console.ReadLine();


