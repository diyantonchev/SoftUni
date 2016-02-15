function countDivs(html)  {
    var openingTags = html.match(/<div[^>]*?>/g);
    var closingTags = html.match(/<\/div>/g);

    return Math.min(openingTags.length, closingTags.length);
}

var html = [
    '<!DOCTYPE html>',
    '<html>',
    '<head lang="en">',
    '    <meta charset="UTF-8">',
    '    <title>index</title>',
    '    <script src="/yourScript.js" defer></script>',
    '</head>',
    '<body>',
    '    <div id="outerDiv">',
    '        <div',
    '    class="first">',
    '            <div><div>hello</div></div>',
    '        </div>',
    '        <div>hi<div></div></div>        ',
    '        <div>I am a div</div>',
    '    </div>',
    '</body>',
    '</html>'
].join('');

var count = countDivs(html);
console.log(count);