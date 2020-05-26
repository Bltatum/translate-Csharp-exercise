function main() {
  // Put your code here
  console.log("Lets roll the dice!")
  console.log("-------------------")

  const roll = (min, max) => {
    min = Math.ceil(1);
    max = Math.floor(6);
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }


  for (let i = 0; i < 10; i++) {
    const die1 = roll();
    const die2 = roll();

    let message = `${die1} + ${die2} = ${die1 + die2}`
    if (die1 === die2) {
      message += " Doubles!"
    }
    console.log(message)
  }



}

main();