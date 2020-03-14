using System;

namespace Calculator{
	public class Calculator{
		public void Main(string[] args){
			int a;
			int b;
			int pil;
			
			Console.WriteLine("Pilihan Menu Calculator \n");
			Console.WriteLine("1. Penambahan \n");
			Console.WriteLine("2. Pengurangan \n");
			Console.WriteLine("3. Perkalian \n");
			Console.WriteLine("4. Pembagian \n");
			Console.WriteLine("Masukkan Pilihan Menu : \n");
			pil = Convert.Tilnt32(Console.ReadLine());
			
			Console.WriteLine("Masukkan Nilai A : \n");
			a = Convert.Tolnt32(Console.ReadLine());
			
			Console.WriteLine("Masukkan Nilai B : \n");
			b = Convert.Tolnt32(Console.ReadLine());
			
			if(pil == 1){
				Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 2){
				Console.WriteLine("Hasil Penambahan : {0} - {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 3){
				Console.WriteLine("Hasil Penambahan : {0} / {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 4){
				Console.WriteLine("Hasil Penambahan : {0} * {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 5){
				Console.WriteLine("\nClik Any Key to Out");
				Console.ReadKey();
			}
		}
		
		static int Penambahan(int a, int b){
			return a + b;
		
		}
		
		static int Penambahan(int a, int b){
			return a - b;
		
		}
		
		static int Penambahan(int a, int b){
			return a / b;
		
		}
		
		static int Penambahan(int a, int b){
			return a * b;
		}
		
	}
	
}