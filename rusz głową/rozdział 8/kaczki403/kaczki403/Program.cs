﻿internal class Program
{
    static void Main(string[] args)
    {
        List<Duck> ducks = new List<Duck>()
            {
                new Duck { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck { Kind = KindOfDuck.Decoy, Size = 14},
                new Duck { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck { Kind = KindOfDuck.Decoy, Size = 13},
            };
        //DuckComparerBySize sizeComparer = new DuckComparerBySize();
        //ducks.Sort(sizeComparer);
        DuckComparerByKind kindComparer = new DuckComparerByKind();
        ducks.Sort(kindComparer);
        PrintDucks(ducks);
        Console.ReadKey();
    }
    public static void PrintDucks(List<Duck> ducks)
    {
        foreach (Duck duck in ducks)
            Console.WriteLine(duck.Size.ToString() + "-centymetrowa kaczka " + duck.Kind.ToString());
        Console.WriteLine("Koniec kaczek");
    }
}


public class Duck //: IComparable<Duck>
{
    public int Size;
    public KindOfDuck Kind;

    /*public int CompareTo(Duck duckToCompare)
    {
        if (this.Size > duckToCompare.Size)
            return 1;
        else if (this.Size < duckToCompare.Size) 
            return -1; 
        else 
            return 0;
    }*/
    public static void PrintDucks(List<Duck> ducks)
    {
        foreach (Duck duck in ducks)
            Console.WriteLine(duck.Size.ToString() + "-centymetrowa kaczka " + duck.Kind.ToString());
        Console.WriteLine("Koniec kaczek");
    }
}
public enum KindOfDuck
{
    Mallard,
    Muscovy,
    Decoy
}

public class DuckComparerBySize : IComparer<Duck>
{
    public int Compare(Duck x, Duck y)
    {
        if (x.Size > y.Size) return -1;
        if (x.Size < y.Size) return 1;
        return 0;
    }
}

public class DuckComparerByKind : IComparer<Duck>
{
    public int Compare(Duck x, Duck y)
    {
        if(x.Kind > y.Kind) return -1;
        if(x.Kind < y.Kind)return 1;
        return 0;
    }
}