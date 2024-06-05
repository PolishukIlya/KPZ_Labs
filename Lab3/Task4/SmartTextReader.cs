using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

public class SmartTextReader : Reader
{
    public char[][] ReadFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        char[][] result = new char[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }
        return result;
    }
}