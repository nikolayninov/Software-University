class Rectangle {
  constructor(width, height, color) {
    this.width = width;
    this.height = height;
    this.color = color;
  }

  calcArea() {
    return this.width * this.height;
  }
}

let redRect = new Rectangle(4, 4, 'blue');
console.log(redRect.calcArea());
