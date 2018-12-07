const expect = require("chai").expect;

function isSymmetric(arr) {
  if (!Array.isArray(arr))
    return false; // Non-arrays are non-symmetric
  let reversed = arr.slice(0).reverse(); // Clone and reverse
  let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
  return equal;
}


describe('Is Symmetric', function() {
  describe('True tests', function() {
    it('Should return true for [1,2,3,2,1]', function() {
      // Arrange
      let arr = [1, 2, 3, 2, 1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(true);
    });

    it('Should return true for [-1,-2,-3,-2,-1]', function() {
      // Arrange
      let arr = [-1, -2, -3, -2, -1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(true);
    });

    it('Should return true for [1]', function() {
      // Arrange
      let arr = [1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(true);
    });

    it('Should return true for [1,"s",{},new Date(),{},"s",1]', function() {
      // Arrange
      let arr = [1,"s",{},new Date(),{},"s",1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(true);
    });
  });
  describe('False tests', function() {

    it('Should return false for [1,2,3,1]', function() {
      // Arrange
      let arr = [1, 2, 3, 1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(false);
    });

    it('Should return false for [-1,2,3,-1]', function() {
      // Arrange
      let arr = [-1, 2, 3, -1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(false);
    });

    it('Should return false for [-1,2]', function() {
      // Arrange
      let arr = [-1, 2];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(false);
    });

    it('Should return false for [1,"s",{},new Date(),"p",1]', function() {
      // Arrange
      let arr = [1, "s", {}, new Date(), "p", 1];
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(false);
    });

    it('Should return false for string', function() {
      // Arrange
      let arr = "string";
      // Act
      let result = isSymmetric(arr);
      // Assert
      expect(result).to.be.equal(false);
    });

  });
});
