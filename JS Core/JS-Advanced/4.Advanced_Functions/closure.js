function closure() {
  let idGenerator = 0;
  return () => {
    console.log(idGenerator++);
  }
}

let generator = closure();
generator();
generator();
generator();
generator();
generator();
generator();
generator();
generator();
generator();
