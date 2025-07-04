function printMatrix(n) {
    for (let i = 0; i < n; i++) {
        console.log((Array(n).fill(n)).join(' '));
    }
}

printMatrix(3);