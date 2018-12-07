let fatherCar = {
  brand: "BMW",
  model: "X5",
  color: "red",
  toString: function() {
    return this.brand + " " + this.model + " " + this.color;
  }
}

let myCar = Object.create(fatherCar);

myCar.brand = "Audi";
myCar.type = "electric";

for (const key in myCar) {
  if (!myCar.hasOwnProperty(key))
    console.log(key);
}
