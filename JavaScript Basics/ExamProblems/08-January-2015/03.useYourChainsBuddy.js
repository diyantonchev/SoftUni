function solve(html) {
    const regex = /<p>([^\/]+)</g;
    var finalText = [];
    html.forEach(function (row) {
        var text, match, decryptedText = [], index;
        while (match = regex.exec(row)) {
            text = match[1];
            text = text.replace(/[^a-z0-9]+/g, ' ');
            for (index = 0; index < text.length; index++) {
                if (/[a-m]/.test(text[index])) {
                    decryptedText.push(String.fromCharCode(text[index].charCodeAt(0) + 13));
                } else if (/[n-z]/.test(text[index])) {
                    decryptedText.push(String.fromCharCode(text[index].charCodeAt(0) - 13));
                } else {
                    decryptedText.push(text[index]);
                }
            }
        }

        if (decryptedText) {
            finalText.push(decryptedText.join(''));
        }
    });

    return finalText.join();
}