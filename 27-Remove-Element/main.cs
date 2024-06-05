using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int[] nums = {3,2,2,3};
    int val = 3;
    int cont = 0;
    List<int> lista = new List<int>();

    foreach(int i in nums){
      lista.Add(i);
    }

    foreach(int i in lista){
      if(i == val){
        cont++;
      }
    }
    
    for(int i = 0; i < cont ; i++){
      lista.Remove(val);
    }


    foreach(int i in lista){
      Console.Write(i+" ");
    }

    Console.ReadLine();
  }
}