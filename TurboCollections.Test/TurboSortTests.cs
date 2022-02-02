using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace TurboCollections.Test
{
    [TestFixture]
    public class TurboSortTests
    {
       
         public class BubbleSort
         { 
             private static TurboList<int> GiveUnordered()
             {
                 var list =  new TurboList<int>();
                 list.Add(0);
                 list.Add(3);
                 list.Add(-13);
                 list.Add(2);
                 list.Add(1000);
                 list.Add(-300);
                 return list;
             }

             [Test]
             public void ItHasCountOfZero()
             {
                 var list = GiveUnordered();
                 TurboSort.BubbleSort(list);
                 //Assert.AreEqual(new []{-300,-12,0,2,3,1000}, list);
                 CollectionAssert.IsOrdered(list);
             }
             
         }
    }
}