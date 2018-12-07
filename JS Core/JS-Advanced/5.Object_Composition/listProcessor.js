function solve(arr) {
  let commandEx = (function() {
    let list = [];

    function add(item) {
      list.push(item)
    };

    function remove(item) {
      list = list.filter(el => el !== item)
    };

    function print() {
      console.log(list.join(","))
    };

    return {
      add,
      remove,
      print
    };
  })();

  for (const element of arr) {
    let [action,str] = element.split(" ");
    commandEx[action](str);
  }
}
solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);
