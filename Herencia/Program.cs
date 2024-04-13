using Herencia.ClaseHija;

Nintendo sw = new Nintendo();

sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "Nintendo Swith";

string resultado = sw.MostrarDetallesNintendo();
Console.WriteLine(resultado);

PlayStation ps = new PlayStation();
ps.ModeloControlador = "Alfa";
ps.AnioLanzamiento = 2018;
ps.Marca = "PlayStation 5";
string resultado2 = ps.MostrarDetallesPS();
Console.WriteLine(resultado2);

Xbox x = new Xbox();
x.GamePass = false;
x.AnioLanzamiento = 2016;
x.Marca = "Xbos series x";
string resultado3 = x.MostrarDetallesXbox ();
Console.WriteLine(resultado3);




/*Instanciar la clase de clsConsola
using Herencia.ClaseBase;
using Herencia.ClaseHija;

clsConsola miConsola = new clsConsola();

miConsola.AnioLanzamiento = 1997;
miConsola.Marca = "Nintendo 64";
miConsola.MostrarDetalles();

Nintendo miNintendo = new Nintendo();

miNintendo.EsPortatil = "si";*/


