using System;

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

    public void Push(T val)
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

    /// <summary>
    /// Reads the value at the current readInd moves the pointer
    /// foward by one
    /// </summary>
    /// <returns></returns>
    public T Pop()
    {

      if(isCaughtUp()){
        throw new InvalidOperationException("Cannot pass writeInd");
      }
      T temp = buffer[readInd];
      buffer[readInd++] = default(T);

      return temp;
    }

    

    public bool isCaughtUp()
    {
      return readInd == writeInd;
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
