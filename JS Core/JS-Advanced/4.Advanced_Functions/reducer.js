function reducer(arr) {
  console.log("Sum = " + arr.reduce((a, b) => a + b));
  console.log("Min = " + arr.reduce((a, b) => Math.min(a, b)));
  console.log("Max = " + arr.reduce((a, b) => Math.max(a, b)));
  console.log("Min = " + arr.reduce((a, b) => a * b));
  console.log("Min = " + arr.reduce((a, b) => a + "" + b));
}

reducer([1, 2, 3, 45]);
reducer([5, -3, 20, 7, 0.5]);
