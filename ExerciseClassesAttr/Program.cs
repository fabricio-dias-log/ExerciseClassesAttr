using System.Globalization;

namespace ExerciseClassesAttr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }
            Console.WriteLine("____________________________");
            Pessoa f1, f2;

            f1 = new Pessoa();
            f2 = new Pessoa();

            Console.WriteLine("Dados da primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segundo funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();

            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media_salario = (f1.salario + f2.salario) / 2;

            Console.WriteLine($"Salário médio: {media_salario.ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}
