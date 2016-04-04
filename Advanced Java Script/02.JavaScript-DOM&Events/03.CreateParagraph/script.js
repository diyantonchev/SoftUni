function createParagraph(id, text) {
    "use strict";
    if (text) {
        var element, paragraph;
        element = document.getElementById(id);
        paragraph = document.createElement('p');
        paragraph.innerText = text;
        element.appendChild(paragraph);
    }
}

var paragraphAdder = document.getElementById('paragraph-adder');
paragraphAdder.addEventListener('click', function (e) {
    "use strict";
    var id, text;
    id = 'wrapper';
    text = document.getElementById('text-field').value;
    createParagraph(id, text);
    console.log(e);
}, false);