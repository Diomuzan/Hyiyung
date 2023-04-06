console.log('Opdracht 4 - JS bestand geladen');

let list = document.querySelectorAll('.divlist');
let i = 0;
while (i < list.length) {
  const showItem = list[i];
  console.log(showItem);
  i++;
}