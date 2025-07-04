function loadMatches(baseUrl, onSuccess) { //Зареждаме всички мачове !!! ВАЖНО за FETCH  //send a GET request to the server to fetch all matches from your local database
    fetch(baseUrl)
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Eroor: ', error));
}
//ТОВА Е API-то ! 
function createMatches(baseUrl, match, onSuccess) {
    fetch(baseUrl, {
        method: 'POST',
        body: JSON.stringify(match)
    }) //щом го създаваме трябва да е с METHOD
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Eroor: ', error));
}
function updateMatches(baseUrl, match, onSuccess) {
    fetch(baseUrl + match._id, {
        method: 'PUT',
        body: JSON.stringify(match)
    }) //трябва да е с METHOD
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Eroor: ', error));
}
function deleteMatches(baseUrl, match, onSuccess) {
    fetch(baseUrl + match._id, {
        method: 'DELETE'
    }) //трябва да е с METHOD, но без BODY, защото трябва само да го махнем
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Eroor: ', error));
}

//Utility funciont //OT 2-ра задача, за създаване на елемент :) 
function createElement(tag, properties, container) { //Функцията createElement е помощна функция за създаване на HTML елементи 
    const element = document.createElement(tag);

    Object.keys(properties).forEach(key => {
        if (typeof properties[key] === 'object') {
            Object.assign(element[key], properties[key])
        } else {
            element[key] = properties[key];
        }
    });

    if (container) container.append(element);

    return element;
}

//DOM CODE ! //функцията която ще се изпълни когато кажем
function init() {
    const baseUrl = 'http://localhost:3030/jsonstore/matches/'; //първия линк 
    //взимаме си елементите
    const fields = [...document.querySelectorAll('#form form input[type="text"]')]; // това ни връща type == text, ще бъде в масив [...]
    const btnAddMatchEl = document.querySelector('#add-match');
    const btnEditMatchEl = document.querySelector('#edit-match');
    const listEl = document.querySelector('#list');

    btnAddMatchEl.addEventListener('click', createHandler);
    btnEditMatchEl.addEventListener('click', updateHandler);



    function loadEntries() {
        listEl.innerHTML = '';
        loadMatches(baseUrl, (result) => {
            Object.values(result).forEach(createEntry);
        });
    }
    function createEntry({ host, score, guest, _id }) { //създава елементите
        //от втора задача :) 
        const entryEl = createElement('li', { className: 'match', dataset: { host, score, guest, _id } }, listEl); //  // Създаване на <li> с атрибути dataset
        const infoEl = createElement('div', { className: 'info' }, entryEl);
        createElement('p', { textContent: host }, infoEl); //  // Добавяне на параграфи с информацията за събитието
        createElement('p', { textContent: score }, infoEl);  // Добавяне на параграфи с информацията за събитието
        createElement('p', { textContent: guest }, infoEl);  // Добавяне на параграфи с информацията за събитието

        const buttonEl = createElement('div', { className: 'btn-wrapper' }, entryEl);   // Създаване на бутоните Edit и Next
        createElement('button', { className: 'change-btn', textContent: 'Change', onclick: changeHandler }, buttonEl);
        createElement('button', { className: 'delete-btn', textContent: 'Delete', onclick: deleteHandler }, buttonEl);

    }
    function deleteEntry({ host, score, guest, _id }) {
        listEl.querySelector(`li[data-_id="${_id}"]`).remove();
    }

    function createHandler(e) {
        e.preventDefault();
        const [host, score, guest] = fields.map(field => field.value);
        if (!host || !score || !guest) return;
        const match = { host, score, guest };
        createMatches(baseUrl, match, (result) => {
            createEntry(result);
        });

        fields.forEach(field => field.value = '');
    }

    function changeHandler(e) { // за change
        const entryEL = e.target.closest('li');
        const values = Object.values(entryEL.dataset);
        fields.forEach((field, index) => field.value = values[index]);

        entryEL.classList.add('active');
        btnAddMatchEl.disabled = true;
        btnEditMatchEl.disabled = false;
    }
    function updateHandler(e) {
        e.preventDefault();
        const [host, score, guest] = fields.map(field => field.value);
        if (!host || !score || !guest) return;

        const entryEL = listEl.querySelector('li.active');
        const match = { host, score, guest, _id: entryEL.dataset._id };
        updateMatches(baseUrl, match, (result) => {
            loadEntries();
            fields.forEach(field => field.value = '');
            btnAddMatchEl.disabled = false;
            btnEditMatchEl.disabled = true;
        });

    }
    function deleteHandler(e) { //за delete 
        const entryEL = e.target.closest('li');
        const match = Object.assign({}, entryEL.dataset);
        deleteMatches(baseUrl, match, (result) => {
            deleteEntry(result);
        });

    }

    loadEntries();
}
document.addEventListener('DOMContentLoaded', init);


