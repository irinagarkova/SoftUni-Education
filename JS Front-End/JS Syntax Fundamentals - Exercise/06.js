function sumOfDigits(number) {
    // Преобразуваме числото в низ (string) и след това го разделяме на масив от цифри
    const digits = number.toString().split('');
    
    // Използваме reduce, за да намерим сумата на всички цифри
    const sum = digits.reduce((acc, digit) => acc + Number(digit), 0);
    
    return sum;
}
sumOfDigits(245678);