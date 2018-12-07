function solve(arr) {
  let commandProcessor = (function() {
    let result = '';

    return {
      'append': (st) => {
        result += st;
      },
      'removeStart': (n) => {
        result = result.substring(n);
      },
      'removeEnd': (n) => {
        result = result.substring(0, result.length - n );
      },
      'print': () => {
        console.log(result);
      }
    }
  })()

  for (const cm of arr) {
    let [command, item] = cm.split(' ');
    commandProcessor[command](item);
  }
}


solve(['append 123',
  'append 45',
  'removeStart 2',
  'removeEnd 1',
  'print'
]);

solve(['append 123',
  'append 23',
  'removeStart 2',
  'removeEnd 1',
  'print'
]);
