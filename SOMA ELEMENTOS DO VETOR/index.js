var ar = [10000005001, 10000050002, 1000000503, 100000110004, 80100000005];

function aVeryBigSum(ar) {
  var result = 0;

  for(let i = 0; i < ar.length; i++){
    result = result + ar[i];
  }

  return result;
}

console.log(aVeryBigSum(ar));