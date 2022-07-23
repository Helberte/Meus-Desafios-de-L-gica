var alice = [1,2,3];
var bob = [3,2,1];

function comparaResult(a, b){
  var result = [0,0];
  var alice = 0;
  var bob = 0;

  for(let i = 0; i < a.length; i++){
    if(a[i] > b[i]){
      alice = alice + 1;
    }
    else if(b[i] > a[i]){
      bob = bob + 1;
    }
  }
  result = [alice, bob];
  return result;
}

console.log(comparaResult(alice, bob));