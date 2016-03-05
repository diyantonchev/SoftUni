function replaceATag(string) {
    var matchPattern = /<a(.*?)>(.*?)<\/a>/g;
    var replacementPattern = '[URL$1]$2[/URL]'
    return string.replace(matchPattern, replacementPattern);
}

var htmlText = '<ul>\n\t<li>\n\t<a href=http://softuni.bg>SoftUni</a>\n\t</li>\n</ul>';

var replaced = replaceATag(htmlText);
console.log(replaced);