using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.collections.Generic;

namespace NivelesTriangulo
{
{
    class Program
{
    static void Main(string[] args)
{
    int x, y, z;
    printf("Ingrese el Primer lado:\n");
    scanf("%d", &x);
    printf("Ingrese el segundo lado:\n");
    scanf("%d", &y);
    printf("Ingrese el tercer lado:\n");
    scanf("%d", &z);

    if (x == y && y == z) 
{
    printf("El triangulo es Equilatero\n");

}
else
{
    if (x==y || x==z || y==z)
{
    printf("El triangulo es Isosceles\n");
}
}
    else
{
        if (x != y &&  x !=z && z != y) 
{
 
     printf("El triangulo es Escaleno\n");
}
}

           }   
        }
    }
              System("Pause");
}