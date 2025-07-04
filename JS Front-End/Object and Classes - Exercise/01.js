function createEmployeeList(employeeNames) {
    // Създаваме обект за съхранение на служителите
    const employees = {};

    // Добавяме всеки служител в обекта с дължината на името като личен номер
    employeeNames.forEach(name => {
        employees[name] = name.length;
    });

    // Принтираме информацията за всеки служител
    for (const name in employees) {
        console.log(`Name: ${name} -- Personal Number: ${employees[name]}`);
    }
}

// Примерен вход
const names = ['Silas Butler','Adnaan Buckley','Juan Peterson','Brendan Villarreal'];
createEmployeeList(names);
