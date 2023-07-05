// Gabarito exercício 1

// Variável número:
let idade = 25;
let altura = 1.75;

// Variável string:
let nome = "FloripaMaisTec";
let mensagem = 'Olá, mundo!';

// Variável boolean:
let estaChovendo = false;
let estaFrio = true;

// Variável de array:
let numeros = [5, 4, 3, 2, 1];
let nomes = ["Douglas", "Eduardo"];
let misto = [1, "dois", true];

// Variável de objeto:
let pessoa = {
    nome: "Bruno",
    idade: 31,
    altura: 1.74
};

// Declaração variável let
let contador = 0;
contador = 1; // É permitido reatribuir o valor

// Declaração variável const
const PI = 3.1416;

// Declaração variável var
function exemplo() {
    var x = 10;
    if (true) {
        var y = 20;
        console.log(x); // 10
        console.log(y); // 20
    }
    console.log(x); // 10
    console.log(y); // 20
}

// Gabarito exercício 2

// 1. exemplo função IMC
function calcularIMC(peso, altura) {
    var alturaMetros = altura / 100;
    var imc = peso / (alturaMetros * alturaMetros);
    return imc;
}

// 2. exemplo função maior valor
function encontrarMaiorValor(array) {
    var maior = array[0];
    for (var i = 1; i < array.length; i++) {
        if (array[i] > maior) {
            maior = array[i];
        }
    }
    return maior;
}

// 3. exemplo função número par
function isNumeroPar(numero) {
    return numero % 2 === 0;
}






