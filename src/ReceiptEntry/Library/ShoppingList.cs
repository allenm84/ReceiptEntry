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
      var profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
      filepath = Path.Combine(profile, @"Dropbox\Downloads\[data]\shoppingItems.xml");
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
  }
}
