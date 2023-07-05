function calcularIMC() {
    var peso = document.getElementById("peso").value;
    var altura = document.getElementById("altura").value;

    var imc = peso / (altura * altura);
    var classificacao = "";

    if (imc < 18.5) {
        classificacao = "Abaixo do peso";
    } else if (imc >= 18.5 && imc <= 24.9) {
        classificacao = "Peso normal";
    } else if (imc >= 25.0 && imc <= 29.9) {
        classificacao = "Sobrepeso";
    } else if (imc >= 30.0 && imc <= 34.9) {
        classificacao = "Obesidade grau 1";
    } else if (imc >= 35.0 && imc <= 39.9) {
        classificacao = "Obesidade grau 2";
    } else {
        classificacao = "Obesidade grau 3 (mórbida)";
    }

    var resultado = "O seu IMC é: " + imc.toFixed(2) + "<br>Classificação: " + classificacao;
    document.getElementById("resultado").innerHTML = resultado;

    var historico = localStorage.getItem("historico");

    if (historico) {
        historico = JSON.parse(historico);
    } else {
        historico = [];
    }

    var novoResultado = {
        peso: peso,
        altura: altura,
        imc: imc.toFixed(2),
        classificacao: classificacao
    };

    historico.push(novoResultado);

    localStorage.setItem("historico", JSON.stringify(historico));

}

function exibirHistorico() {
    var historico = localStorage.getItem("historico");
    if (historico) {
        historico = JSON.parse(historico);
        var historicoList = document.getElementById("historico");



        historico.forEach(function (resultado) {
            var listItem = document.createElement("li");
            var itemText = document.createTextNode("Peso: " + resultado.peso + "kg, Altura: " + resultado.altura + "m, IMC: " + resultado.imc + ", Classificação: " + resultado.classificacao);
            listItem.appendChild(itemText);
            historicoList.appendChild(listItem);
        });
    }
}

exibirHistorico();