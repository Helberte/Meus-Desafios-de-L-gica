




var arr = [-4, 3, -9, 0, 4, 1];

function calcRazaoProp(arr){
  var positivos = 0;
  var negativos = 0;
  var zero = 0;

  var propPositivo = 0;
  var propNegativo = 0;
  var propZero = 0;

  var tamanho = arr.length;

  for(let i = 0; i < arr.length; i++){
    if(arr[i] > 0){
      positivos++;
    }
    else if(arr[i] < 0){
      negativos++;
    }else{
      zero++;
    }
  }

  propPositivo = positivos / tamanho;
  propNegativo = negativos / tamanho;
  propZero = zero / tamanho;

  console.log(propPositivo.toFixed(6));
  console.log(propNegativo.toFixed(6));
  console.log(propZero.toFixed(6));
}

calcRazaoProp(arr);