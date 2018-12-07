function print(n) {
    for (var i = 0; i < n; i++) {
        console.log(i);
    }
}

let printNum = print;

printNum(5);