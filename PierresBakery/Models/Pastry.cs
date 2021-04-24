namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrders {get; set;}
    public Pastry(int orders)
    {
      PastryOrders = orders;
    }
    public int CalculatePrice()
    {
      int price;
      if (PastryOrders % 3 == 0)
      {
        price = 5 * (PastryOrders/3);
      }
      else
      {
        price = PastryOrders * 2;
      }
      return price;
    }
  }
}