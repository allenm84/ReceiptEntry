using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  partial class Database
  {
    private Database() { }

    private void Initialize()
    {
      if (merchantTypes == null)
      {
        merchantTypes = new BindingList<MerchantType>();
      }
      if (merchantTypes.Count == 0)
      {
        AddMerchantType("Fast Food");
        AddMerchantType("Gas");
        AddMerchantType("Restaurant");
        AddMerchantType("Store");
        AddMerchantType("Bill");
        AddMerchantType("Person");
        AddMerchantType("Mechanic");
        AddMerchantType("Report");
        AddMerchantType("Income");
        AddMerchantType("Other");
      }

      if (itemAlias == null)
      {
        itemAlias = new BindingList<ItemAlias>();
      }
      if (itemAlias.Count == 0)
      {
        AddItemAlias("1% Milk");
        AddItemAlias("2% Milk");
        AddItemAlias("Brocolli");
        AddItemAlias("Ham");
        AddItemAlias("Turkey");
        AddItemAlias("Chicken");
        AddItemAlias("Mozarella Cheese");
        AddItemAlias("Cheddar Cheese");
        AddItemAlias("Cream Cheese");
        AddItemAlias("Lettuce");
        AddItemAlias("Crackers");
        AddItemAlias("Fruit Snacks");
        AddItemAlias("Plums");
        AddItemAlias("Pears");
        AddItemAlias("Apples");
        AddItemAlias("Grapes");
        AddItemAlias("Blueberries");
        AddItemAlias("Strawberries");
        AddItemAlias("Easy Ups");
        AddItemAlias("Men's Clothing");
        AddItemAlias("Boy's Clothing");
        AddItemAlias("Women's Clothing");
        AddItemAlias("Girl's Clothing");
        AddItemAlias("Chips");
        AddItemAlias("Pretzels");
        AddItemAlias("Soda");
        AddItemAlias("Sports Drink");
        AddItemAlias("Water");
        AddItemAlias("Bananas");
        AddItemAlias("Carrots");
        AddItemAlias("Peppers");
        AddItemAlias("Potatoes");
        AddItemAlias("Tomatoes");
        AddItemAlias("Bagels");
        AddItemAlias("English Muffins");
        AddItemAlias("Corn");
        AddItemAlias("Mixed Vegetables");
        AddItemAlias("Salad Dressing");
        AddItemAlias("Croutons");
        AddItemAlias("Mixed Fruit");
        AddItemAlias("Video Game");
        AddItemAlias("Floss");
        AddItemAlias("Toothpaste");
        AddItemAlias("Mouthwash");
        AddItemAlias("Deodorant");
        AddItemAlias("Advil");
        AddItemAlias("Women Vitamin");
        AddItemAlias("Men Vitamin");
        AddItemAlias("Adult Vitamin");
        AddItemAlias("Children Vitamin");
        AddItemAlias("Baby Vitamin");
        AddItemAlias("Water Bottle");
        AddItemAlias("Paper Towels");
        AddItemAlias("Juice");
        AddItemAlias("Gummies");
        AddItemAlias("Hersheys Bar");
        AddItemAlias("Hersheys Kisses");
        AddItemAlias("Chocolate");
        AddItemAlias("Hamburger Buns");
        AddItemAlias("Hotdog Buns");
        AddItemAlias("Tortilla Shells");
        AddItemAlias("Taco Shells");
        AddItemAlias("Chip Sauce");
        AddItemAlias("Salsa");
        AddItemAlias("Mustard");
        AddItemAlias("Ketchup");
        AddItemAlias("Pickles");
        AddItemAlias("Cereal");
        AddItemAlias("All Purpose Flour");
        AddItemAlias("Bread Flour");
        AddItemAlias("Wheat Flour");
        AddItemAlias("Cake Mix");
        AddItemAlias("Cupcake Mix");
        AddItemAlias("Brownie Mix");
        AddItemAlias("Pancake Mix");
        AddItemAlias("Waffle Mix");
        AddItemAlias("Waffles");
        AddItemAlias("Pancakes");
        AddItemAlias("Syrup");
        AddItemAlias("Coffee");
        AddItemAlias("Coffee Creamer");
        AddItemAlias("Eggs");
        AddItemAlias("Stick Butter");
        AddItemAlias("Spread Butter");
        AddItemAlias("Toilet Paper");
        AddItemAlias("Trash Bags");
        AddItemAlias("Cheeseburger");
        AddItemAlias("Burrito");
        AddItemAlias("Quesadilla");
        AddItemAlias("Taco");
        AddItemAlias("Nachos");
        AddItemAlias("Lunchables");
        AddItemAlias("Sausage");
        AddItemAlias("Bacon");
        AddItemAlias("Fishsticks");
        AddItemAlias("Salmon");
        AddItemAlias("Tilapia");
        AddItemAlias("Burger Patties");
        AddItemAlias("Happy Meal");
        AddItemAlias("Cookies");
        AddItemAlias("Donuts");
        AddItemAlias("Tissue");
        AddItemAlias("Plastic Container");
        AddItemAlias("Peanuts");
        AddItemAlias("Cashews");
      }

      if (merchants == null)
      {
        merchants = new BindingList<Merchant>();
      }
      if (merchants.Count == 0)
      {
        AddMerchant("Walmart", "Store");
        AddMerchant("Target", "Store");
        AddMerchant("Pick 'n Save", "Store");
        AddMerchant("QuickPick", "Gas");
        AddMerchant("McDonalds", "Fast Food");
        AddMerchant("Papa Johns", "Restaurant");
        AddMerchant("Pizza Hut", "Restaurant");
      }

      if (receipts == null)
      {
        receipts = new BindingList<Receipt>();
      }
    }

    private void AddMerchant(string name, string type)
    {
      if (merchants.Any(t => t.Name == name))
        return;
      merchants.Add(new Merchant { ID = NewID(), Name = name, MerchantTypeID = merchantTypes.Single(t => t.Name == type).ID });
    }

    private void AddItemAlias(string name)
    {
      if (itemAlias.Any(t => t.Name == name))
        return;
      itemAlias.Add(new ItemAlias { ID = NewID(), Name = name });
    }

    private void AddMerchantType(string name)
    {
      if (merchantTypes.Any(t => t.Name == name))
        return;
      merchantTypes.Add(new MerchantType { ID = NewID(), Name = name });
    }
  }
}
