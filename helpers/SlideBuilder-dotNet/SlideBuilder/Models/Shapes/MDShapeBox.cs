﻿using System;

namespace SlideBuilder.Models.Shapes
{
  public class MDShapeBox : IMDShape
  {
    private const double SLIDE_WIDTH = 8644000.0; // 9144000.0
    private const double SLIDE_HEIGHT = 8144000.0; // 9144000.0

    public MDShapeBox(long top, long left, long width)
    {
      this.Top = top * 100 / SLIDE_HEIGHT;
      this.Left = left * 100 / SLIDE_WIDTH;
      this.Width = width * 100 / SLIDE_WIDTH;
    }

    public double Width { get; private set; }

    public double Top { get; private set; }

    public double Left { get; private set; }

    public void AddLine(string line, int indent)
    {
      throw new NotImplementedException();
    }
  }
}
