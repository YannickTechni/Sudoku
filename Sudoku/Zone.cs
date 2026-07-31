using System;
using System.Collections.Generic;
using System.Text;

internal class Zone
{
    private int data = 0;

    private string Name { get; }

    public Zone(string name)
    {
        this.Name = name;
    }

    public bool Contains(int val)
    {
        int mask = 1 << (val - 1);
        return (data & mask) == mask;
    }

    public bool Add(int val)
    {
        int anc = data;
        data |= 1 << (val - 1);
        return anc != data;
    }

    public bool Remove(int val)
    {
        int anc = data;
        data &= ~(1 << (val - 1));
        return anc != data;
    }

    public int Count()
    {
        int i = data;
        i = i - ((i >>> 1) & 0x55555555);
        i = (i & 0x33333333) + ((i >>> 2) & 0x33333333);
        i = (i + (i >>> 4)) & 0x0f0f0f0f;
        i = i + (i >>> 8);
        i = i + (i >>> 16);
        return i & 0x3f;
    }

    public override string ToString()
    {
        return $"{Name} : {data:B10}";
    }


}
