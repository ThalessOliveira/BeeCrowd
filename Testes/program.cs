//EXERCICIO 1000

using System; 

class URI {

    static void Main(string[] args) { 

        Console.WriteLine("Hello World!");

    }

}

//EXERCICIO 1001

using System; 

class URI {

    static void Main(string[] args) { 

    int X,A,B;
    
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    
    
    X = (A + B);
    
    Console.WriteLine("X = " + X);
    }

}


//EXERCICIO 1002

using System; 

class URI {

    static void Main(string[] args) { 

        double pi, raio, raioQuadrado, area;
        
        pi = 3.14159;
        
        raio = double.Parse(Console.ReadLine());
        
        raioQuadrado = Math.Pow(raio,2);
        
        area = pi * raioQuadrado;
        
        Console.WriteLine("A=" +area.ToString("F4"));
        
    }
}

//EXERCICIO 1003

using System; 

class URI {

    static void Main(string[] args) { 

    int A, B, SOMA;
    
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    
    SOMA = A + B;
    
    Console.WriteLine("SOMA = " +SOMA.ToString());
    


    }

}

//EXERCICIO 1004

using System; 

class URI {

    static void Main(string[] args) { 

    int A, B, PROD;
    
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    
    PROD = A * B;
    
    Console.WriteLine("PROD = "+PROD.ToString());

    }

}

//EXERCICIO 1005

using System; 

class URI {

    static void Main(string[] args) { 

    double A, B, MEDIA;
    
    A = Double.Parse(Console.ReadLine());
    B = Double.Parse(Console.ReadLine());
    
    MEDIA = (A * 3.5 + B * 7.5) / 11;
    
    Console.WriteLine("MEDIA = "+MEDIA.ToString("F5"));

    }

}

//EXERCICIO 1006

using System; 

class URI {

    static void Main(string[] args) { 

    double A, B, C, MEDIA;
    
    A = Double.Parse(Console.ReadLine());
    B = Double.Parse(Console.ReadLine());
    C = Double.Parse(Console.ReadLine());
    
    MEDIA = (A * 2 + B * 3 + C * 5) /10;
    
    Console.WriteLine("MEDIA = "+MEDIA.ToString("F1"));

    }

}

//EXERCICIO 1007

using System; 

class URI {

    static void Main(string[] args) { 

    int A, B, C, D, DIF;
    
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    C = int.Parse(Console.ReadLine());
    D = int.Parse(Console.ReadLine());
    
    DIF = (A*B - C*D);
    
    Console.WriteLine("DIFERENCA = "+DIF.ToString());

    }

}

//EXERCICIO 1008

using System; 

class URI {

    static void Main(string[] args) { 

    int NUMBER;
    double HOURS, AMOUNT, SALARY;
    
    NUMBER  = int.Parse(Console.ReadLine());
    HOURS = double.Parse(Console.ReadLine());
    AMOUNT = double.Parse(Console.ReadLine());
    
    SALARY = HOURS * AMOUNT;
    
    Console.WriteLine("NUMBER = "+NUMBER.ToString());
    Console.WriteLine("SALARY = U$ "+SALARY.ToString("F2"));
    }

}

//EXERCICIO 1009

using System; 

class URI {

    static void Main(string[] args) { 

    string name;
    double fixsalary, sales, salary;
    
    name = (Console.ReadLine());
    fixsalary = double.Parse(Console.ReadLine());
    sales = double.Parse(Console.ReadLine());
    
    sales = sales * 0.15;
    
    salary = fixsalary + sales;
    
    Console.WriteLine("TOTAL = R$ "+salary.ToString("F2"));

    }

}

//EXERCICIO 1010

using System; 

class URI {

    static void Main(string[] args) { 

    string [] Prod1 = Console.ReadLine().Split(' ');
    int cod1 = int.Parse(Prod1[0]);
    int qtd1 = int.Parse(Prod1[1]);
    double preco1 = double.Parse(Prod1[2]);
    
    string [] Prod2 = Console.ReadLine().Split(' ');
    int co2 = int.Parse(Prod2[0]);
    int qtd2 = int.Parse(Prod2[1]);
    double preco2 = double.Parse(Prod2[2]);
    
    Double total = (qtd1 * preco1) + (qtd2 * preco2);
    
    Console.WriteLine("VALOR A PAGAR: R$ " +total.ToString("F2"));
    
    }

}

//EXERCICIO 1011

using System; 

class URI {

    static void Main(string[] args) { 

    double raio, volume, pi;
    
    pi = 3.14159;
    
    raio = double.Parse(Console.ReadLine());
    
    volume = (4/3.0) * pi * Math.Pow(raio,3);
    
    Console.WriteLine("VOLUME = "+volume.ToString("F3"));

    }

}

