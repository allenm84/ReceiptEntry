using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.Tools
{
  public sealed class SaveFileSerializer
  {
    public SaveFile Read(Stream stream)
    {
      var file = new SaveFile();
      var reader = new BinaryReader(stream, Encoding.UTF8, true);
      file.Columns = ReadColumns(reader);
      file.Merchants = ReadMerchants(reader);
      file.Names = ReadHelpfulNames(reader);
      file.Receipts = ReadReceipts(reader);
      return file;
    }

    public void Write(Stream stream, SaveFile file)
    {
      var writer = new BinaryWriter(stream, Encoding.UTF8, true);
      WriteColumns(writer, file.Columns);
      WriteMerchants(writer, file.Merchants);
      WriteHelpfulNames(writer, file.Names);
      WriteReceipts(writer, file.Receipts);
    }

    private Receipt[] ReadReceipts(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var receipts = new Receipt[count];
      for (int i = 0; i < count; ++i)
      {
        var receipt = new Receipt();
        receipts[i] = receipt;

        receipt.ID = reader.ReadString();
        receipt.MerchantID = reader.ReadString();
        receipt.Date = new DateTime(reader.ReadInt64());
        receipt.Total = reader.ReadDecimal();
        receipt.Items = ReadReceiptItems(reader);
        receipt.Taxes = ReadReceiptTaxes(reader);
      }
      return receipts;
    }

    private void WriteReceipts(BinaryWriter writer, Receipt[] receipts)
    {
      writer.Write(receipts.Length);
      foreach (var r in receipts)
      {
        writer.Write(r.ID);
        writer.Write(r.MerchantID);
        writer.Write(r.Date.Ticks);
        writer.Write(r.Total);
        WriteReceiptItems(writer, r.Items);
        WriteReceiptTaxes(writer, r.Taxes);
      }
    }

    private ReceiptTax[] ReadReceiptTaxes(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var taxes = new ReceiptTax[count];
      for (int i = 0; i < count; ++i)
      {
        var tax = new ReceiptTax();
        taxes[i] = tax;

        tax.Amount = reader.ReadDecimal();
        tax.Percent = reader.ReadDecimal();
      }
      return taxes;
    }

    private void WriteReceiptTaxes(BinaryWriter writer, ReceiptTax[] taxes)
    {
      writer.Write(taxes.Length);
      foreach (var t in taxes)
      {
        writer.Write(t.Amount);
        writer.Write(t.Percent);
      }
    }

    private ReceiptItem[] ReadReceiptItems(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      int length = 0;

      var items = new ReceiptItem[count];
      for (int i = 0; i < count; ++i)
      {
        var item = new ReceiptItem();
        items[i] = item;

        var dict = new Dictionary<string, object>();
        item.Values = dict;

        length = reader.ReadInt32();
        for (int v = 0; v < length; ++v)
        {
          var key = reader.ReadString();
          var code = (TypeCode)reader.ReadInt32();

          if (code == TypeCode.Decimal)
          {
            dict[key] = reader.ReadDecimal();
          }
          else
          {
            dict[key] = reader.ReadString();
          }
        }
      }
      return items;
    }

    private void WriteReceiptItems(BinaryWriter writer, ReceiptItem[] items)
    {
      writer.Write(items.Length);
      foreach (var i in items)
      {
        writer.Write(i.Values.Count);
        foreach (var kvp in i.Values)
        {
          writer.Write(kvp.Key);
          decimal? dec = kvp.Value as decimal?;
          if (dec.HasValue)
          {
            writer.Write((int)TypeCode.Decimal);
            writer.Write(dec.Value);
          }
          else
          {
            writer.Write((int)TypeCode.String);
            writer.Write(kvp.Value as string);
          }
        }
      }
    }

    private HelpfulName[] ReadHelpfulNames(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var names = new HelpfulName[count];
      for (int i = 0; i < count; ++i)
      {
        var name = new HelpfulName();
        names[i] = name;

        name.ID = reader.ReadString();
        name.Name = reader.ReadString();
      }
      return names;
    }

    private void WriteHelpfulNames(BinaryWriter writer, HelpfulName[] names)
    {
      writer.Write(names.Length);
      foreach (var n in names)
      {
        writer.Write(n.ID);
        writer.Write(n.Name);
      }
    }

    private Merchant[] ReadMerchants(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var merchants = new Merchant[count];
      for (int i = 0; i < count; ++i)
      {
        var merchant = new Merchant();
        merchants[i] = merchant;

        merchant.ID = reader.ReadString();
        merchant.Name = reader.ReadString();
        merchant.Columns = ReadColumnReferences(reader);
      }
      return merchants;
    }

    private void WriteMerchants(BinaryWriter writer, Merchant[] merchants)
    {
      writer.Write(merchants.Length);
      foreach (var m in merchants)
      {
        writer.Write(m.ID);
        writer.Write(m.Name);
        WriteColumnReferences(writer, m.Columns);
      }
    }

    private ReceiptColumnReference[] ReadColumnReferences(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var references = new ReceiptColumnReference[count];
      for (int i = 0; i < count; ++i)
      {
        var reference = new ReceiptColumnReference();
        references[i] = reference;

        reference.ColumnID = reader.ReadString();
      }
      return references;
    }

    private void WriteColumnReferences(BinaryWriter writer, ReceiptColumnReference[] references)
    {
      writer.Write(references.Length);
      foreach (var r in references)
      {
        writer.Write(r.ColumnID);
      }
    }

    private ReceiptColumn[] ReadColumns(BinaryReader reader)
    {
      int count = reader.ReadInt32();
      var columns = new ReceiptColumn[count];
      for (int i = 0; i < count; ++i)
      {
        var column = new ReceiptColumn();
        columns[i] = column;

        column.ID = reader.ReadString();
        column.Name = reader.ReadString();
        column.Type = (ReceiptColumnType)reader.ReadInt32();
      }
      return columns;
    }

    private void WriteColumns(BinaryWriter writer, ReceiptColumn[] columns)
    {
      writer.Write(columns.Length);
      foreach (var c in columns)
      {
        writer.Write(c.ID);
        writer.Write(c.Name);
        writer.Write((int)c.Type);
      }
    }
  }
}
