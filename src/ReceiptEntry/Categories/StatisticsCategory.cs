using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;

namespace ReceiptEntry
{
  public abstract class StatisticCategory
  {
    private Lazy<string> name;
    public string Name { get { return name.Value; } }

    public StatisticCategory()
    {
      name = new Lazy<string>(GetName, true);
    }

    protected abstract string GetName();

    public abstract void InitializeProperties(GridEX grid);
    public abstract object GetDataSource();
    public abstract void SetupTables(GridEX grid);

    public virtual void Cleanup(GridEX grid)
    {
      // do nothing
    }
  }
}
