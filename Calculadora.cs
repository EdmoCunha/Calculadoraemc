using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Calculadora{

    public double Soma(double x,double y){
        double resultado = x + y;
        return resultado;
    }
    public double Subtracao(double x, double y){
        return x - y;


    }
    public double Multiplicar(double x, double y){
        return x * y;
    }
     public double Divisao(double x, double y){
        return x / y;
    }
    
}