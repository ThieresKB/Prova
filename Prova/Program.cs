using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        Atv1();
        Prossiga();
        Atv2();
        Prossiga();
        Atv3();
        Prossiga();
        Atv4();
        Prossiga();
        Atv5();
    }


    public static void Prossiga()
    {
        Console.Write("Aperte enter para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
    public static void Atv1()
    {
        Console.Write("Atividade 1:");
        // Ler a hora de início do jogo 
        Console.Write("Digite a hora de início do jogo (hora:minuto): ");
        string[] Inicio = Console.ReadLine().Split(':');
        int HoraInicial = int.Parse(Inicio[0]);
        int MinutoInicial = int.Parse(Inicio[1]);

        // Ler a hora de término do jogo 
        Console.Write("Digite a hora de término do jogo (hora:minuto): ");
        string[] Fim = Console.ReadLine().Split(':');
        int HoraFinal = int.Parse(Fim[0]);
        int MinutoFinal = int.Parse(Fim[1]);

        // Calcular a duração do jogo em minutos
        int DuracaoMinuto = (HoraFinal * 60 + MinutoFinal) - (HoraInicial * 60 + MinutoInicial);

        // Tratar caso o jogo tenha ultrapassado 24 horas
        if (DuracaoMinuto < 0)
        {
            DuracaoMinuto += 1440;
        }

        // Calcular a duração do jogo em horas e minutos
        int DuracaoHora = DuracaoMinuto / 60;
        DuracaoMinuto = DuracaoMinuto % 60;

        // Escrever a duração do jogo 
        Console.WriteLine(
            $"A duração do jogo foi de {DuracaoHora} horas e {DuracaoMinuto} minutos."
        );
    }

    public static void Atv2()
    {
        List<string> Nomes = new List<string>();
        for (int i = 0; i < 8; i++)
        {
            ListarNomes(Nomes);
            Nomes.Add(Console.ReadLine());
        }
        ListarNomes(Nomes);
        Sorteio(Nomes);

        static void Sorteio(List<string> nomes)
        {
            List<string> nomeSorteado = nomes;
            //Random sorteio = new Random();
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($"{nomes[i]} -> {nomeSorteado[i]}");
            }
        }

        static void ListarNomes(List<string> nomes)
        {
            Console.Clear();
            Console.WriteLine("Atividade 2:");
            Console.WriteLine("Partic9ipantes do amigo secreto:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.Write("Nome do participante: ");
        }
    }
    public static void Atv3()
    {
        Console.WriteLine("a) Comprexidade o(n)");
        Console.WriteLine("b) Comprexidade o(n)");
        Console.WriteLine("c) Comprexidade o(n²)");
    }

    public static void Atv4()
    {

        // Ler a altura da pessoa 
        Console.Write("Digite a altura da pessoa (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        // Ler o sexo da pessoa 
        Console.Write("Digite o sexo da pessoa (M para masculino e F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcular o peso ideal da pessoa de acordo com o sexo
        double pesoIdeal;
        if (char.ToLower(sexo) == 'M')
        {
            pesoIdeal = (72.7 + altura) - 58;
        }
        else if (char.ToLower(sexo) == 'F')
        {
            pesoIdeal = (62.1) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido.");
            return;
        }

        // Escrever o peso ideal da pessoa 
        Console.WriteLine("O peso ideal da pessoa é " + pesoIdeal + " kg.\n");

        Console.WriteLine(
            "Erros:\n" +
            "1 - falta de tratamento de erros(try catch)\n" +
            "2 - o programa para se não for marcado o sexo sem dar outra chance\n" +
            "3 - o calculo do homem e da mulher estão trocados\n" +
            "4 - \n" +
            "5 - \n"
        );
    }

    public static void Atv5()
    {
        Console.WriteLine(
            "Atividade 5:\n" +
            "1 - F\n" +
            "2 - V\n" +
            "3 - V\n" +
            "4 - V" 
        );
    }
}