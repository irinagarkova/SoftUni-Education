function calculateTotalPrice(peopleCount, groupType, day) {
    let pricePerPerson;

    // Determine the price per person based on the group type and day of the week
    switch (groupType) {
        case 'Students':
            if (day === 'Friday') pricePerPerson = 8.45;
            else if (day === 'Saturday') pricePerPerson = 9.80;
            else if (day === 'Sunday') pricePerPerson = 10.46;
            break;
        case 'Business':
            if (day === 'Friday') pricePerPerson = 10.90;
            else if (day === 'Saturday') pricePerPerson = 15.60;
            else if (day === 'Sunday') pricePerPerson = 16.00;
            break;
        case 'Regular':
            if (day === 'Friday') pricePerPerson = 15.00;
            else if (day === 'Saturday') pricePerPerson = 20.00;
            else if (day === 'Sunday') pricePerPerson = 22.50;
            break;
    }

    let totalPrice = pricePerPerson * peopleCount;

    // Apply discounts based on group type and size
    if (groupType === 'Students' && peopleCount >= 30) {
        totalPrice *= 0.85; // 15% discount
    } else if (groupType === 'Business' && peopleCount >= 100) {
        totalPrice -= pricePerPerson * 10; // 10 people stay for free
    } else if (groupType === 'Regular' && peopleCount >= 10 && peopleCount <= 20) {
        totalPrice *= 0.95; // 5% discount
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

// Test cases
calculateTotalPrice(30, 'Students', 'Sunday');
calculateTotalPrice(100, 'Business', 'Saturday');
