function factorial(n) {
  if(n >= 0)
    return (n == 0 || n == 1) ? 1 : n * factorial(n - 1);
}
console.log(factorial(69));
