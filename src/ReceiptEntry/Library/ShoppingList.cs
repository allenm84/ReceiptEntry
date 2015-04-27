using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping
{
  [DataContract(Name = "ShoppingListItem", Namespace = ShoppingList.Namespace)]
  public class ShoppingListItem
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "ShoppingList", Namespace = ShoppingList.Namespace)]
  public class ShoppingList
  {
    public const string Namespace = "http://www.mapa.com/apps/shoppingList/data";

    [DataMember(Order = 0)]
    public List<ShoppingListItem> Items { get; set; }
  }

  public static class ShoppingListAccessor
  {
    private class slades { ~slades() { SaveItems(); } }

    static readonly slades des = new slades();
    static readonly string filepath;
    static readonly DataContractSerializer dcs;
    static readonly Lazy<ShoppingList> lzList;

    static ShoppingListAccessor()
    {
      string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      string dbPath = System.IO.Path.Combine(appDataPath, "Dropbox\\host.db");
      string[] lines = System.IO.File.ReadAllLines(dbPath);
      byte[] dbBase64Text = Convert.FromBase64String(lines[1]);
      string dropbox = System.Text.ASCIIEncoding.ASCII.GetString(dbBase64Text);

      filepath = Path.Combine(dropbox, @"Downloads\[data]\shoppingItems.xml");
      dcs = new DataContractSerializer(typeof(ShoppingList));
      lzList = new Lazy<ShoppingList>(ReadList, true);
    }

    static ShoppingList ReadList()
    {
      using (var stream = File.OpenRead(filepath))
      {
        return dcs.ReadObject(stream) as ShoppingList;
      }
    }

    static void SaveItems()
    {
      using (var stream = File.Create(filepath))
      {
        dcs.WriteObject(stream, lzList.Value);
      }
    }

    public static IEnumerable<ShoppingListItem> Items
    {
      get { return lzList.Value.Items; }
      set { lzList.Value.Items = (value ?? new ShoppingListItem[0]).ToList(); }
    }

    public static ShoppingListItem GetItem(string id)
    {
      return Items.SingleOrDefault(s => s.ID == id);
    }
  }
}
