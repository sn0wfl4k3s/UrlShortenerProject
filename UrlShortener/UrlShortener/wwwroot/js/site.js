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