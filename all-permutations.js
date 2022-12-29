
function allPermutations(s, b) {
  s = s.split('').sort().join('');
  for(let i = 0; i < b.length-s.length; i++){
    let ss = b.substring(i, i+s.length);
    ss = ss.split('').sort().join('');
    if(ss == s) {
      console.log('found permuation at i=', i);
    }
  }
}


console.log(allPermutations("xacxzaa", "fxaazxacaaxzoecazxaxaz"));