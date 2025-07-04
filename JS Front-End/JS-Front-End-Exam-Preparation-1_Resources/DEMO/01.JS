function superheroAlliance(input) {
    const n = parseInt(input.shift()); // Брой супергерои
    const heroes = {};

    // Четене на информацията за супергероите
    for (let i = 0; i < n; i++) {
        let [name, superpowers, energy] = input.shift().split("-");
        heroes[name] = {
            superpowers: superpowers.split(","),
            energy: parseInt(energy),
        };
    }

    // Обработка на командите
    for (let command of input) {
        if (command === "Evil Defeated!") break;

        let [action, heroName, param1, param2] = command.split(" * ");

        switch (action) {
            case "Use Power":
                let superpower = param1;
                let energyRequired = parseInt(param2);

                if (
                    heroes[heroName].superpowers.includes(superpower) &&
                    heroes[heroName].energy >= energyRequired
                ) {
                    heroes[heroName].energy -= energyRequired;
                    console.log(
                        `${heroName} has used ${superpower} and now has ${heroes[heroName].energy} energy!`
                    );
                } else {
                    console.log(
                        `${heroName} is unable to use ${superpower} or lacks energy!`
                    );
                }
                break;

            case "Train":
                let trainingEnergy = parseInt(param1);
                let currentEnergy = heroes[heroName].energy;
                let newEnergy = Math.min(currentEnergy + trainingEnergy, 100);
                let energyGained = newEnergy - currentEnergy;

                if (currentEnergy === 100) {
                    console.log(`${heroName} is already at full energy!`);
                } else {
                    heroes[heroName].energy = newEnergy;
                    console.log(
                        `${heroName} has trained and gained ${energyGained} energy!`
                    );
                }
                break;

            case "Learn":
                let newSuperpower = param1;

                if (heroes[heroName].superpowers.includes(newSuperpower)) {
                    console.log(`${heroName} already knows ${newSuperpower}.`);
                } else {
                    heroes[heroName].superpowers.push(newSuperpower);
                    console.log(`${heroName} has learned ${newSuperpower}!`);
                }
                break;
        }
    }

    // Извеждане на финалното състояние на супергероите
    for (let hero in heroes) {
        console.log(`Superhero: ${hero}`);
        console.log(`- Superpowers: ${heroes[hero].superpowers.join(", ")}`);
        console.log(`- Energy: ${heroes[hero].energy}`);
    }
}

// Тестови вход
superheroAlliance([
    "3",
    "Iron Man-Repulsor Beams,Flight-80",
    "Thor-Lightning Strike,Hammer Throw-10",
    "Hulk-Super Strength-60",
    "Use Power * Iron Man * Flight * 30",
    "Train * Thor * 20",
    "Train * Hulk * 50",
    "Learn * Hulk * Thunderclap",
    "Use Power * Hulk * Thunderclap * 70",
    "Evil Defeated!",
]);
