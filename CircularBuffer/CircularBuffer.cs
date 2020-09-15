﻿using System;

namespace CircularBuffer
{
  public class CircularBuffer<T>
  {
    private readonly T[] buffer;
    private int size;
    public int Size
    {
        get { return size; }
        set { size = value; }
    }
    

    /// <summary>
    /// Read pointer
    /// </summary>
    private int readInd;
    public int ReadInd
    {
        get { return readInd; }
        set { readInd = value; }
    }
    
    /// <summary>
    /// Write pointer
    /// </summary>
    private int writeInd;
    public int WriteInd
    {
        get { return writeInd; }
        set { writeInd = value; }
    }
    

    public CircularBuffer(int size)
    {
      this.size = size;

      buffer = new T[size];
    }

    public void Insert(T val)
    {
      if (writeInd + 1 == readInd)
      {
        // TODO: throw err
        System.Console.WriteLine("Can't pass readInd.");
        return;
      }

      buffer[writeInd] = val;

      // inside case
      if (isAtEnd(writeInd))
      {
        writeInd = 0;
      }
      else
      {
          writeInd++;
      }
    }

    public T Remove()
    {
      // can we close the gap any further
      // if not just return current val
      if (!isCaughtUp())
      {
        // determine if ind is at end and update position
        if (isAtEnd(readInd))
        {
          readInd = 0;
        }
        else
        {
          readInd++;
        }
      }

      return buffer[readInd];
    }

    public bool isCaughtUp()
    {
      throw new InvalidOperationException();
    }

    public bool isAtEnd(int index)
    {
      return index == buffer.Length - 1;
    }

    public bool doesSomething() 
    {
      return true;
    }
  }
}
