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
    static readonly string filepath;
    static readonly DataContractSerializer dcs;
    static readonly FileSystemWatcher watcher;
    static readonly SynchronizationContext context;
    static int ticks = 0;

    static ShoppingListAccessor()
    {
      var profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
      filepath = Path.Combine(profile, @"Dropbox\Paige\[data]\shoppingItems.xml");
      dcs = new DataContractSerializer(typeof(ShoppingList));
      context = SynchronizationContext.Current;

      var info = new FileInfo(filepath);
      watcher = new FileSystemWatcher(info.Directory.FullName, info.Name);
      watcher.EnableRaisingEvents = true;
      watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.Attributes;
      watcher.Changed += watcher_Changed;
      ReadList();
    }

    public static void Init()
    {
      ticks = Environment.TickCount;
      if (ticks > 0)
      {
        ticks = 0;
      }
    }

    static ShoppingList cachedList;
    static void watcher_Changed(object sender, FileSystemEventArgs e)
    {
      try
      {
        context.Post((x) => ReadList(), null);
      }
      catch
      {
        // let it happen....
      }
    }

    private static void ReadList()
    {
      using (var stream = File.OpenRead(filepath))
      {
        cachedList = dcs.ReadObject(stream) as ShoppingList;
      }
    }

    public static IEnumerable<ShoppingListItem> CachedItems
    {
      get 
      { 
        return cachedList.Items; 
      }
    }

    public static IEnumerable<ShoppingListItem> Items
    {
      get
      {
        if (!File.Exists(filepath))
        {
          yield break;
        }

        using (var stream = File.OpenRead(filepath))
        {
          var items =  (dcs.ReadObject(stream) as ShoppingList).Items;
          foreach (var item in items)
            yield return item;
        }
      }
      set
      {
        using (var stream = File.Create(filepath))
        {
          var list = new ShoppingList { Items = value.ToList() };
          dcs.WriteObject(stream, list);
        }
      }
    }
  }
}
