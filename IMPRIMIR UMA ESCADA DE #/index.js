function escada(n){
  var starirs = '';

  for(let i = n; i > 0; i--){  
    const space = () => ' ';
    let tot = 0;

    for(let sp = i - 1; sp > 0; sp--){
      starirs += space();
      tot += 1;
    }

    for(let simb = tot; simb < n; simb++){
      starirs += '#';
    }

    starirs += "\n";
  }

  console.log(starirs);
}

escada(4);
