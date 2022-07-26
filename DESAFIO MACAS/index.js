


function macansLaranjas(s, t, a, b, apples, oranges){
  let casaInicial = s;
  let casaFinal = t;

  let macieira = a;
  let laranjeira  = b;

  let posicaoApples = [];
  let posicaoOranges = [];

  let quantidadeMacans = 0;
  let quantidadeLaranjas = 0;

  for(let i = 0; i < apples.length; i++){
    posicaoApples.push(macieira + apples[i]);

    if(posicaoApples[i] >= casaInicial && posicaoApples[i] <= casaFinal){
      quantidadeMacans += 1;
    } 
  }

  for(let i = 0; i < oranges.length; i++){
    posicaoOranges.push(laranjeira + oranges[i]);
    
    if(posicaoOranges[i] >= casaInicial && posicaoOranges[i] <= casaFinal){
      quantidadeLaranjas += 1;
    }
  }
  console.log(`${quantidadeMacans}\n${quantidadeLaranjas}`);
}



macansLaranjas(7, 11, 5, 15, [-2,2,1],[5,-6]);