# LogicaCsharp

RESOLUÇÃO DOS EXERCICIOS DO CURSO: https://github.com/acenelio/curso-logica-de-programacao-csharp

1. Estrutura sequencial - Algumas anotações sobre o curso em lógica de programação em Csharp

Tópico 1 do Curso: Algoritmo, Automação, Programa de Computador
Algoritmo: Sequencia de ativadades para solucionar alguma atividade;
Automação: Automatizar processos de um algoritmo, nem que seja uma parte;
Computador: Hardware = parte física; Software = parte lógica(programas); -> Computador automatiza a execução de algoritmos computacionais: PROCESSAMENTO DE DADOS e CÁLCULOS.


Tópico 2 do Curso -  O que é preciso para se fazer um programa de computador
- Linguagem de programação: regras léxicas e sintáticas para se escrever o programa;
- Uma IDE: software para editar e testar o programa;
- Um compilador: software para transformar o código fonte em código objeto;


Tópico 3 do Curso - Linguagem de programação, léxica e sintática
- Léxica: dis respeito à correção das palavras "isoladas" (ortografia). Ou como as coisas são escritas corretamente, exemplo: main ao invés de maim;
- Sintática: é a gramática. exemplo: "x = 2 + y" e não "x = + 2 y";,


Tópico 4 do Curso - IDE
- Depuração e testes, construção do produto final (build), sugestão de modelos (templates)


Tópico 5 do Curso - Compilação e interpretação, Código fonte e objeto, Máquina virtual
- Código fonte: é aquele escrito pelo programador em linguagem de programação
- Compilação: Transforma o "código fonte"= análise léxica+análise sinática -> em "código objeto" -> Gerador de código: construção (build) -> código executável -> execução.
- Quando aperto no PLAY para buildar o projeto, é acionado o compilador, gera o código e roda o projeto.
- Abordagem Híbrida: Código fonte é compilado (análise lexica e sintatica) -> para o bytecode -> bytecode executado pela Máquina virtual que interpreta e executa(no caso do csharp é .net.)
- Vantagens da compilação: - Velocidade do programa, auxílio do compilador antes da execução. 


