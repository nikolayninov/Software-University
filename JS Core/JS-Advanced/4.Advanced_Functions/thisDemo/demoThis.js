let person = {
  name: "Stamat",
  printName: function(a, b) {
    console.log(this.name + " " + a + " " + b);
  }
}

person.printName("is not", "cool");
let alien = {
  name: "Alien"
};
let printAlien = person.printName.bind(alien);
printAlien("is", "not a person now");
let arr = ["is", "cool, but with fancy code"];

person.printName.call(alien, "is not", "cool");
person.printName.call(alien, ...arr);
person.printName.apply(alien, ["is", "cool"]);
