using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry.DExpress
{
  public class GridViewDragAndDrop : IDisposable
  {
    private GridView mGridView;
    private GridHitInfo mHitInfo = null;

    public GridViewDragAndDrop(GridView gridView)
    {
      mGridView = gridView;
      mGridView.GridControl.AllowDrop = true;

      gridView.MouseDown += gridView_MouseDown;
      gridView.MouseMove += gridView_MouseMove;
    }

    private void gridView_MouseDown(object sender, MouseEventArgs e)
    {
      mHitInfo = null;

      var hitInfo = mGridView.CalcHitInfo(new Point(e.X, e.Y));
      if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
      {
        mHitInfo = hitInfo;
      }
    }

    private void gridView_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && mHitInfo != null)
      {
        var pt = mHitInfo.HitPoint;

        var dragSize = SystemInformation.DragSize;
        var dragPoint = new Point(pt.X - dragSize.Width / 2, pt.Y - dragSize.Height / 2);

        var dragRect = new Rectangle(dragPoint, dragSize);
        if (!dragRect.Contains(new Point(e.X, e.Y)))
        {
          mGridView.GridControl.DoDragDrop(mHitInfo, DragDropEffects.All);
          mHitInfo = null;
        }
      }
    }

    ~GridViewDragAndDrop()
    {
      Dispose(false);
      Debug.Fail("Object reached finalization!");
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    private void Dispose(bool fromDispose)
    {
      if (fromDispose)
      {
        if (mGridView != null)
        {
          mGridView.MouseDown -= gridView_MouseDown;
          mGridView.MouseMove -= gridView_MouseMove;
          mGridView = null;
        }
      }
    }
  }
}
