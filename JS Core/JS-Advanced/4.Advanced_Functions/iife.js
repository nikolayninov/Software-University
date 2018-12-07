let asd = [1,2,3,4,5];
(function(arr) {
  let sum = 0;
  for (const num of arr) {
    sum += num;
  }
  console.log(sum);
})(asd)
