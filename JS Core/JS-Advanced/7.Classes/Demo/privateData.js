class Cat {
  constructor(name,age) {
    this.name = name;
    this.age = age;
    Object.freeze(this);
  }
}
