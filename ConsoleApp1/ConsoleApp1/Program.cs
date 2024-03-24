using ConsoleApp1;
using ConsoleApp1.Containers;
using ConsoleApp1.ContainerShip;
//
// // var a = 1;
// // var b = "text";
// // var c = true;
// //
// // var container = new Container()
// {
//     // CargoWeight = 10.0
// };
//
// // container.Unload(5.0);
// // container.Load(10);
// // Console.WriteLine(container.CargoWeight);
//
// var lc = new LiquidContainer(13, 2, 3, 4, 2,Container.LoadType.DANGEROUS);
// var lc2 = new LiquidContainer(14, 2, 3, 4, 1,Container.LoadType.NORMAL);
// var lc3 = new LiquidContainer(14, 2, 3, 4, 1,Container.LoadType.NORMAL);
//
// // int? number = 1;
// // number = null;
// //
// // Exception? ex = new Exception();
// // ex=null;
// //
// // if ( ex != null) Console.WriteLine(ex.Message);
// //
// // Container container = new Container(10.0);
// // Container liquiCon = new LiquidContainer(10.2);
//
// // ArrayList
// List<int> list = new List<int>() { 1, 2, 3, 4 };
// List<int> list2 = new () { 1, 2, 3, 4 };
//
//
// // HashMap
// Container container = new Container();1
List<Container> containers = null;
ContainerShip containerShip =
    new ContainerShip(1, 50, 50, 50, 50, Container.LoadType.DANGEROUS, containers, 100, 200, 200);
containerShip.CreateContainer();