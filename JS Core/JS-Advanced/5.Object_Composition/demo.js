function idGen() {
  let idNum = 0;
  return function () {
    return idNum++;
  }
}
