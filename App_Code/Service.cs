using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<Work> DoWork()
    {
        Work[] w = new Work[2];
        w[0] = new Work();
        w[0].name = "aaaa";
        w[0].age = 123;
        w[1] = new Work();
        w[1].name = "bbb";
        w[1].age = 321;
        return w.ToList();
    }

    public static List<string> myValues = new List<string>()
    {
        "Apple", "Orange", "Apricot", "Banana", "Grape", "Peach", "Plum"
    };


    public List<Work> GetNav()
    {
      
        using (MShopDataContext context = new MShopDataContext())
       {
            
                var categories = (from row in context.Categories select new Work( row.name , row.id)).ToList();



                return categories;            

        }
        //var items = (from v in myValues

        //             select v);

        //return items;


    }

 

}

public class Work
{
    public Work() { }
    public Work(string name, int age) {
        this.name = name;
        this.age = age;
    }
    public string name { set; get; }
    public int age { set; get; }
}