//EXERCICIO 1012

using System; 

class URI {

    static void Main(string[] args) { 
        
        double pi, triangle, circle, trapezium, square, rectangle;
    
    pi = 3.14159;

    string [] area = Console.ReadLine().Split(' ');
    double A = double.Parse(area[0]);
    double B = double.Parse(area[1]);
    double C = double.Parse(area[2]);
    
        
    triangle = (A * C) / 2;
    
    circle = pi * Math.Pow(C,2);
    
    trapezium = (A+B) * (C / 2);
    
    square = Math.Pow(B,2);
    
    rectangle = A * B;
    
    Console.WriteLine("TRIANGULO: " +triangle.ToString("F3"));
    Console.WriteLine("CIRCULO: "+circle.ToString("F3"));
    Console.WriteLine("TRAPEZIO: "+trapezium.ToString("F3"));
    Console.WriteLine("QUADRADO: "+square.ToString("F3"));
    Console.WriteLine("RETANGULO: "+rectangle.ToString("F3"));
    }
}

//1013

using System; 

class URI {

    static void Main(string[] args) { 

    string [] values = Console.ReadLine().Split(' ');
    int A = int.Parse(values[0]);
    int B = int.Parse(values[1]);
    int C = int.Parse(values[2]);
    
    int AB = ((A+B)+Math.Abs(A-B))/2;
    int ABC = ((AB+C)+Math.Abs(AB-C))/2;
    
    Console.WriteLine(ABC+" eh o maior");

    }

}

//1014

using System; 

class URI {

    static void Main(string[] args) { 

    int X;
    float Y;
    
    X = int.Parse(Console.ReadLine());
    Y = float.Parse(Console.ReadLine());
    
    Y = X/Y;
    
    Console.WriteLine(Y.ToString("F3")+" km/l");

    }

}

//1015

using System; 

class URI {

    static void Main(string[] args) { 
        
        double result;

    string [] p1 = Console.ReadLine().Split(' ');
    double x1 = double.Parse(p1[0]);
    double y1 = double.Parse(p1[1]);
    
    string [] p2 = Console.ReadLine().Split(' ');
    double x2 = double.Parse(p2[0]);
    double y2 = double.Parse(p2[1]);
    
    result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    
    Console.WriteLine(result.ToString("F4"));

    }

}

//1016

using System; 

class URI {

    static void Main(string[] args) { 

        int distance;
        
        distance = int.Parse(Console.ReadLine());
        
        distance = distance *2;
        
        Console.WriteLine(distance.ToString()+" minutos");

    }

}

//1017

using System; 

class URI {

    static void Main(string[] args) { 

    double tempogastoH, vm, litros;
    
    tempogastoH = double.Parse(Console.ReadLine());
    vm = double.Parse(Console.ReadLine());
    
    litros = (tempogastoH * vm) / 12;
    
    Console.WriteLine(litros.ToString("F3"));

    }

}

//1018

using System; 

class URI {

    static void Main(string[] args) { 

    int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;
    
    N = int.Parse(Console.ReadLine());
    
    nota100 = N/100;
    resto = N % 100;
    
    nota50 = resto/50;
    resto = resto % 50;
    
    nota20 = resto/20;
    resto = resto % 20;
    
    nota10 = resto/10;
    resto = resto % 10;
    
    nota5 = resto/5;
    resto = resto % 5;
    
    nota2 = resto/2;
    resto = resto % 2;
    
    nota1 = resto/1;
    
    Console.WriteLine(N.ToString());
    Console.WriteLine(nota100.ToString()+" nota(s) de R$ 100,00");
    Console.WriteLine(nota50.ToString()+" nota(s) de R$ 50,00");
    Console.WriteLine(nota20.ToString()+" nota(s) de R$ 20,00");
    Console.WriteLine(nota10.ToString()+" nota(s) de R$ 10,00");
    Console.WriteLine(nota5.ToString()+" nota(s) de R$ 5,00");
    Console.WriteLine(nota2.ToString()+" nota(s) de R$ 2,00");
    Console.WriteLine(nota1.ToString()+" nota(s) de R$ 1,00");

    }

}

//1019

using System; 

class URI {

    static void Main(string[] args) { 

    int N, H, M, S, resto;
    
    N = int.Parse(Console.ReadLine());
    
    H = N / 3600;
    resto = N % 3600;
    
    M = resto / 60;
    resto = resto % 60;
    
    S = resto;
    
    Console.WriteLine(H+":"+M+":"+S);

    }

}

//1020