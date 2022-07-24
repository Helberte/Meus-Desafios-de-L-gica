

var notas = [84,29,57];


function arredonda(grades){  
  let cont = 0;
  let multiple = 0;
  let difference = 0;
  let notasArredondadas = [];

  for(let i = 0; i < grades.length; i++){
    let found = true;

    if(grades[i] >= 38){    
      do{
        cont += 1;

        multiple = 5 * cont;

        if(multiple > grades[i]){
          difference = multiple - grades[i];

          if(difference < 3){
            notasArredondadas.push(multiple);          
          }
          else{
            notasArredondadas.push(grades[i]);
          }
          found = false;
          cont = 0;
        }
      }while(found)
    }
    else{
      notasArredondadas.push(grades[i]);
    }
  }

  return notasArredondadas;
}

console.log(arredonda(notas));