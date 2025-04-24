# 🔢 Calculadora Windows Forms
Uma calculadora desenvolvida em C# com Windows Forms que oferece operações matemáticas básicas e funções avançadas.

## 🔸 INTEGRANTES

Samuel Heitor - RM 556731<br />
Renato David - RM 555627<br />
Lucas Nicolini - RIM 55/613<br />
Gustavo Lopes - RM 556859<br />
Gabriel Jablonski - RM 555452<br />
Matheus Munuera - RM 557812

## 🔸 Recursos

Operações fundamentais: adição (➕), subtração (➖), multiplicação (✖️) e divisão (➗)
Função de raiz quadrada (√)
Função de raiz cúbica (∛)
Design intuitivo baseado em Windows Forms
Formatação automática de resultados (inteiros e decimais)

## 🔸 Instalação e Execução

Obtenha o código fonte:

git clone https://github.com/seu-usuario/calculadora-winforms.git

Inicie o Visual Studio e abra o projeto
Execute o programa com F5

## 🔸 Como Funciona
A calculadora implementa a seguinte lógica de cálculo:

Entrada de Dados:
Ao clicar nos botões numéricos, os valores são exibidos no campo de resultado (lbResult)

```

Processamento de Operações:

Ao escolher uma operação, o primeiro número e a operação são armazenados
O display é limpo para receber o segundo número
O botão de igual aciona o cálculo baseado na operação selecionada

```

Funções Matemáticas:

As operações de raiz utilizam o método calculateAndShow que aceita funções matemáticas
Raiz quadrada: implementada com Math.Sqrt
Raiz cúbica: implementada com Math.Cbrt


Tratamento de Resultados:
Se o resultado for um número inteiro, as casas decimais são removidas
Para números decimais, a formatação é aplicada com duas casas decimais

## 🔸 Tecnologias

Linguagem C# - 
Framework .NET - 
Interface Windows Forms - 
Programação orientada a eventos
