using System;
using System.Globalization;

namespace Sess3RecapLogica
{
    //03-recapitulacao-de-logica-de-programacao.pdf, pag 4
    class Demo
    {
        public void Imprime()
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.Write("");
        }

        //exercicios1-estrutura-sequencial.pdf, Exercicio 01
        //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        //mensagem explicativa, conforme exemplos.
        public void Soma()
        {
            Console.WriteLine("Entre com o primeiro numero ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo numero ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma entre eles e:  ");
            Console.WriteLine(num1 + num2);
        }


        //exercicios1-estrutura-sequencial.pdf, Exercicio 02
        //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        //casas decimais conforme exemplos.
        public void AreaCirculo()
        {
            const double pi = 3.14159;
            char op = 's';

            while (op == 's')
            {
                Console.WriteLine("Entre com o valor do raio ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("A area do circulo eh:  ");
                Console.WriteLine(pi * raio * raio);//literal com virgula
                Console.WriteLine((pi * raio * raio).ToString("F4", CultureInfo.InvariantCulture));//com 4 casas decimais e ponto
                Console.WriteLine();
                Console.WriteLine("Digite s para continuar ou n para sair");
                op = char.Parse(Console.ReadLine());

            }

        }

        //exercicios1-estrutura-sequencial.pdf, Exercicio 03
        //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
        //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        public void Diferenca()
        {
            int a, b, c, d;
            char op = 's';
            while (op == 's')
            {

                    Console.WriteLine("Entre com um numero: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com um numero: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com um numero: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com um numero: ");
                    d = int.Parse(Console.ReadLine());

                    Console.WriteLine("A diferenca entre os produtos eh: ");
                    Console.WriteLine((a * b) - (c * d));

                    Console.WriteLine("Digite s para continuar ou n para sair");
                    op = char.Parse(Console.ReadLine());
            }
        }


        //exercicios1-estrutura-sequencial.pdf, Exercicio 04
        //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
        //decimais
        public void Salario()
        {
            int mat;
            double horas, vlrHora;

            Console.WriteLine("Informe a matricula do funcionario: ");
            mat = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quant de horas trabalhadas do funcionario: ");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora do funcionario: ");
            vlrHora = double.Parse(Console.ReadLine());
            Console.WriteLine("O funcionario cujo a matricula eh: " + mat + " tera o salario no valor de: " + (horas * vlrHora).ToString("F4"));//concatenado
            Console.WriteLine("O funcionario cujo a matricula eh: {0} tera o salario no valor de: {1}", mat, (horas * vlrHora).ToString("F4"));//placeholder
            Console.WriteLine($"O funcionario cujo a matricula eh: {mat} tera o salario no valor de: {(horas * vlrHora).ToString("F4")}");//interpolado
        }


        //exercicios1-estrutura-sequencial.pdf, Exercicio 05
        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        public void Pecas()
        {
            int c1, c2, q1, q2;
            double v1, v2, calculo1, calculo2, total;
            string[] valores;

            Console.WriteLine("Informe o codigo, quantidade e valor da primeira peca: ");
            valores = Console.ReadLine().Split(' ');
            c1 = int.Parse(valores[0]);
            q1 = int.Parse(valores[1]); 
            v1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o codigo, quantidade e valor da segunda peca: ");
            valores = Console.ReadLine().Split(' ');
            c2 = int.Parse(valores[0]);
            q2 = int.Parse(valores[1]);
            v2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            calculo1 = q1 * v1;
            calculo2 = q2 * v2;

            total = calculo1 + calculo2;

            Console.WriteLine("Valor a ser pago pela peca "+c1+": " + calculo1.ToString("F2"));
            Console.WriteLine("Valor a ser pago pela peca "+c2+": " + calculo2.ToString("F2"));
            Console.WriteLine("Valor total: " + total.ToString("F2"));
        }


        //exercicios1-estrutura-sequencial.pdf, Exercicio 06
        //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e mostre:
        //a) a área do triângulo retângulo que tem A por base e C por altura.
        //b) a área do círculo de raio C. (pi = 3.14159)
        //c) a área do trapézio que tem A e B por bases e C por altura.
        //d) a área do quadrado que tem lado B.
        //e) a área do retângulo que tem lados A e B.
        public void FigurasGeometricas()
        {

        }
    }
}