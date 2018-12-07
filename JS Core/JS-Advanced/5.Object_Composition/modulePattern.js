let module = (function() {
  let count = 0;
  function change (amount) { return count += amount }
  function increase(num) { return change(num) };
  function decrease(num) { return change(-num) };
  function value() { return count };
  return{ increase, decrease, value };
})();
console.log(module.value());
console.log(module.increase(2));
console.log(module.decrease(2));
