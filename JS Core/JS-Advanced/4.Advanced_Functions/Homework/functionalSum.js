function solve() {
    let sum = 0;

    function add(num) {
        sum += num;
        return add;
    }
    add.toString = function () {
        return sum;
    };
    return add;
};

let result = solve();
console.log(result(10)(1).toString());
