using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    3 - Implemente um programa em Csharp que leia as 3 notas 
    de um aluno e calcule a média final deste aluno.
    Considere que a média é ponderada e o peso das
    notas é: 2, 3 e 5, respectivamente.
    */
    Console.WriteLine ("Digite um valor para a nota 1, 2 e 3, respectivamente.");
    
    int nota1 = int.Parse(Console.ReadLine());
    int nota2 = int.Parse(Console.ReadLine());
    int nota3 = int.Parse(Console.ReadLine());

    int pesoNota = 2 + 3 + 5;
    int mediaPonderada = ((nota1*2) + (nota2*3) + (nota3*5)) /pesoNota;

    Console.WriteLine ($"O valor da média final desse aluno é: {mediaPonderada}");
  }
}