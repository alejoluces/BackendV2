
/*
var sale = new SaleWhitTax(15, 1.16m);
var message = sale.GetInfo();
Console.WriteLine(message);
class SaleWhitTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWhitTax (decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }
    public override string GetInfo()
    {
        return "el total es " + Total + " Impuesto " + Tax;
    }
    public string GetInfo(string message)
    {
        return message;
    }
    public string GetInfo(int a)
    {
        return a.ToString();
    }

}
class Sale
{
    public decimal Total { get; set; }
    public Sale(decimal total)
    {
        Total = total;
    }
    public virtual string GetInfo()
    {
        return "El total " + Total;
    }
}

*/




/*
var sale = new Sale();
var beer = new Beer();
Some(sale);
Some(beer);


void Some(ISave save)
{
    save.Save();
}

interface ISale
{
    decimal Total { get; set; }
}
interface ISave
{
    public void Save();
}
public class Sale : ISale, ISave
{
    public decimal Total { get; set; }
    public void Save() 
    {
        Console.WriteLine("Se guardo en BD");
    }

}
public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Se guardo en Servicio");
    }

}
*/

/*
var numbers = new Mylist<int>(5);
var names = new Mylist<string>(5);
var beers = new Mylist<Beer>(3);
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
names.Add("Roberto");
names.Add("Mario");
names.Add("Daniel");
names.Add("Franco");
names.Add("Jose");
names.Add("Jesus");

beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 2
});
beers.Add(new Beer()
{
    Name = "Sol",
    Price = 2
});
beers.Add(new Beer()
{
    Name = "Polar",
    Price = 5
});
beers.Add(new Beer()
{
    Name = "Regional",
    Price = 6
});
beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 8
});
Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());

public class Mylist<T>
{
    private List<T> _list;
    private int _limit;

    public Mylist(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }
    public void Add(T item) // El numero 6 no forma parte del listado debido a esta condicional
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }
    public string GetContent() 
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + ", ";
        }
        return content;
    }
}
public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public override string ToString()
    {
        return "Nombre: " + Name + " Precio " + Price;
    }
}

*/
/*

using System.Text.Json;
var alejo = new People()
{
    Name = "Alejandro",
    Age = 37,
};
string json = JsonSerializer.Serialize(alejo);
Console.WriteLine(json);

//Deserializacion-------
string myJson = @"{
    ""Name"": ""Juan"",
    ""Age"":36
}";
People juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan.Name);
Console.WriteLine(juan.Age);
public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}

*/
// PROGRAMACION FUNCIONAL

/*
int Sub(int a , int b)
    { 
        return a - b; 
    }
Console.WriteLine(Sub(2, 1));

DateTime GetTomorrow(DateTime date)
{
    return DateTime.Now.AddDays(1);
}

*/


/*
using System;
var beer = new Beer()
{
    Name = "guinnes"
};
Console.WriteLine(beer.Name);
Console.WriteLine(toUpper(beer).Name);

Beer toUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };
    return beer2;
}
class Beer
{
    public string Name { get; set; }
}
*/




// PROGRAMACION FUNCIONAL
/*
var show = Show;
Some(show, "Hola Que talco");
string Show(string message) 
{
    return message.ToUpper();
 };
void Some(Func<string,string> fn,string message)
{
    Console.WriteLine("Hace algo aqui");
    Console.WriteLine(fn(message));
    Console.WriteLine("hace algo al final");
}

*/
// FUNCIONES LAMBDA
// EJEJMPLO:
/*
Func<int,int, int> sub = (a, b) => a - b;
Func<int,int> some = a => a * 5;
Func<int, int> some2 = a =>{
    a = a + 1;
    return a * 5;
};
Console.WriteLine(sub(212, 112));
Console.WriteLine(some(5));
Console.WriteLine(some2(5));
*/
// OTRO EJEMPLO:
/*
Some((a, b) => a + b, 6);
void Some(Func<int, int, int> fn, int number)
{
   var result = fn(number, number);
}
*/
// LINQ: es una libreria que nos permite hacer consultas a colecciones de datos. Es similar a SQL
// Ejemplo:


/*

var names = new List<string>()
{
    "Alejandro",
    "Juan",
    "Pedro",
    "Jose",
    "Daniel",
    "Franco",

};
var namesResult = from n in names
                  where n.Length > 4 && n.Length < 7
                  orderby n descending
                  select n;
var namesResult2 = names.Where(n => n.Length > 4 && n.Length < 7)
                        .OrderByDescending(n => n)
                        .Select(n => n);
// Resultado de la consulta LINQ . NamesResult y NamesResult2 son iguales

foreach (var item in namesResult)
{
    Console.WriteLine("Resultado 1 :" + item);
}
foreach (var item in namesResult2)
{
    Console.WriteLine("Resultado 2 :" + item);
}

*/


/*
class Program
{
    static void Main(string[] args)
    {
        int numberOne = 9;

        for (int i = 0; i < numberOne; i++)
        {
            //    Console.WriteLine(i);
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} Es par");
            }
            else
            {
                Console.WriteLine($"{i} Es impar");
            }
        }

    }
}


*/



//Uso de condiciona IF

/*
using System;

namespace Metodos_Learning
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());
            if (edad>=18)
            {
            Console.WriteLine("tienes carnet?");

            }
            
            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet.ToLower() == "si")
            {
                Console.WriteLine("puedes conducir vehiculo");
            } 
            else
            {
                Console.WriteLine("no puedes conducir");
            }
        }

    }
}

*/

