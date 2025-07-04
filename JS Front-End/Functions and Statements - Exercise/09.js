function visualizeLoadingBar(percentage) {
    const barsLength = 10;
    const barFilled = Math.round(percentage / barsLength);
    const barsEmpty = barsLength - barFilled;

    const before = (percentage < 100) ? `${percentage}% ` : `100% Complete!\n`;
    const progressBar = `[${'%'.repeat(barFilled)}${'.'.repeat(barsEmpty)}]\n`;
    const after = (percentage < 100) ? `Still loading...` : '';
    console.log(before + progressBar + after);

}
visualizeLoadingBar(50);
visualizeLoadingBar(10);
visualizeLoadingBar(100);