namespace CompositeDesignPattern;

public class Folder : StructureElement
{
    public string Name { get; set; }
    public StructureElement? Parent { get; set; }
    
    public Folder(string name) 
        : base(name)
    { }
    
    private List<StructureElement> _children = new();
    public IReadOnlyList<StructureElement> Children => _children.AsReadOnly();
    
    public void AddChild(StructureElement child)
    {
        if (child != null)
        {
            child.Parent = this;
            _children.Add(child);
        }
    }

    public void RemoveChild(StructureElement child)
    {
        if (child != null)
        {
            child.Parent = null;
            _children.Remove(child);
        }
    }
}