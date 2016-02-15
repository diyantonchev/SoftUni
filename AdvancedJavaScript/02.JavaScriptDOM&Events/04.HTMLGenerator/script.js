var htmlGenerator = (function () {
    "use strict";

    function createParagraph(id, text) {
        if (text) {
            var element, paragraph;
            element = document.getElementById(id);
            paragraph = document.createElement('p');
            paragraph.innerText = text;
            element.appendChild(paragraph);
        }
    }

    function createDiv(id, className) {
        var element, div;
        element = document.getElementById(id);
        div = document.createElement('div');
        div.className = className;
        element.appendChild(div);
    }

    function createLink(id, text, link) {
        var element, a;
        element = document.getElementById(id);
        a = document.createElement('a');
        a.href = link;
        a.innerText = text;
        element.appendChild(a);
    }

    return {
        createParagraph: createParagraph,
        createDiv: createDiv,
        createLink: createLink
    };
}());

htmlGenerator.createParagraph('wrapper', 'Soft Uni');
htmlGenerator.createDiv('wrapper', 'section');
htmlGenerator.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');
