using System;
using System.Globalization;

namespace DataModelling;

public class Computer
{
  public string MotherBoard { get; set; } = "";
  public int CPUCores { get; set; }
  public bool HasWiFi { get; set; }
  public bool HasLTE { get; set; }
  public DateTime ReleaseDate { get; set; }
  public decimal Price { get; set; }
  public string VideoCard { get; set; } = "";
}
class Program
{
  static void Main(string[] args)
  {
    Computer myComputer = new Computer()
    {
      MotherBoard = "Asus Z690",
      CPUCores = 3,
      HasWiFi = true,
      HasLTE = false,
      ReleaseDate = DateTime.Today,
      Price = 949.99m,
      VideoCard = "AMD Radeon RX 7900 XTX"
    };
  }
}
