let class1 = new Object(); // object constructor syntax
let class2 = {}; // object literal syntax

class2.name = 'Cory';
console.log(class2.name)

class2.myObject = {
  fname: 'Mike',
  lname: 'Swanson'
}

function baseballPlayer(fname, lname, team, battingAvg = .030) {
  return {
    battingAvg: battingAvg,
    fname: fname,
    lname: lname,
    team: team
  }
}


let joeyD = baseballPlayer('Joe', 'Dimaggio', 'Yankees', .300);
let nolanR = baseballPlayer('Nolan', 'Ryan', 'Rangers');

console.log(joeyD.battingAvg + ' ' + nolanR.battingAvg)


class MyBirdClass3 {
  constructor(type, region) {
    this.type = type;
    this.region = region;
  }


}


let myFirstBird = new MyBirdClass3('swallow', 'Africa');
console.log(myFirstBird.type)