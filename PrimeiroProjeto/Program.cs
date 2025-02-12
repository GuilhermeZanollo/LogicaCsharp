using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;

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

            /*
            // URI 1010

            //entrada peça 1
            Console.WriteLine("Informe o código da peça 1, o número da peças 1 e o valor unitário de cada peça 1: (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vet[0]);
            int numeroPecas1 = int.Parse(vet[1]);
            double valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //entrada peça 2
            Console.WriteLine("Informe o código da peça 2, o número da peças 2 e o valor unitário de cada peça 2: (na mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            int numeroPecas2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //calculo
            double somaPecas = (numeroPecas1 * valorPeca1) + (numeroPecas2 *  valorPeca2);

            //saída peças 1 e 2
            Console.WriteLine("VALOR A PAGAR: " + somaPecas.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            // URI 1014
            Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto 
            (em litros).

            Entrada
            O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor 
            real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

            Saída
            Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".

            Console.WriteLine("Informe a distância total percorrida: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor gasto em combustível: ");
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaConsumo = X / Y;

            Console.WriteLine(mediaConsumo.ToString("F3", CultureInfo.InvariantCulture) + "km/l");
            */

            /*
            // URI 1016
            Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h e o carro Y sai com 
            velocidade constante de 90 Km/h.

            Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar um quilômetro 
            a cada 2 minutos.

            Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa distância do outro carro.

            Entrada
            O arquivo de entrada contém um número inteiro.

            Saída
            Imprima o tempo necessário seguido da mensagem "minutos".


            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2; // Dessa forma, o carro Y se afasta 1 km a cada 2 minutos (já que 30 km / 60 min = 0,5 km/min, e 1 / 0,5 = 2 minutos).

            Console.WriteLine(tempo + " minutos");
            */

            /*
            // URI 1017
            Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que 
            faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se 
            fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância 
            percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.

            Entrada
            O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média 
            durante a mesma (em km/h).

            Saída
            Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal


            int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            // aqui eh importante colocar o .0 depois do 12, ou entao fazer o casting (double)
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            */

            /*
            // URI 1005 //média ponderada
            Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média 
            do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5(A soma dos pesos portanto é 11).Assuma que cada nota pode 
            ir de 0 até 10.0, sempre com uma casa decimal.

            Entrada
            O arquivo de entrada contém 2 valores com uma casa decimal cada um.

            Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em 
            branco antes e depois da igualdade. Utilize variáveis de dupla precisão(double) e como todos os problemas, não esqueça de 
            imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            */

            /*
            // URI 1006
            Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo
            que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.Considere que cada nota pode ir de 0 até 10.0, sempre com 
            uma casa decimal.

            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão(double).

            Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em 
            branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, 
            caso contrário, você receberá "Presentation Error".

            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            */

            /* exercicio 2
            Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro
            e diagonal deste retângulo, com quatro casas decimais, conforme exemplo.
            

            double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0)); // raiz quadrada da base ao quadrado / (b, 2.0) significa base elevado ao quadrado.

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            */

            /* exercicio 3
            // Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar
            uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.

            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            int age = int.Parse(vetor[1], CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');

            string nome2 = vetor2[0];
            int age2 = int.Parse(vetor2[1], CultureInfo.InvariantCulture);

            double idadeMedia = (age + age2) / 2.0;

            Console.WriteLine("A idade média de " + nome + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");
            */

            /* exercicio 4 (URI 1019)
            Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

            Entrada
            O arquivo de entrada contém um valor inteiro N.

            Saída
            Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
            

            int tempoDuracaoSegundos = int.Parse(Console.ReadLine());

            int horas = tempoDuracaoSegundos / 3600;

            int minutos = tempoDuracaoSegundos % 3600 / 60;

            int segundos = tempoDuracaoSegundos % 60;

            Console.WriteLine(horas+":"+minutos+":"+segundos);
            */

            /* Exercicios para fazer do URI: 1009 (STRING), 1011 (CASTING), 1012 (GEOMETRIA), 1013 (ABS), 1015 (SQRT, POW)*/
            /* Exercicios DESAFIO para fazer do URI: 1018, 1020, 1021, 1061 (MOD)*/

            Console.ReadLine();
        }
    }
}
