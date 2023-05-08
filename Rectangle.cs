//*******************************************************************************************
//
//    Program: Rectangle
//
//*******************************************************************************************
//
//    Author: Lurinoxi                                                                   
//                                                                                         
//    Version: 1.0                                                                         
//*******************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle {
  internal class Program {
    static void Main(string[] args) {
      Rectangle r = new Rectangle(10, 4);
      r.ShowRect();
    }
  }
  class Rectangle

  {
    private int iWidth;
    private int iHeight;

    private void Init() {

      iWidth = 0;
      iHeight = 0;
    }

    public Rectangle() {
      Init();
    }
    public Rectangle(int iB, int iH) {

      Init();
      if (iB >= 0) {
        iWidth = iB;
      }
      if (iH >= 0) {
        iHeight = iH;
      }
    }
    public Rectangle(int iSize) {
      Init();

      if (iSize >= 0) {
        iWidth = iSize;
        iHeight = iSize;
      }
    }
    public int Width {
      get {
        return iWidth;
      }
      set {

        if (value > 0) {

          iWidth = value;
        }
      }
    }

    public int Height {
      get {
        return Height;
      }
      set {
        if (value > 0) {
          Height = value;
        }
      }
    }

    public void ShowRect() {
      Console.Write("+");
      for (int i = 0; i < Width; i++) {
        Console.Write("-");
      }
      Console.WriteLine("+");

      for (int j = 0; j < iHeight; j++) {
        Console.Write("I");
        for (int i = 0; i < iWidth; i++) {
          Console.Write(" ");
        }
        Console.WriteLine("I");

      }

      Console.Write("+");
      for (int i = 0; i < Width; i++) {
        Console.Write("-");
      }
      Console.WriteLine("+");
    }
  }
}
