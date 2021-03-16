const url = 'https://viacep.com.br/ws/$cep/json/'

function findCEP(){
    var cep = document.getElementById("cep").value;
    var urlWithCEP = url.replaceAll("$cep", cep).replaceAll("-","");
    loadDoc(urlWithCEP);
}

function loadDoc(urlWithCEP){

        this.getJSON(urlWithCEP,function(err,data){

            /*console.log("logradouro: " + data.logradouro);
            console.log("Bairro: " + data.bairro);
            console.log("complemento: " + data.complemento);
            console.log("localidade:: " + data.localidade);
            console.log("UF: " + data.uf);
            console.log("ibge: " + data.ibge);
            console.log("ddd: " + data.ddd);
            console.log("siafi: " + data.siafi);*/

            document.getElementById("logradouro").value = data.logradouro
            document.getElementById("bairro").value = data.bairro
            document.getElementById("cidade").value = data.localidade
            document.getElementById("uf").value = data.uf
        });
}

var getJSON = function(url,callback){

    var xhr = new XMLHttpRequest();

    xhr.open('GET', url, true);
    xhr.responseType = 'json';
    xhr.onload = function(){
        var status = xhr.status;
        if(status === 200){
            callback(null,xhr.response);
        }else{
            callback(status,xhr.response)
        }
    };
    xhr.send();
}