/*
using System;

namespace Metodos_Learning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Introduce nota 1er parcial");
            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 2do parcial");
            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 3er parcial");
            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >=5 || parcial2 >= 5 || parcial3 >= 5)
            {
                float average = (parcial1 + parcial2 + parcial3) / 3;
                Console.WriteLine($"Tu promedio es : {average}");
            }
            else Console.WriteLine("Devuelve en septiembre");

        }
    }
  
}

*/

/*
using System;
using static System.Math;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();
            var miVariable = new { Nombre = "Alejo", edad = 23 };
            Console.WriteLine(miVariable.Nombre +" "+ miVariable.edad);

        }
    }
 }
*/



//Explicacion de herencias y metodos de accesos


/*
using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo Babieca = new Caballo("Babieca");
            Humano Alejandro = new Humano("Alejandro");
            Gorila Copito = new Gorila("Copito");

            Mamiferos[] almaceAnimales = new Mamiferos[4];

            Caballo[] almacenDeCaballos = new Caballo[4];

            almaceAnimales[0] = Babieca;
            almaceAnimales[1] = new Caballo("Pirri");
            almaceAnimales[2] = new Caballo("Bucéfalo");
            almaceAnimales[3] = Alejandro;



            for (int i = 0; i < almaceAnimales.Length; i++)
            {
                almaceAnimales[i].getNombre();
            }



            
            Alejandro.getNombre();
            Babieca.getNombre();
            Copito.getNombre();
            


        }
    }
    class Mamiferos
    {
        // Constructor

        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;


        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");

        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }


        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

    }

    class Humano : Mamiferos
    {

        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }

    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

    }

}

*/

// Public


/*
using System;
using System.Reflection.Metadata.Ecma335;


namespace Herencia 
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Acceso permitido

            SumandoNumero(20, 90);
            


        }
        static int SumandoNumero(int numbers1, int numbers2)
        {
           
            int result = numbers1 + numbers2;
            return result;
        }



    }
  



}
    
  */


// Private
/*
public class MiClase
{
    private string nombrePrivado;

    private void MetodoPrivado()
    {
        Console.WriteLine("Método privado llamado.");
    }

    public void MetodoAccesible()
    {
        nombrePrivado = "Alejandro"; // Acceso permitido dentro de la clase
        MetodoPrivado(); // Acceso permitido dentro de la clase
    }
}

// En otro lugar del código
MiClase miObjeto = new MiClase();
// miObjeto.nombrePrivado = "Error"; // Acceso no permitido
// miObjeto.MetodoPrivado(); // Acceso no permitido
miObjeto.MetodoAccesible(); // Acceso permitido a través de un método público
*/

// Protected
/*
public class ClaseBase
{
    protected string NombreProtegido;

    protected void MetodoProtegido()
    {
        Console.WriteLine("Método protegido llamado.");
    }
}

public class ClaseDerivada : ClaseBase
{
    public void DemostrarAcceso()
    {
        NombreProtegido = "Alejandro"; // Acceso permitido en la clase derivada
        MetodoProtegido(); // Acceso permitido en la clase derivada
    }
}

// En otro lugar del código
ClaseDerivada miObjeto = new ClaseDerivada();
miObjeto.DemostrarAcceso(); // Acceso permitido a través de un método de la clase derivada
// Accesos directos a NombreProtegido o MetodoProtegido no están permitidos fuera de la jerarquía de clases.

*/

/*

using System;
namespace PropiedadesdeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Alejandro", 37, 2000);
            empleado.Sueldo = 3000;
            Console.WriteLine(empleado.Sueldo);
        }
    }

    class Empleado
    {
        public Empleado(string nombre, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public double Sueldo
        {
            get
            {
                
                return sueldo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El sueldo no puede ser negativo");
                    sueldo = 0;
                    Console.WriteLine($"Su salario es de : {sueldo}");
                }
                else
                {
                    sueldo = value;
                }
            }
        }

        private string nombre;
        private int edad;
        private double sueldo;
    }
}
*/


/*

using System;
namespace PropiedadesdeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndMultipl sumAndMultipl = new SumAndMultipl();
            int resultado = sumAndMultipl.Sumar(1, 5, 8);   
            Console.WriteLine($"El resultado de la operacion es : {resultado}");

            Dividirnum divide = new Dividirnum();
            int resultDiv = divide.Dividir(100, 50);
            Console.WriteLine($"El resultado de la operacion dividir es : {resultDiv}");

            Restar(50, 20);

        }

        static void Restar(int numRes1, int numRes2)
        {
            int resultres = numRes1-numRes2;
            Console.WriteLine($"El resultado de la resta es :{resultres}");
            
        }

    }
    class SumAndMultipl
    {
        public int Sumar(int num1, int num2, int num3)
        {

            int result = (num1 + num2) * num3;
            return result;

        }
    }
    class Dividirnum
    {
        public int Dividir(int numOne, int numTwo) 
        {
            int resultDiv = numOne / numTwo;
            return resultDiv;
        }
    }


}
*/

// Usando Dictionary y Collection Genery

using System;
using System.Collections.Generic;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrDeAge<int> age = new ArrDeAge<int>();

            // age.Add("alejo", 41);

            Console.WriteLine(age);

        }

    }

    class ArrDeAge<T>
    {
        public  ArrDeAge()
        {
            Dictionary<string, int> age = new Dictionary<string, int>();

            age.Add("alejo", 41);
            age.Add("Leo", 55);
            age.Add("Jonh", 19);
            age.Add("Gabo", 15);

            foreach (var item in age)
            {
                Console.WriteLine(item);
            }

        }
    }

}
  