Tópico 6 do Curso - Expressões aritméticas
- Operadores aritméticos: + adição, - subtração, * multiplicação, / divisão, % resto da divisão ("mod") 
- Exemplos de expressões aritméticas:
2 * 6 / 3 = 4
3 + 2 * 4 = 11
(3 + 2) * 4 = 20
60 / (3 + 2) * 4 = 48
60 / ((3 + 2) * 4 = 3

- "mod">
14%3 = 2 (resto da divisão de 14 por 3 é igual a 2)
19%5 = 4


Tópico 7 do Curso - Variáveis
- Definição informal: Em programação, uma variável é uma porção de memória (RAM) utilizada para armazenar dados durante a execução dos programas.

- Declaração de variáveis: <tipo> <nome> = <valor inicial>;
ex: int idade = 25; -> DENTRO DA PORÇÃO DE MEMÓRIA RAM, VAI ESTAR O VALOR 25, COM O NOME IDADE.
	double altura = 1.68;
	char sexo = "F";

- Variável vai possuir: Nome(ou identificador), tipo, valor e endereço(onde na memória ram a variavel vai ficar)

bit: é que pode armazenar menos valores possiveis, no total> 2, 0 ou 1

byte, sbyte, short, ushort, int, uint, long, ulong
float, double, decimal, char, string, bool, object

Tópico 8 do Curso - As três operações básicas de programação
- Programa de computador é capaz:
1. Entrada de dados; -> Quando o usuário passa dados, na qual é armazenado dentro de variáveis.
2. Processamento de dados; -> É quando o programa realiza os cálculos -> se dá por um comando chamado atribuição
3. Saída de dados. -> Programa informa dados para o usuário


Tópico 9 do Curso - Saída de dados em C#
- Exemplo de saída de dados, escolhendo a quantidade de casas decimais:

double x = 10.35784;

Console.WriteLine(x); -> RESULTADO DISSO DÁ 10,35784
Console.WriteLine(x.ToString("f2")); -> RESULTADO DISSO DÁ 10,36

- Para usar ponto ao invés de "," igual no exemplo acima:

Console.WriteLine(x.ToString("f2", CultureInfo.InvariantCulture));

Tópico 10 do Curso - Processamento de dados em C#, casting

- Boa prática: Sempre indique o tipo do número, se a expressão for de ponto flutuante(não inteira).

Para double use:
.0
Para float use:
f

Ex:
double b, B, h, area;

b= 6.0;
B = 8.0;
h = 5.0;

- Casting: conversão explicita de um tipo para outro quando o compilador não entende por exemplo que o número de resultado tem "sobra", como por exemplo: 5/2 - 2,5
 
Tópico 11 do curso - Entrada de dados

-Console.ReadLine(); -> Lê da entrada padrão até a quebra de linha. Retorna os dados lidos na forma de String, mas é possivel alterar de String para um INT por exemplo.

-Exemplo1: 

string frase = Console.ReadLine(); -> CONSOLE VAI FICAR ESPERANDO EU DIGITAR, QUANDO DIGITAR E APERTAR ENTER, VAI GRAVAR DENTRO DA VARIAVEL FRASE
Console.WriteLine(frase); -> DEPOIS QUE GRAVAR VAI SEGUIR O COMANDO WriteLine e mostrar o que eu digitei e foi gravado

-Exemplo2:

string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

Console.WriteLine("Você digitou: ");
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

-Exemplo3:
Método Split -> CONSEGUE LER MAIS DE UMA PALAVRA DIGITADA NO CONSOLE, IMAGINE QUE DIGITEI: Amarelo Laranja Cinza

Então, digitei no console: AMARELO LARANJA CINZA

string s = Console.ReadLine(); -> VAI FICAR GRAVADO AS TRES PALAVARS NA VARIAVEL S
string[] vet = s.Split(' '); -> ENTÃO A VARIAVEL VET VAI RECEBER A VARIAVEL S (AMARELO LARANJA E CINZA) E "SPLIT" CORTAR EM PARTES, O SIMBOLO [] É PARA IDENTIFICAR QUE O VET VAI RECEBER MAIS DE UMA PALAVRA
string a = v[0]; -> ENTÃO CRIO UMA VARIAVEL a QUE VAI RECEBER VETOR 1 DA POSIÇÃO 0
string b = v[1];
string c = v[2];

Console.WriteLine(a); -> para imprimir a variavel a = 
Console.WriteLine(b);
Console.WriteLine(c);

OU:

string[] vet = Console.ReadLine().Split(' '); -> Está lendo o que eu digitei em CONSOLE.READLINE() separando com o split e armazenando na variavel "vet"
string a = vet[0]; -> ENTÃO CRIO UMA VARIAVEL a QUE VAI RECEBER VETOR 1 DA POSIÇÃO 0
string b = vet[1];
string c = vet[2];

Console.WriteLine(a); -> para imprimir a variavel a = 
Console.WriteLine(b);
Console.WriteLine(c);

Tópico 12 do Curso - Entrada de dados em C Parte 2

- Ex de alteração de variável string para int:

int n1 = int.Parse(Console.ReadLine()); -> Vai ler o que eu passei como mensagem, porem essa variavel agora só pode ser inteira, e vai gravar no n1 do tipo int.
										// Se eu digitasse uma palavra como "oi" não aceitaria pois é do tipo String e não INT.

Console.WriteLine("Você digitou: "); -> Vai trazer a mensagem "Você digitou..."
Console.WriteLine(n1); -> Vai trazer o resultado do número que eu digitei em console.ReadLine();

- Ex de alteração de variável string para char, pois Console.ReadLine() , sempre lê como string

char ch = char.Parse(Console.ReadLine();

Console.WriteLine(ch);

- Ex de alteração de variável string para double, pois Console.ReadLine() , sempre lê como string

double n2 = double.Parse(Console.ReadLine()); -> Alterando a mensagem de entrada de string para o tipo double

Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture); -> Esse trecho ".ToString("F2", CultureInfo.InvariantCulture);" Serve para deixar 2 casas decimais apos o PONTO. Ficaria, exe: 4.32

- Ex: Recebendo 4 dados diferentes de uma pessoa, que SÃO> Maria, F, 23, 1.68

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0]; -> Guardando os pedacinhos em variaveis especificas: a, b, c, d
char sexo = char.Parse(vet[1]);
int idade = int.Parse[vet[2]);
double altura = double.Parse[vet[3], Culture.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura); Se eu quiser utilizar o ponto: Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture);

Tópico 13 do Curso - Funções Matemáticas em C#

Exemplos:
A = Math.Sqrt(x); -> Variável A recebe a raiz quadrada de x
A = Math.Pow(x, y); -> Variável A recebe o resultado de x elevado a y
A = Math.Abs(x); -> Variável A recebe o valor absoluto de x

Tópico 14 do Curso - Como utilizar o Debug no Visual Studio

-> Para debugar a partir de uma linha especifica, eu clico no inicio da linha da qual eu quero que inicie a debugar, vai no menu "Debug" ou "Toggle Breakpoint", 
clica na opção "Alternar Ponto de interrupção. Depois clica novamente no menu "Debug" e inicializar a depuração.
-> Vai te mostrar as variáveis, os valores de cada variavel
-> Depois voce tem 2 opções para depurar a linha especifica que voce escolheu, ou voce vai em menu do debug e aperta "pular metodo" ou aperta f10.
