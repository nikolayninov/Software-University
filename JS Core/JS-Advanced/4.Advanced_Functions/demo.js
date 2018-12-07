function higherOrder(arr) {
  for (const arrElement of arr) {
    arrElement();
  }
}

higherOrder([
  () => console.info("one"),
  () => console.warn("two"),
  () => console.error("three")
]);
