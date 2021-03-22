function validarDados(){
    
    var Nome = document.getElementById('nome').value;
    var Telefone = document.getElementById('telefone').value;
    var Idade = document.getElementById('idade').value;
    var Status = document.getElementById('status').value;
    var CEP = document.getElementById('cep').value;
    var Logradouro = document.getElementById('logradouro').value;
    var Bairro = document.getElementById('bairro').value;
    var Cidade = document.getElementById('cidade').value;
    var UF = document.getElementById('uf').value;
    var Numero = document.getElementById('numero').value;
    var Complemento = document.getElementById('complemento').value;
    var Salario = document.getElementById('salario').value;
    var MenorIdade = document.getElementById('menoridade');
    var Ir = document.getElementById('IR');
    var imprima = document.getElementById('imprima')   
    var Imposto = document.getElementById('Imposto')
    var conjugue = document.getElementById('Rg')

   

    var  person= {
        nome: Nome,
        telefone: Telefone, 
        idade: Idade,
        estado_civil: Status, 
        salario: Salario,
        cep: CEP,
        logradouro: Logradouro, 
        bairro: Bairro,
        cidade: Cidade,
        estado: UF,
        numero: Numero,
        complemento: Complemento       
        
    };     
    

    validarIdade();

    validarStatus();

    validarSalario();

    botaoImprimir();

    cadastroConcluido();
    
    function validarIdade(){
        if(person.idade < '18'){
            MenorIdade.innerHTML = "Impossivel cadastrar você é menor de idade!"            
        }
    }

    function validarStatus(){
        if(person.estado_civil == "casado"){
            alert("Necessario inserir os documentos do conjugue!")
            conjugue.style.display = "block"            
        }
    }

    function validarSalario(){
        if(person.salario > 10000){
            Ir.innerHTML = "Precisa declarar imposto de renda"
            Imposto.style.display = "block";       
        }        
    }  

    function botaoImprimir(){
        if(person != null){
            imprima.style.display = "block"
        }
    }  
    
    function cadastroConcluido(){
        if(person.idade >= "18"){
            alert('Cadastro concluido! Imprima o formulario e leve na five')
        }
    }
}

function Imprimir(){
    window.print();
}






