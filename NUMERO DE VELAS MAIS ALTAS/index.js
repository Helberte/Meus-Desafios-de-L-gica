var candles = [4,4,4,7];


function retornaVelas(candles){
  let varMaior = 0;
  let quantidadeMaior = 0;

  for(let i = 0; i < candles.length; i++){
    if(candles[i] > varMaior){
      varMaior = candles[i];
    }
  }

  for(let i = 0; i < candles.length; i++){
    if(candles[i] === varMaior){
      quantidadeMaior += 1;
    }
  }

  return quantidadeMaior;
}

console.log(retornaVelas(candles));