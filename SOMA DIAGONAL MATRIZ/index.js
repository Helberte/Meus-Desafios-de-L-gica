

var matriz = [[-10,-27,-37],
              [-41,-57,-67],
              [-90,-87,-97]];

// [0][2] [1][1] [2][0]


function percorreMatriz(arr){
  var diagonal1 = 0;
  var diagonal2 = 0;

  for(let linha = 0; linha < arr.length; linha++){
    for(let coluna = arr[linha].length - 1; coluna >= 0; coluna--){
      if(linha === coluna){
        diagonal1 = diagonal1 + arr[linha][coluna];
      }
      if((linha + coluna) === arr[linha].length - 1){
        diagonal2 = diagonal2 + arr[linha][coluna];
      }      
    }
  }

  if((diagonal1 - diagonal2) < 0){
    return (diagonal1 - diagonal2) * -1;
  }else{
    return diagonal1 - diagonal2;
  }
}

console.log(percorreMatriz(matriz));
