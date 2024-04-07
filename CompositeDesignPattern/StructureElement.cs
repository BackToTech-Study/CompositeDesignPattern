namespace CompositeDesignPattern;

public class StructureElement
{
    public string Name { get; set; }
    public StructureElement? Parent { get; set; }
    
    public StructureElement(string name)
    {
        Name = name;
    }
    
    public List<StructureElement> GetPath()
    {
        List<StructureElement> path = new();
        path.Add(this);
        
        StructureElement? current = this;
        while (current.Parent != null)
        {
            path.Add(current.Parent);
            current = current.Parent;
        }
        
        path.Reverse();
        return path;
    }
}