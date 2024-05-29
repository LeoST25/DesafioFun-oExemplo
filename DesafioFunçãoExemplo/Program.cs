using System;

class Program {
    static int CalcularDano(int ataque, int defesa) {
        //TODO: Implemente a função calcular dano
        int dano = ataque - defesa;

        if (dano < 0) {
            dano = 0;
        }
        return dano;
    }

    static void Main(string[] args) {
        Console.WriteLine("Digite o ataque do inimigo:");
        int ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua defesa:");
        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
