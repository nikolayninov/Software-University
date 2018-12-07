function solve() {
  let summary = {};
  for (var i = 0; i < arguments.length; i++) {
    let obj = arguments[i];
    let type = typeof obj;
    console.log(`${type}: ${obj}`);
    if (!summary[type]) {
      summary[type] = 0;
    }
    summary[type]++;
  }
  let sortedTypes = [];
  for (let currType in summary) {
    sortedTypes.push([currType, summary[currType]]);
  }
  sortedTypes.sort((a, b) => b[1] - a[1]);
  for (const el of sortedTypes) {
    console.log(`${el[0]} = ${el[1]}`);
  }
}
solve(42, 15, 'cat');
