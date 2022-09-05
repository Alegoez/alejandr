int librasmolida=0;
int totalmolida=0;
int librascostilla=0;
int totalcostilla=0;
int libraslengua=0;
int totallengua=0;
int libraslomo=0;
int totallomo=0;
int librachuleta=0;
int totalchuleta=0;
int respuesta;
do
{
			Console.WriteLine ("Hola, que desea hoy?");
			Console.WriteLine ("1: Carne molida (Res)");
			Console.WriteLine ("2: Costilla de cerdo");
			Console.WriteLine ("3: Lengua de res");
			Console.WriteLine ("4: Lomo");
			Console.WriteLine ("5: Chuleta de cerdo");
			Console.WriteLine ("6: Nada, gracias");
			Console.WriteLine ("7: Consultar total");
             respuesta =Convert.ToInt32(Console.ReadLine());

         switch (respuesta)
 {
		    case 1: 
                    Console.WriteLine("9000 por libra");
					Console.WriteLine("Cuantas libras quiere?");		
                     librasmolida = Convert.ToInt32(Console.ReadLine());
					 totalmolida = librasmolida*9000;
                    break;
			case 2:
					Console.WriteLine("15000 por libra");
					Console.WriteLine("Cuantas libras quiere?");
				    librascostilla = Convert.ToInt32(Console.ReadLine());
					totalcostilla=librascostilla*15000;
                     break;
			case 3: 
					Console.WriteLine("8500 por libra");
					Console.WriteLine("Cuantas libras quiere?");
				    libraslengua = Convert.ToInt32(Console.ReadLine());
				    totallengua=libraslengua*8500;
                     break;
			case 4: 
					Console.WriteLine("18000 por libra");
					Console.WriteLine("Cuantas libras quiere?");
					libraslomo = Convert.ToInt32(Console.ReadLine());
				    totallomo=libraslomo*18000;
                    break;
			case 5:
					Console.WriteLine("13000 por libra");
					Console.WriteLine("Cuantas libras quiere?");
				     librachuleta = Convert.ToInt32(Console.ReadLine());
					 totalchuleta=librachuleta*13000;
                     break;
			case 6:
                    Console.WriteLine("Tenga un buen día");
                    break;
 }
       int total=totalchuleta+totalcostilla+totallengua+totallomo+totalmolida;
	   Console.WriteLine("Su total es de: "+total );
       Console.WriteLine("precione ENTER para continuar");
 } while (respuesta!=6);