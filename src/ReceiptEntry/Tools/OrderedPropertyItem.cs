using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public class OrderedPropertyItem : INotifyPropertyChanged
  {
    private IList<string> destination;
    private PropertyIDAttribute propertyID;
    private IList siblings;

    public OrderedPropertyItem(PropertyInfo property, IList<string> destination, IList siblings)
    {
      this.destination = destination;
      this.siblings = siblings;

      propertyID = property.GetCustomAttribute<PropertyIDAttribute>();
      Name = propertyID.Display;
      Selected = false;
    }

    private bool selected;
    public bool Selected
    {
      get { return selected; }
      set
      {
        selected = value;
        UpdateIndex();
      }
    }

    private void UpdateIndex()
    {
      if (selected)
      {
        Index = (destination.Count + 1).ToString();
        destination.Add(propertyID.ID);
      }
      else
      {
        Index = string.Empty;
        destination.Remove(propertyID.ID);
        foreach (var value in siblings.OfType<OrderedPropertyItem>())
        {
          if (value == this) continue;
          value.CalculateIndex();
        }
      }
      FirePropertyChanged("Index");
    }

    private void CalculateIndex()
    {
      if (selected)
      {
        Index = (destination.IndexOf(propertyID.ID) + 1).ToString();
      }
      else
      {
        Index = string.Empty;
      }
      FirePropertyChanged("Index");
    }

    public string Index { get; private set; }
    public string Name { get; private set; }

    public event PropertyChangedEventHandler PropertyChanged;
    private void FirePropertyChanged(string propertyName)
    {
      var changed = PropertyChanged;
      if (changed != null)
      {
        changed(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    public void Notify()
    {
      FirePropertyChanged("Selected");
    }
  }
}
