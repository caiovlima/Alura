var titulo = document.querySelector('.titulo');

titulo.textContent = "Aparecida Nutricionista";
//pegando as propriedades e jogando numa variavel
var pacientes = document.querySelectorAll(".paciente");

for (var i = 0; i < pacientes.length; i++) {

    var paciente = pacientes[i];

    var tdPeso = paciente.querySelector(".info-peso");
    var peso = tdPeso.textContent;

    var tdAltura = paciente.querySelector(".info-altura");
    var altura = tdAltura.textContent;

    var tdImc = paciente.querySelector(".info-imc");

    var pesoEhValido = true;
    var alturaEhValida = true;

    if (peso <= 0 || peso >= 1000) {
        console.log("Peso inválido!");
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido";
        paciente.classList.add('paciente-invalido');
    }

    if (altura <= 0 || altura >= 3.00) {
        console.log("Altura inválida!");
        alturaEhValida = false;
        tdImc.textContent = "Altura inválida";
        
        paciente.classList.add('paciente-invalido');
    }

  if (alturaEhValida && pesoEhValido) {
        var imc = peso / (altura * altura);
        tdImc.textContent = imc.toFixed(2);
    }
}

var botaoAdicionar = document.querySelector('#adicionar-paciente');

botaoAdicionar.addEventListener('click', function(event){
    event.preventDefault(); //função pro botão não recarregar a pagina e perder os dados 
    var form = document.querySelector('#form-adiciona');

    //pegando os valores dos campos
    var nome = form.nome.value;
    var peso = form.peso.value;
    var altura = form.altura.value;
    var gordura = form.gordura.value;

    //criando uma tr de paciente
    var pacienteTr = document.createElement('tr');

    //criando as td com as propriedades que o paciente tem
    var nomeTd = document.createElement('td');
    var pesoTd = document.createElement('td');
    var alturaTd = document.createElement('td');
    var gorduraTd = document.createElement('td');
    var imcTd = document.createElement('td');

    //atribuindo para cada td, a propriedade correspondente
    nomeTd.textContent = nome;
    pesoTd.textContent = peso;
    alturaTd.textContent = altura;
    gorduraTd.textContent = gordura;

    //dizendo que a tr de paciente, possui os filhos que são as td das propriedades
    pacienteTr.appendChild(nomeTd);
    pacienteTr.appendChild(pesoTd);
    pacienteTr.appendChild(alturaTd);
    pacienteTr.appendChild(gorduraTd);

    //criando uma variavel que é associada ao id do tbody do meu html
    var tabela = document.querySelector('#tabela-pacientes');

    //associando minha tr de paciente como filho da minha tbela de pacientes, ou seja, tbody
    tabela.appendChild(pacienteTr);

});
console.log(botaoAdicionar);