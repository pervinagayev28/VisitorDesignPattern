//using System;
//using System.Collections.Generic;

//// Ziyaretçi Arayüzü
//public interface IVisitor
//{
//    void VisitCity(City city);
//    void VisitIndustry(Industry industry);
//    void VisitSightSeeing(SightSeeing sightSeeing);
//    // Diğer düğüm türlerine ait ziyaret metodları
//}

//// Ziyaretçi Sınıfı
//public class ExportVisitor : IVisitor
//{
//    public void VisitCity(City city)
//    {
//        Console.WriteLine($"Exporting data for City: {city}");
//    }

//    public void VisitIndustry(Industry industry)
//    {
//        Console.WriteLine($"Exporting data for Industry: {industry}");
//    }

//    public void VisitSightSeeing(SightSeeing sightSeeing)
//    {
//        Console.WriteLine($"Exporting data for SightSeeing: {sightSeeing}");
//    }
//    // Diğer düğüm türleri için ziyaret metodları
//}

//// Node Sınıfı
//public abstract class Node
//{
//    public abstract void Accept(IVisitor visitor);
//}

//// City Sınıfı
//public class City : Node
//{
//    public override void Accept(IVisitor visitor)
//    {
//        visitor.VisitCity(this);
//    }
//    // City sınıfına özgü özellikler ve davranışlar
//}

//// Industry Sınıfı
//public class Industry : Node
//{
//    public override void Accept(IVisitor visitor)
//    {
//        visitor.VisitIndustry(this);
//    }
//    // Industry sınıfına özgü özellikler ve davranışlar
//}

//// SightSeeing Sınıfı
//public class SightSeeing : Node
//{
//    public override void Accept(IVisitor visitor)
//    {
//        visitor.VisitSightSeeing(this);
//    }
//    // SightSeeing sınıfına özgü özellikler ve davranışlar
//}

//class Program
//{
//    static void Main()
//    {
//        // Örnek bir grafik oluştur
//        List<Node> graph = new List<Node>
//        {
//            new City(),
//            new Industry(),
//            new SightSeeing()
//            // ... diğer düğümler
//        };

//        // Müşteri Kodu
//        var exportVisitor = new ExportVisitor();
//        foreach (Node node in graph)
//        {
//            node.Accept(exportVisitor);
//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//// Visitor arayüzü
//interface IVisitor
//{
//    void Visit(ConcreteElementA elementA);
//    void Visit(ConcreteElementB elementB);
//}

//// Somut Visitor
//class ConcreteVisitor : IVisitor
//{
//    public void Visit(ConcreteElementA elementA)
//    {
//        Console.WriteLine("Visiting ConcreteElementA");
//    }

//    public void Visit(ConcreteElementB elementB)
//    {
//        Console.WriteLine("Visiting ConcreteElementB");
//    }
//}

//// Element arayüzü
//interface IElement
//{
//    void Accept(IVisitor visitor);
//}

//// Somut Element sınıfları
//class ConcreteElementA : IElement
//{
//    public void Accept(IVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//}

//class ConcreteElementB : IElement
//{
//    public void Accept(IVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//}

//// ObjectStructure sınıfı
//class ObjectStructure
//{
//    private List<IElement> elements = new List<IElement>();

//    public void Attach(IElement element)
//    {
//        elements.Add(element);
//    }

//    public void Accept(IVisitor visitor)
//    {
//        foreach (var element in elements)
//        {
//            element.Accept(visitor);
//        }
//    }
//}

//// Kullanım
//class Program
//{
//    static void Main()
//    {
//        ObjectStructure objectStructure = new ObjectStructure();
//        objectStructure.Attach(new ConcreteElementA());
//        objectStructure.Attach(new ConcreteElementB());

//        IVisitor visitor = new ConcreteVisitor();
//        objectStructure.Accept(visitor);

//        // Çıktı:
//        // Visiting ConcreteElementA
//        // Visiting ConcreteElementB
//    }
//}



//************************ extended practic **********************************



//using System;
//using System.Collections.Generic;

//// Visitor arayüzü
//interface IVisitor
//{
//    void Visit(IElement anyElement);
//}

//// Somut Visitor
//class ConcreteVisitor : IVisitor
//{
//    public void Visit(IElement anyElement)
//    {
//        anyElement.foo();
//    }
//}

//// Element arayüzü
//interface IElement
//{
//    void foo();
//    void Accept(IVisitor visitor);
//}

//// Somut Element sınıfları
//class ConcreteElementA : IElement
//{
//    public void Accept(IVisitor visitor)
//    {
//        visitor.Visit(this);
//    }

//    public void foo()
//    {
//        Console.WriteLine("I am Element A");
//    }
//}

//class ConcreteElementB : IElement
//{
//    public void Accept(IVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//    public void foo()
//    {
//        Console.WriteLine("I am Element B");
//    }
//}

//// ObjectStructure sınıfı
//class ObjectStructure
//{
//    private List<IElement> elements = new List<IElement>();

//    public void Attach(IElement element)
//    {
//        elements.Add(element);
//    }

//    public void Accept(IVisitor visitor)
//    {
//        foreach (var element in elements)
//        {
//            element.Accept(visitor);
//        }
//    }
//}

//// Kullanım
//class Program
//{
//    static void Main()
//    {
//        ObjectStructure objectStructure = new ObjectStructure();
//        objectStructure.Attach(new ConcreteElementA());
//        objectStructure.Attach(new ConcreteElementB());

//        IVisitor visitor = new ConcreteVisitor();
//        objectStructure.Accept(visitor);


//    }
//}



