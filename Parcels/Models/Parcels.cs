using System.Collections.Generic;

namespace ParcelsShippingStore.Models
{
  public class Parcel
  {
    private int[] _dimensions;
    private int _weight;
    // private int _side;

    public Parcel(int height, int width, int weight)
    {
      _dimensions = new int[4];
      _dimensions[0] = height;
      _dimensions[1] = width;
      _weight = weight;
    }

    public int[] GetDimensions()
    {
      return _dimensions;
    }

    public int GetWeight()
    {
      return _weight;
    }

    // public int GetSide()
    // {
    //   _dimensions.Add(_side)
    //   return _side;
    // }

    public void SetDimensions(int[] newDimensions)
    {
      _dimensions = newDimensions;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int Volume()
    {
      return (_dimensions[0] * 2) * (_dimensions[1] * 2);
    }

    public string CostToShip()
    {
      int volume = Volume();
      volume = volume + _weight;
      string stringVol = volume.ToString();
      return stringVol;
    }
  }
}
