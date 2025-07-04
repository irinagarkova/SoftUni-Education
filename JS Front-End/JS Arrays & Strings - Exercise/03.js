function listOfNames(array) {
    array.sort();
    array.forEach((name, index) => {
        console.log(`${index + 1}.${name}`);
    });
}
listOfNames(["John", "Bob", "Christina", "Ema"]);