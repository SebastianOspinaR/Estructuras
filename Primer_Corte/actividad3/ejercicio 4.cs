using System;
 namespace calcula suma;
 {
    public class Program
    {
        static void Main(String [] Args)
        {
            int N;
                double resultado=0;

                cout<<"Regalame un número entero positivo":<< endl);
                cin>>N;

                for(int i=1;i<=N;i++){
                    resultado = resultado + (1.0/i);
                }

                cout<<"El resultado de la serie es:" <<resultado<<endl;
        }
    }
    