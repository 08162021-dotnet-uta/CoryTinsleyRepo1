// console.log('something over there!')

// function myfunc1(x, y) {
//   return `I have ${x} values called ${y}.`
// }


// //function expressions
// let myfunc2 = function (x, y) {
//   return x + y;
// }

// myfunc2(); // function
// myfunc2; //variable

// console.log(myfunc2(4, 5));


// let myfunc3 = myfunc2;
// console.log(myfunc3(10, 12));

// //Arrow Function/Syntax
// // if arrow function requires more than 1 line you must use {}
// let myfunc4 = () => 5;
// console.log(myfunc4())


// function callback1(param1) {
//   return `This value is EVEN... ${param1}`;
// }

// function callback2(param1) {
//   return `This value is ODD... ${param1}`;
// }


// let myfunc5 = (x, y, z) => {
//   if (x % 2 === 0) {
//     console.log(y(x));
//   }
//   else
//     console.log(z(x))
// }

// myfunc5(1, callback1, callback2)

// //TODO: STUDY IIFE

// function makeadder(x) {
//   return (y) => {
//     return x + y;
//   }
// }

// //closure and lexical scope
// let makeadderholder = makeadder(10);

// console.log(makeadderholder(5));


// function concatSentences(x) {
//   console.log(`the first call was with ${x}`)
//   return (y) => {
//     console.log(`the second call was with ${y}`)
//     return x + ' ' + y;

//   }
// }


// let concatInnerFunction = concatSentences('That dude')
// console.log(concatInnerFunction);
// console.log(concatInnerFunction('is short af'));
