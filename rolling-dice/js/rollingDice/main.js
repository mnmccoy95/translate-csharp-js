function main() {
  console.log("Let's roll some dice, baby!");
  console.log("---------------------------");

  function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }

  for (let i = 0; i < 10; i++){
    const die1 = getRandomInt(1,6)
    const die2 = getRandomInt(1,6)
    let message = `${die1} + ${die2} == ${die1 + die2} `
    if(die1 === die2){
      message += "DOUBLES!"
    }
    console.log(message)
  }
}

main();