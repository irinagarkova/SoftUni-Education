function checkPalindromes(numbers) {
    numbers.forEach(number => {
        const str = number.toString(); 
        const reversedStr = str.split('').reverse().join(''); 
        console.log(str === reversedStr); 
    });
}

checkPalindromes([123,323,421,121]); 