using System;

class Program {
  public static void Main (string[] args) {
    int [] respuesta = new int[2];
    bool terminar = false;
    int [] lista = {-3,4,3,90};
    int target = 0;

    for(int i = 0; i < lista.Length; i++){
      int suma = 0;

      for(int j = 0; j < lista.Length; j++){
        
        if(i != j){
          suma = lista[i] + lista[j];
          
          if(suma == target){
            respuesta[0] = i;
            respuesta[1] = j;
            terminar = true;
            break;
          }
        }
        if(terminar == true){
          break;
        }
      }
      if(terminar == true){
        break;
      }
    }

    Console.WriteLine($"({lista[respuesta[0]]})+({lista[respuesta[1]]}) = {target}");
    
    Console.ReadLine();
  }
}