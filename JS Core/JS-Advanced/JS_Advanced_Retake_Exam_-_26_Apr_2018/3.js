class LineManager {
  constructor(arr) {
    arr.forEach(stop => {
      let noProperties = !stop.hasOwnProperty("name") || !stop.hasOwnProperty("timeToNext");
      if (noProperties || typeof stop.name != typeof "str" || stop.name.trim() == "" || typeof stop.timeToNext != typeof 2 || stop.timeToNext < 0)
        throw new Error("Invalid input for the constructor");
    })
    this._stops = arr;
    this._current_stop;

    if (this._stops.length > 0) this._current_stop = this._stops[0];
    else throw new Error('No given stops');

    this._duration = 0;
  }

  get atDepot(){
        if(this._current_stop == this._stops[this._stops.length - 1]) return true;
        return false;
    }

  get nextStopName() {
    if (this.atDepot)
      return "At depot."
    return this._stops[this._stops.indexOf(this._current_stop) + 1].name;
  }

  get currentDelay(){
    let total = 0;
        for(let e of this._stops){
            if(e == this._current_stop) break;
            total += e.timeToNext;
        }
        return this._duration - total;
  }

  arriveAtStop(mins){
    if(mins < 0) throw new Error("Minutes must be positive")
    if(this.atDepot) throw new Error("Last stop reached")
    this._duration += mins;
    this._current_stop = this._stops[this._stops.indexOf(this._current_stop) + 1];
    if(this.atDepot)
      return false
    return true
  }

  toString(){
    let result = `Line summary\n- Next stop: ${(this.atDepot) ? "Course completed" : this.nextStopName}\n- Stops covered: ${this._stops.indexOf(this._current_stop)}\n- Time on course: ${this._duration} minutes\n- Delay: ${this.currentDelay} minutes`;
    return result;
  }

}



const man = new LineManager([
    {name: 'Depot', timeToNext: 4},
    {name: 'Romanian Embassy', timeToNext: 2},
    {name: 'TV Tower', timeToNext: 3},
    {name: 'Interpred', timeToNext: 4},
    {name: 'Dianabad', timeToNext: 2},
    {name: 'Depot', timeToNext: 0},
]);

// Travel through all the stops until the bus is at depot
while(man.atDepot == false) {
    console.log(man.toString());
    man.arriveAtStop(4);
}

console.log(man.toString());

// Should throw an Error (minutes cannot be negative)
// man.arriveAtStop(-4);
// // Should throw an Error (last stop reached)
// man.arriveAtStop(4);

// Should throw an Error at initialization
// const wrong = new LineManager([
//     { name: 'Stop', timeToNext: { wrong: 'Should be a number'} }
// ]);
