async function demo () {
  console.log("First line");
  let [p1Res, p2Res] = await Promise.all([p1(), p2()]);
  console.log(p1Res);
  console.log(p2Res);
}

async function p1 () {
  return new Promise(function (resolve,reject) {
    setTimeout(function(){
      resolve("Success #1!");
    }, 1500)
  })
}

async function p2 () {
  return new Promise(function (resolve,reject) {
    setTimeout(function(){
      resolve("Success #2!");
    }, 1500)
  })
}

demo();
