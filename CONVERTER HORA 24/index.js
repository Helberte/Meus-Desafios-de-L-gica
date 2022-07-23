
// var teste = '';

// function relogio(){
//   var d = new Date();
//   var t = d.toLocaleTimeString('pt-PT',{hour12: false} );
//   teste = t;
//   //setInterval(relogio, 1000);
// }

// relogio();
// console.log(teste);



var hora = '12:01:45AM';

function convertHora(s){

  let array24 = ['13','14','15','16','17','18','19','20','21','22','23'];
  let meridian = '';
  let hora = '';

  let hora24 = '';

  meridian = s.toString().substring(8,10);  
  hora = s.toString().substring(0,2);

  if(meridian === 'AM'){   
    hora24 = s; 
    if(hora === '12'){      
      hora24 = s.toString().replace('12','00').replace('AM','');
      return hora24;
    }
    else{
      return hora24.replace('AM','');
    }
  }
  else if(meridian === 'PM'){
    hora24 = s;

    if(Number(hora) >= 1){
      
      for(let i = 1; i <= array24.length; i++){
        if(Number(hora) === i){
          hora24 = s.toString().replace(hora, array24[i - 1]);
        }
      }
    }
    return hora24.replace('PM','');
  }
}

console.log(convertHora(hora));