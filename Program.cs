List<object> listaobject = new List<object>();

listaobject.Add(7);
listaobject.Add(28);
listaobject.Add(-1);
listaobject.Add(true);
listaobject.Add("chair");

foreach(var result in listaobject){
    Console.WriteLine(result);
}
int sumTemp = 0;
foreach(var result in listaobject){
    if(result is int){
        sumTemp += (int)result;
    }
}
Console.WriteLine(sumTemp);