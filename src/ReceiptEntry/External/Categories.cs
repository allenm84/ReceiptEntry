using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

public static class Categories
{
  private class Node
  {
    public CategoryNode Data;
    public List<Node> Nodes;
    public Node Parent;

    public Node(CategoryNode c)
    {
      Data = c;
      Nodes = new List<Node>();
    }

    public string FullPath
    {
      get
      {
        if (Parent != null)
        {
          return Parent.FullPath + "\\" + Data.Name;
        }
        else
        {
          return Data.Name;
        }
      }
    }
  }

  private static Lazy<string> location = new Lazy<string>(() =>
  {
    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    string hostdb = Path.Combine(appData, @"Dropbox\host.db");
    string[] lines = File.ReadAllLines(hostdb);
    return Encoding.ASCII.GetString(Convert.FromBase64String(lines[1]));
  }, true);

  static DataContractSerializer dcs;
  static string filepath;

  static Categories()
  {
    dcs = new DataContractSerializer(typeof(List<CategoryNode>));
    filepath = Path.Combine(location.Value, @"Programs\CategoryHelper\tree.xml");
  }

  public static IEnumerable<CategoryNode> Nodes
  {
    get
    {
      List<CategoryNode> nodes;
      using (var stream = File.OpenRead(filepath))
      {
        nodes = dcs.ReadObject(stream) as List<CategoryNode>;
      }

      foreach (var n in nodes)
        yield return n;
    }
  }

  public static IEnumerable<CategoryPath> Paths
  {
    get
    {
      var categories = Nodes.Select(c => new Node(c)).ToList();
      var dict = categories.ToDictionary(n => n.Data.ID, n => n);

      foreach (var c in categories)
      {
        Node parent;
        string parentID = c.Data.ParentID;

        if (!string.IsNullOrEmpty(parentID) && dict.TryGetValue(parentID, out parent))
        {
          c.Parent = parent;
          parent.Nodes.Add(c);
        }
      }

      foreach (var c in categories)
      {
        if (c.Nodes.Count > 0) continue;
        yield return new CategoryPath
        {
          FullPath = c.FullPath,
          ID = c.Data.ID,
          Name = c.Data.Name,
        };
      }
    }
  }
}

public class CategoryPath
{
  public string ID { get; set; }
  public string FullPath { get; set; }
  public string Name { get; set; }
}
