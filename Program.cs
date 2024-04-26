using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            -El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.}

            -Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

            int n, conImp = 0, bPrimerN = 0, nA = 0, bOrd = 0, conNum = 0, pGact, banPor = 0, porMax = 0, nroG = 0, conOrd = 0;
            

                for(int i = 1; i <= 5; i++){
                    conNum = 0;
                    conImp = 0;
                    bOrd = 0;
                    bPrimerN = 0;
                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());
                    while(n != 0){
                        conNum++;
                        Console.WriteLine("conNum: " + conNum);
                        if(bPrimerN == 0){
                            nA = n;
                            bPrimerN = 1;
                        } else if(n > nA){
                            bOrd = 1;
                        }
                        if(!(n % 2 == 0)){
                            conImp++;
                            Console.WriteLine("conimp:" + conImp);
                        }
                        Console.WriteLine("Ingrese un numero");
                        n = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("conNum: " + conNum);
                    pGact = (conImp * 100) / conNum;
                    if(banPor == 0){
                        porMax = pGact;
                        nroG = i;
                        banPor = 1; 
                    }else if( pGact > porMax){
                        porMax = pGact;
                        nroG = i;
                    }
                    
                    if(bOrd == 0){
                        conOrd++;
                    }
                }
                Console.WriteLine("El grupo con Mayor porcentaje de impares es: " + nroG);
                Console.WriteLine("La cantidad de grupos ordenados de mayor a menor es: " + conOrd);
            }
        }
    }

