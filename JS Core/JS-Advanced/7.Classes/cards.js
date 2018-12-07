let result = (function() {
  const Suits = {
    CLUBS: "\u2663",
    DIAMONDS: "\u2666",
    HEARTS: "\u2665",
    SPADES: "\u2660"
  }
  const Faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

  class Card {
    constructor(face, suit) {
      this.suit = suit;
      this.face = face;
    }

    get face() {
      return this._face;
    }

    get suit() {
      return this._suit;
    }

    set face(f) {
      if (Faces.indexOf(f) < 0) {
        throw new Error("Invalid face!");
      }
      this._face = f;
    }

    set suit(s) {
      if (Object.values(Suits).indexOf(s) < 0) {
        throw new Error("Invalid suit!");
      }
      this._suit = s;
    }
    toString() {
      return this._face + this._suit
    }
  }
  return {
    Suits,
    Card
  }
}())

let Card = result.Card;
let Suits = result.Suits;
let c1

try {
  c1 = new Card('2', Suits.CLUBS);
  console.log(c1.toString());
} catch (e) {
  console.log(e);
}
