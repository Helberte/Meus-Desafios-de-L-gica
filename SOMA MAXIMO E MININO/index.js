var arr = [1,3,5,7,9];

function somaMinMax(arr){
  var soma = 0;
  var minSoma = 0;
  var maxSoma = 0;
  var arrValues = [];

  for(let i = 0; i < arr.length; i++){
    for(let pos = 0; pos < arr.length; pos++){
      if(pos != i){
        soma += arr[pos]; 
      }
    }
    arrValues.push(soma);
    soma = 0;
  }

  minSoma = arrValues[0];

  for(let i = 0; i < arrValues.length; i++){
    if(arrValues[i] < minSoma){
      minSoma = arrValues[i];
    }
    if(arrValues[i] > maxSoma){
      maxSoma = arrValues[i];
    }
  }
  console.log(`${minSoma} ${maxSoma}`);
}

somaMinMax(arr);

// var arr = [1,2,3,4,5];


// function somaMinMax(arr){
//   let min = arr[0];
//   let max = 0;
//   let menorSoma = 0;
//   let maiorSoma = 0;

//   for(let i = 0; i < arr.length; i++){
//     if(arr[i] > max){
//       max = arr[i];
//     }
//     if(arr[i] < arr[0]){
//       min = arr[i];
//     }
//   }

//   for(let i = 0; i < arr.length; i++){
//     if(arr[i] != max){
//       menorSoma += arr[i];
//     }
//     if(arr[i] != min){
//       maiorSoma += arr[i];
//     }
//   }

//   console.log(`${parseInt(menorSoma,10)} ${parseInt(maiorSoma,10)}`);
// }

// somaMinMax(arr);