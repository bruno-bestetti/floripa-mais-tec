// Exercicio 1

function verificarNumero() {
    var inputNumero = document.getElementById("numero");
    var numero = inputNumero.value;

    var resultado = document.getElementById("resultado1");

    if (numero > 10) {
        resultado.textContent = "O número é maior que 10";
    } else {
        resultado.textContent = "O número é menor ou igual a 10";
    }
}
// Exercicio 2

function exibirNumeros() {
    var numerosLista = document.getElementById('numeros-lista');
    for (var i = 1; i <= 20; i++) {
        var numeroItem = document.createElement('li');
        numeroItem.textContent = i;
        numerosLista.appendChild(numeroItem);
    }
}

function ocultaNumeros() {
    var numerosLista = document.getElementById('numeros-lista');
    numerosLista.innerHTML = ''; // Remove o conteúdo da lista
}

// Exercicio 3

function somarNumeros(a, b) {
    return a + b;
}

function calcularSoma() {
    var numero1 = parseFloat(document.getElementById('numero1').value);
    var numero2 = parseFloat(document.getElementById('numero2').value);
    var resultado = somarNumeros(numero1, numero2);
    document.getElementById('resultado3').innerHTML = 'A soma é: ' + resultado;
}

// Exercicio 4

var botao = document.getElementById("meuBotao");

botao.addEventListener("click", function () {
    alert("Parabéns! Obrigado por ter clicado no botão!");
});

// Exercício 5

// Recuperando a string JSON do LocalStorage
var usuarioJSON = localStorage.getItem("usuario");

// Convertendo a string JSON em um objeto JavaScript
var usuario = JSON.parse(usuarioJSON);

// Utilizando o objeto JavaScript
console.log(usuario.nome);      // Saída: Bruno
console.log(usuario.idade);     // Saída: 31
console.log(usuario.cargo); // Saída: Administrador
