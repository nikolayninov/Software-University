const expect = require("chai").expect;

function sum(arr) {
  let sum = 0;
  for (num of arr) {
    sum += Number(num);
  }
  return sum;
}

describe('Sum function tests', function() {
  it("Should return 6 for [1,2,3]", function() {
    // Arrange
    let array = [1, 2, 3];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.equal(6);
  });

  it("Should return 1 for [1]", function() {
    // Arrange
    let array = [1];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.equal(1);
  });

  it("Should return 4 for [1.5,2.5]", function() {
    // Arrange
    let array = [1.5,2.5];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.equal(4);
  });

  it("Should return -4 for [-1.5,-2.5]", function() {
    // Arrange
    let array = [-1.5,-2.5];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.equal(-4);
  });

  it("Should return 0 for []", function() {
    // Arrange
    let array = [];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.equal(0);
  });

  it("Should return NaN for string", function() {
    // Arrange
    let array = ["string"];
    // Act
    let result = sum(array);
    // Assert
    expect(result).to.be.NaN;
  });
});
