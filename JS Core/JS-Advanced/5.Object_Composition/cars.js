function solve(input) {
  let commandProcessor = (function () {
    let result = {};

    function create(arr) {
      let name = arr[0];
      if(arr.length > 2)
      {
        let inheritName = arr[2];
        result[name] = Object.create(result[inheritName]);
      }
      else {
        result[name] = {};
      }
    };

    function set(arr) {
      let objName = arr[0];
      let key = arr[1];
      let val = arr[2];

      result[objName][key] = val;
    };

    function print(arr) {
      let res = [];
      let name = arr[0];
      for (const key in result[name]) {
        res.push(key + ":" + result[name][key]);
      }
      console.log(res.join(", "));
    }

    return {create,set,print};
  })()

  for (const el of input) {
    let tokens = el.split(" ");
    let command = tokens.shift();
    commandProcessor[command](tokens);
  }
}

solve(['create c1',
  'create c2 inherit c1',
  'set c1 color red',
  'set c2 model new',
  'print c1',
  'print c2'
]);
