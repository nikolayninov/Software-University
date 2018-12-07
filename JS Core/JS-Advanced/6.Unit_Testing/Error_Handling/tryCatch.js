try {
  throw new Error("Range error");
  console.log("This will never execute!");
} catch (err) {
  console.log(err);
}
