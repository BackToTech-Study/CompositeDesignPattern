// See https://aka.ms/new-console-template for more information

using CompositeDesignPattern;
using File = CompositeDesignPattern.File;

var root = new Folder("");

var etc = new Folder("etc");
root.AddChild(etc);

var systemd = new Folder("systemd");
etc.AddChild(systemd);

var system = new Folder("system");
systemd.AddChild(system);

var customServiceDescription = new File("custom-service.yml");
system.AddChild(customServiceDescription);

var servicePath = customServiceDescription.GetPath().Select(e => e.Name).ToList();
Console.WriteLine(string.Join("/", servicePath));
