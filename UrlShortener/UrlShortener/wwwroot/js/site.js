const time = 100;
const phrase = 'Welcome'.split('');
const tag = document.getElementById('apresentacao');

function loadApresentacao(n) {
    setTimeout(function () {
        if (n < phrase.length) {
            tag.innerHTML += phrase[n];
            loadApresentacao(++n);
        }
    }, time);
}

window.open = loadApresentacao(0);


// página de resultados ↓

$(document).ready(function () {
    $('[data-toggle="popover"]').popover();
});

var copyTextareaBtn = document.querySelector('.copiar');

copyTextareaBtn.addEventListener('click', function (event) {
    var copyTextarea = document.querySelector('.textarea');
    copyTextarea.select();
    try {
        var successful = document.execCommand('copy');
    } catch (err) {
        alert('Opa, Não conseguimos copiar o texto, é possivel que o seu navegador não tenha suporte, tente usar Crtl+C.');
    }
});