using System;
using System.Drawing;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercicio 1
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            // Funções Matemáticas - sqrt: raiz quadrada - pow: potenciação - abs: valor absoluto
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x); // A recebendo x, raiz quadrada de x = 3.0
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y); // A recebe Abs de y
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + A);

            Console.ReadLine();
            */

            /*
            // Exercício: Fazer um programa para ler as medidas da largura e comprimento de um terreno
            // retangular com um casa decimal, bem como o valor do metro quadrado do terreno com duas 
            // casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como
            // o valor do preço do terreno, ambos com duas casas decimais, conforme exemplo.
            //Exemplo: Entrada-> 10.0 (largura) , 30.0 (comprimento), 200.00 (valor do metro quadrado)e Saída: AREA = 300.00 PREÇO = 60000.00

            double larguraTerreno, comprimentoTerreno, precoMetroQuadrado, area, preco;

            Console.WriteLine("Informe a largura do terreno:");
            larguraTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informa o comprimento do terreno:");
            comprimentoTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o preço do metro quadrado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = larguraTerreno * comprimentoTerreno;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("A área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço do metro quadrado é: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            // 1001 DO URI
            //Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X.
            //Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e
            //não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
            // A entrada contém 2 valores inteiros.
            // Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha. Cuide para que tenha
            // um espaço antes e depois do sinal de igualdade, conforme o exemplo abaixo.

            Console.WriteLine("Informe o valor de A para somar: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B para somar: ");
            int b = int.Parse(Console.ReadLine());

            int X = a + b;

            Console.WriteLine("X = " + X);
            */

            /*
            // 1002 DO URI
            A fórmula para calcular a área de uma circunferência é: area = π.raio2.Considerando para este problema que π = 3.14159:

            -Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

            Entrada
            A entrada contém um valor de ponto flutuante(dupla precisão), no caso, a variável raio.

            Saída
            Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal.
            Utilize variáveis de dupla precisão(double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, 
            caso contrário, você receberá "Presentation Error".
           
            double raio, area, n = 3.14159;

            Console.WriteLine("Informe o raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * raio * raio;

            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
            */

            /*
            //1003 DO URI
            Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.A seguir
            escrever o valor desta variável.

            Entrada
            O arquivo de entrada contém 2 valores inteiros.

            Saída
            Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor
            correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário,
            você receberá "Presentation Error".

            Console.WriteLine("Informe o primeiro valor para somar: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor para somar: ");
            int B = int.Parse(Console.ReadLine());

            int soma = A + B;

            Console.WriteLine("SOMA= " + soma);
            */

            /*
            // URI 1004
            Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            A seguir mostre a variável PROD com mensagem correspondente.

            Entrada
            O arquivo de entrada contém 2 valores inteiros.

            Saída
            Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. 
            Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
            
            Console.WriteLine("Informe o primeiro valor para multiplicação: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor para multiplicação: ");
            int B = int.Parse(Console.ReadLine());

            int prod = A * B;

            Console.WriteLine("PROD= " + prod);
            */

            /*
            //URI 1007
            Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
            segundo a fórmula: DIFERENCA = (A * B - C * D).

            Entrada
            O arquivo de entrada contém 4 valores inteiros.

            Saída
            Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois 
            da igualdade.


            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferencaProduto = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferencaProduto);
            */

            /*
            // URI 1008
            Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula 
            o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            Entrada
            O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas 
            trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

            Saída
            Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. 
            No caso do salário, também deve haver um espaço em branco após o $.

            int employeeNumber = int.Parse(Console.ReadLine());
            int hoursAtWork = int.Parse(Console.ReadLine());
            double hourSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryCalc = hoursAtWork * hourSalary;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY =  U$" + salaryCalc.ToString("F2", CultureInfo.InvariantCulture));
            */

            // URI 1010

            // URI 1014

            // URI 1016

            // URI 1017

            // URI 1005

            // URI 1006


            Console.ReadLine();
        }
    }
}
