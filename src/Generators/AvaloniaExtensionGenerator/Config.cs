using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;

namespace AvaloniaExtensionGenerator
{
    public class Config
    {
        public string OutputPath { get; set; } = "..\\..\\Avalonia.Markup.Declarative\\ControlExtensions.Generated.cs";
        public string[] InitialNamespaces = { 
            "Avalonia.Data",
            "Avalonia.Data.Converters",
            "System.Runtime.CompilerServices" };

        public Type[] UseFullNamespace = new[]
        {
            typeof(Calendar),
            typeof(ContextMenu)
        };

        public List<Type> BaseTypes = new()
        {
            typeof(Layoutable),
            typeof(Visual),
            typeof(TemplatedControl),
            typeof(ItemsControl),
            typeof(InputElement),
            typeof(ContentControl),
        };
    }
}