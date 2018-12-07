const expect = require("chai").expect;

function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}

describe('Create Calculator tests', function() {
  // Arrange
  let calc;

  beforeEach(function () {
    calc = createCalculator();
  })
  describe('Add', function() {
    it('Should return 0 after initialization', function() {

      //Act
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(0);
    });

    it('Should return 5 after add 5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add(5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(5);
    });
    it('Should return 5 after add "5"', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add("5");
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(5);
    });

    it('Should return 10 after add 5 add 5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add(5);
      calc.add(5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(10);
    });

    it('Should return 11 after add 5.5 add 5.5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add(5.5);
      calc.add(5.5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(11);
    });

    it('Should return -11 after add -5.5 add -5.5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add(-5.5);
      calc.add(-5.5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(-11);
    });

    it('Should return NaN after add "String"', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add("String");
      let result = calc.get();
      // Assert
      expect(result).to.be.NaN;
    });
  });

  describe('Subtract', function() {
    it('Should return 0 after initialization', function() {

      //Act
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(0);
    });

    it('Should return -5 after subtract 5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract(5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(-5);
    });

    it('Should return -5 after subtract "5"', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract("5");
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(-5);
    });

    it('Should return -10 after subtract 5 subtract 5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract(5);
      calc.subtract(5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(-10);
    });



    it('Should return 11 after subtract 5.5 subtract 5.5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract(5.5);
      calc.subtract(5.5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(-11);
    });

    it('Should return -11 after subtract -5.5 subtract -5.5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract(-5.5);
      calc.subtract(-5.5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(11);
    });

    it('Should return NaN after subtract "String"', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.subtract("String");
      let result = calc.get();
      // Assert
      expect(result).to.be.NaN;
    });
  });

  describe('Add in combination with Subtract', function() {

    it('Should return 0 after Add 5 and Subtract 5', function() {
      // Arrange
      let calc = createCalculator();
      //Act
      calc.add(5);
      calc.subtract(5);
      let result = calc.get();
      // Assert
      expect(result).to.be.equal(0);
    });
  });
});
