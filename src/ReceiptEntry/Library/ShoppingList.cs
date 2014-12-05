using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
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
}
