window.addEventListener("load", solve);

function solve() {
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
//селектират се елементи от ДОМ
  const fields = [...document.querySelectorAll('#name, #time, #description')]; //съдържа масив от input полетата за името, времето и описанието.
  const btnAddEl = document.querySelector('#add-btn'); // добавяне на събитие

  const listPreviewEl = document.querySelector('#preview-list'); // елементите за визуализация и архивиране.
  const listArchiveEl = document.querySelector(`#archive-list`);// елементите за визуализация и архивиране.

  function createEntry({ name, time, desc }) { //създава нов запис (елемент в preview-list), който съдържа информация за събитието
    
    const entryEl = createElement('li', { dataset: { name, time, desc } }, listPreviewEl); //  // Създаване на <li> с атрибути dataset
    const articleEl = createElement('article', {}, entryEl); //  // Създаване на <article> елемент вътре в <li>
    createElement('p', { textContent: name }, articleEl); //  // Добавяне на параграфи с информацията за събитието
    createElement('p', { textContent: time }, articleEl);  // Добавяне на параграфи с информацията за събитието
    createElement('p', { textContent: desc }, articleEl);  // Добавяне на параграфи с информацията за събитието

    const buttonEl = createElement('div', { className: 'buttons' }, articleEl);   // Създаване на бутоните Edit и Next
    createElement('button', { className: 'edit-btn', textContent: 'Edit', onclick: editHandler }, buttonEl);
    createElement('button', { className: 'next-btn', textContent: 'Next', onclick: nextHandler }, buttonEl);

  }
  btnAddEl.addEventListener('click', (e) => {
    e.preventDefault();

    const [name, time, desc] = fields.map(field => field.value); //Извлича стойностите от полетата и проверява дали са непразни.
    if (!name || !time || !desc) return;

    createEntry({ name, time, desc });

    e.target.disabled = true; //Деактивира бутона [Add] и изчиства полетата.
    fields.forEach(field => field.value = '');


  });

  function editHandler(e) { //Обработва кликването на [Edit] бутона
    const entryEl = e.target.closest('li'); // Намира най-близкия <li> елемент
    entryEl.remove();// Премахва записа от preview-list
    const values = [entryEl.dataset.name, entryEl.dataset.time, entryEl.dataset.desc];   // Извлича данните от dataset

    fields.forEach((field, index) => field.value = values[index]);  // Връща стойностите обратно в input полетата
    btnAddEl.disabled = false; //Активира бутона [Add].
  }
  function nextHandler(e) { //Обработва кликването на [Next] бутона:

    const entryEl = e.target.closest('li');
    entryEl.remove(); //Премахва [Edit] и [Next] бутоните.

    entryEl.querySelector('div.buttons').remove; //Премахва [Edit] и [Next] бутоните.
    createElement('button', {className: 'archive-btn', textContent:'Archive', onclick: archiveHandler}, entryEl); //Премества записа от preview-list в archive-list.
    listArchiveEl.append(entryEl);

  }
  function archiveHandler(e){ //Обработва кликването на [Archive] бутона
    
    const entryEl = e.target.closest('li');
    entryEl.remove();//Изтрива записа от archive-list.
    btnAddEl.disabled = false; //Активира бутона [Add].
  }
}