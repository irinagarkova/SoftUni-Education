function  parseTable(input){
    input.forEach(element => {
        const [town, latitude, longitude] = element.split(" | ");
        const formattedLatitude= Number(latitude).toFixed(2);
        const formattedLongitude= Number(longitude).toFixed(2);

        const townInfo={
            town:town,
            latitude:formattedLatitude,
            longitude:formattedLongitude
        };
console.log(townInfo)
    
});
}
parseTable(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625'])