function solve(matrix) {
  for (var i = 0; i < matrix.length; i++) {
    matrix[i] = {
      width: matrix[i][0],
      height: matrix[i][1],
      area: () => this.width * this.height,
      compareTo(otherRect) {
        let areaDiff = otherRect.area() - this.area();
        return areaDiff || otherRect.width - this.width;
      }
    }
  }
  return matrix.sort((a, b) => a.compareTo(b));
}

console.log(solve([
  [10, 5],
  [3, 20],
  [5, 12]
]));
