using System;
using System.Collections.Generic;

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public string DisplayType { get; }
    public bool IsSelfClosing { get; }
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }

    public LightElementNode(string tagName, string displayType, bool isSelfClosing)
    {
        TagName = tagName;
        DisplayType = displayType;
        IsSelfClosing = isSelfClosing;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
    }

    public override string OuterHTML
    {
        get
        {
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            string openingTag = $"<{TagName}{classes}>";
            string closingTag = IsSelfClosing ? "" : $"</{TagName}>";

            if (IsSelfClosing)
                return $"<{TagName}{classes}/>";

            return $"{openingTag}{InnerHTML}{closingTag}";
        }
    }

    public override string InnerHTML
    {
        get
        {
            string innerHtml = "";
            foreach (var child in Children)
            {
                innerHtml += child.OuterHTML;
            }
            return innerHtml;
        }
    }

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }

    public int ChildrenCount => Children.Count;
}