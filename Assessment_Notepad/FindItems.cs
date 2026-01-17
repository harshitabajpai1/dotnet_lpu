//find Items
//program class
using System;
using System.Collections.Generic;
using System.Linq;
class Program{
	public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
	
	public SortedDictionary<string, long> FindItemDetails(long soldCount){
		
		//need to create a empty sorted dictionary to store the item details greater than the sold COUNT
		SortedDictionary<string, long> result = new SortedDictionary<string, long>();
		//run a loop  and comapare the items
		foreach(var item in itemDetails){
			if(item.Value > soldCount){
				result.Add( item.Key,item.Value);
			}
		}
		return result;
	}
	
	public List<string> FindMinandMaxSoldItems(){
		//list to store the minimum and maximum sold item
		List<string> result = new List<string>();
		long min = long.MaxValue;
		long max = long.MinValue;
		string minKey ="";
		string maxKey="";
		
		foreach(var item in itemDetails){
			//to check the min
			if(item.Value < min){
				min = item.Value;
				minKey = item.Key;
			}
			if(item.Value > max){
				max = item.Value;
				maxKey = item.Key;
			}
			
		}
		//firstly add the minimum value
		result.Add(minKey);
		result.Add(maxKey);
		return result;
		
	}
	public Dictionary<string, long> SortByCount(){
		var sortedCount = itemDetails.OrderBy( i => i.Value).ToDictionary(i => i.Key, i => i.Value);
		return sortedCount;
		
	}
	
	public static void Main(string[] args){
		Program pObj = new Program();
		Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());
		
		//Menu driven Application
		

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter sold count: ");
            long count = long.Parse(Console.ReadLine());

            itemDetails.Add(name, count);
        }

        Console.Write("Enter sold count to find items: ");
        long soldCount = long.Parse(Console.ReadLine());

        var answer = pObj.FindItemDetails(soldCount);
        foreach (var item in answer)
            Console.WriteLine(item.Key + " : " + item.Value);

        Console.WriteLine("Min and Max sold items:");
        var minMax = pObj.FindMinandMaxSoldItems();
        foreach (var item in minMax)
            Console.WriteLine(item);

        Console.WriteLine("Items sorted by sold count:");
        var sorted = pObj.SortByCount();
        foreach (var item in sorted)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
		
	}
	