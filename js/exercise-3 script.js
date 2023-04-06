console.log('Opdracht 3 - JS bestand geladen');
const className = "T1N";

function myFunction() {
  alert(className)
  const Button = document.querySelector('.btn');
  Button.addEventListener('click', myFunction);
}
const Button = document.querySelector('.btn');
Button.addEventListener('click', myFunction);
