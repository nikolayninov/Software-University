class Rectangle {
  constructor(width, height, color) {
    this._width = width;
    this._height = height;
    this._color = color;
  }
  calcArea() {
    return this._width * this._height;
  }
}

let redRect = new Rectangle(4, 4, "blue");
console.log(redRect.calcArea());
