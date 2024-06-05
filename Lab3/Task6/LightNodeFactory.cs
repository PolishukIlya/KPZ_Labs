using System;
using System.Collections.Generic;

public class LightNodeFactory
{
    private Dictionary<string, LightElementNode> elementNodePool;
    private Dictionary<string, LightTextNode> textNodePool;

    public LightNodeFactory()
    {
        elementNodePool = new Dictionary<string, LightElementNode>();
        textNodePool = new Dictionary<string, LightTextNode>();
    }

    public LightElementNode GetElementNode(string tagName, string displayType, bool isSelfClosing)
    {
        string key = $"{tagName}_{displayType}_{isSelfClosing}";
        if (!elementNodePool.ContainsKey(key))
        {
            elementNodePool[key] = new LightElementNode(tagName, displayType, isSelfClosing);
        }
        return elementNodePool[key];
    }

    public LightTextNode GetTextNode(string text)
    {
        if (!textNodePool.ContainsKey(text))
        {
            textNodePool[text] = new LightTextNode(text);
        }
        return textNodePool[text];
    }
}